﻿using System.Collections;
using System.ComponentModel;
using System.Threading.Tasks;
using Buddy.Coroutines;
using Clio.XmlEngine;
using ff14bot.Enums;
using ff14bot.Managers;
using TreeSharp;
using System.Linq;
using static LlamaLibrary.Helpers.GeneralFunctions;

namespace LlamaUtilities.OrderbotTags
{
    [XmlElement("UseUnlockables")]
    public class UseUnlockables : LLProfileBehavior
    {
        private bool _isDone;


        public override bool HighPriority => true;
        public override bool IsDone => _isDone;

        public UseUnlockables() : base() { }

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
            return new ActionRunCoroutine(r => RunUseUnlockables());
        }

        private async Task RunUseUnlockables()
        {

            await LlamaLibrary.Utilities.Inventory.UseUnlockablesAsync();

            _isDone = true;
        }
    }
}