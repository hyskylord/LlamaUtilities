using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using Buddy.Coroutines;
using Clio.XmlEngine;
using ff14bot.Managers;
using LlamaLibrary.Helpers;
using LlamaLibrary.Logging;
using TreeSharp;
using static LlamaLibrary.Helpers.GeneralFunctions;

namespace LlamaUtilities.OrderbotTags
{
    [XmlElement("LLFCDepositItem")]
    public class LLFCDepositItem : LLProfileBehavior
    {
        [XmlAttribute("ItemIDs")]
        [XmlAttribute("ItemIds")]
        [XmlAttribute("ItemID")]
        [XmlAttribute("ItemId")]
        [DefaultValue(new int[0])]
        private int[] ItemIds { get; set; }

        private bool _isDone;

        public override bool HighPriority => true;

        public override bool IsDone => _isDone;

        public LLFCDepositItem() : base()
        {
        }

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
            return new ActionRunCoroutine(r => FCDepositItem());
        }

        private async Task FCDepositItem()
        {
            if (_isDone)
            {
                await Coroutine.Yield();
                return;
            }

            await CompanyChestHelper.DepositItems(InventoryManager.FilledInventoryAndArmory.Where(x => ItemIds.Contains((int) x.RawItemId)));

            _isDone = true;
        }
    }
}