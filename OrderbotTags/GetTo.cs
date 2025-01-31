﻿//
// LICENSE:
// This work is licensed under the
//     Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.
// also known as CC-BY-NC-SA.  To view a copy of this license, visit
//      http://creativecommons.org/licenses/by-nc-sa/3.0/
// or send a letter to
//      Creative Commons // 171 Second Street, Suite 300 // San Francisco, California, 94105, USA.
//

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Media;
using Clio.Utilities;
using Clio.XmlEngine;
using ff14bot.Behavior;
using ff14bot.Navigation;
using LlamaLibrary.Helpers;
using LlamaLibrary.Logging;
using TreeSharp;

namespace LlamaUtilities.OrderbotTags
{
    [XmlElement("LLGetTo")]
    public class GetTo : LLProfileBehavior
    {
        [XmlAttribute("XYZ")]
        public Vector3 XYZ { get; set; }

        [XmlAttribute("ZoneId")]
        public int ZoneId { get; set; }

        private bool _generatedNodes = false;

        public override bool IsDone => FinalizedPath?.Count == 0;

        public override bool HighPriority => true;

        public GetTo() : base() { }

        protected override void OnResetCachedDone()
        {
            _generatedNodes = false;
            FinalizedPath = null;
        }

        public Queue<NavGraph.INode> FinalizedPath;
        protected override void OnStart()
        {
        }

        protected override void OnDone()
        {
        }

        private async Task<bool> GenerateNodes()
        {
            var path = await NavGraph.GetPathAsync((uint)ZoneId, XYZ);
            if (path == null)
            {
                Log.Error($"Couldn't get a path to {XYZ} on {ZoneId}, Stopping.");
                return true;
            }

            _generatedNodes = true;
            FinalizedPath = path;
            return true;
        }

        protected override Composite CreateBehavior()
        {
            return new PrioritySelector(
                CommonBehaviors.HandleLoading,

                //new Decorator(r => !_generatedNodes, new ActionRunCoroutine(r => GenerateNodes())),
                //NavGraph.NavGraphConsumer(r => FinalizedPath)
                new Decorator(r => !_generatedNodes, new ActionRunCoroutine(t => Lisbeth.TravelTo(ZoneId.ToString(), XYZ)))
                );
        }
    }
}