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
    [XmlElement("OpenCoffers")]
    public class OpenCoffers : LLProfileBehavior
    {
        private bool _isDone;


        public override bool HighPriority => true;
        public override bool IsDone => _isDone;

        public OpenCoffers() : base() { }

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
            return new ActionRunCoroutine(r => RunOpenCoffers());
        }

        private async Task RunOpenCoffers()
        {

            await LlamaLibrary.Utilities.Inventory.CofferTask();

            _isDone = true;
        }
    }
}