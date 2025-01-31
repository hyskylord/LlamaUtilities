﻿using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using Buddy.Coroutines;
using Clio.XmlEngine;
using ff14bot.Managers;
using ff14bot.RemoteWindows;
using LlamaLibrary.Logging;
using TreeSharp;
using static LlamaLibrary.Helpers.GeneralFunctions;

namespace LlamaUtilities.OrderbotTags
{
    [XmlElement("GearSetEquipAll")]
    public class GearSetEquipAll : LLProfileBehavior
    {
        private bool _isDone;

        [XmlAttribute("RecommendEquip")]
        [XmlAttribute("recommendequip")]
        [DefaultValue(true)]
        private bool UseRecommendEquip { get; set; }

        public override bool HighPriority => true;

        public override bool IsDone => _isDone;

        public GearSetEquipAll() : base() { }

        protected override void OnStart()
        {
        }

        protected override void OnDone()
        {
        }

        protected override void OnResetCachedDone()
        {
            _isDone = false;
        }

        protected override Composite CreateBehavior()
        {
            return new ActionRunCoroutine(r => RunEquip());
        }

        private async Task RunEquip()
        {
            if (_isDone)
            {
                await Coroutine.Yield();
                return;
            }

            var groupedGearSets = GearsetManager
                                                   .GearSets
                                                   .Where(g => g.InUse)
                                                   .OrderByDescending(GetGearSetiLvl)
                                                   .GroupBy(g => g.Class)
                                                   .Select(g => g.FirstOrDefault());

            await Coroutine.Sleep(4000);

            foreach (var gearSet in groupedGearSets)
            {
                GearsetManager.ChangeGearset(gearSet.Index);
                if (await Coroutine.Wait(1200, () => SelectYesno.IsOpen))
                {
                    SelectYesno.ClickYes();
                    await Coroutine.Sleep(800);
                }

                await InventoryEquipBest(useRecommendEquip: UseRecommendEquip);
                await Coroutine.Sleep(400);
            }

            _isDone = true;
        }
    }
}