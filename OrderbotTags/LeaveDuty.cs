﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Media;
using Buddy.Coroutines;
using Clio.XmlEngine;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Managers;
using LlamaLibrary.Helpers;
using LlamaLibrary.Logging;
using TreeSharp;

namespace LlamaUtilities.OrderbotTags
{
    [XmlElement("LLLeaveDuty")]
    public class LeaveDuty : LLProfileBehavior
    {
        private bool _isDone;

        [XmlAttribute("SayGoodbye")]
        [DefaultValue(false)]
        public bool SayGoodbye { get; set; }

        [XmlAttribute("RandomWait")]
        [DefaultValue(false)]
        public bool RandomWait { get; set; }

        public static ChatBroadcaster PartyBroadcaster = new ChatBroadcaster(MessageType.Party);
        public static ChatBroadcaster EmoteBroadcaster = new ChatBroadcaster(MessageType.StandardEmotes);

        public override bool HighPriority => true;

        private static string[] Farewells = new string[]
        {
            "See you later, alligator!",
            "After a while, crocodile.",
            "Stay out of trouble guys.",
            "I’m out of here baby.",
            "Okay...bye, fry guys!",
            "If I don’t see you around, I'll see you square.",
            "Stay classy. Get it? Classy. *snicker*",
            "Fare thee well.",
            "Catch you on the rebound.",
            "Gotta go, buffalo.",
            "Peace out!",
            "Gotta hit the road. Thanks guys",
            "Long live and prosper!",
            "Live long and prosper!",
            "Well, I'm off!",
            "Smoke me a kipper, I'll be back for breakfast.",
            "Bye-bye, butterfly.",
            "Gotta get going.",
            "It has been emotional, bye.",
            "Out to the door, dinosaur.",
            "Catch you on the flip side.",
            "Gotta bolt!",
            "See you soon, raccoon.",
            "You're still here? It's over. Go home. Go!",
            "It's been fun! Don't get run over on your way out!",
            "It's been fun! Don't let the door hit you on your way out!",
            "Have a good one.",
            "Hasta la vista, baby.",
            "Later, haters.",
            "I gotta bounce.",
            "Toodle-pip!",
            "Catch you later!",
            "See you on the other side.",
            "Have fun storming the castle!",
            "Adieu, cockatoo!",
            "It's been a pleasure and a privilege to meet you guys.",
            "Don't get attacked by a bear, it's nighttime!",
            "Be good and don't get caught.",
            "Thank you for your cooperation. Farewell.",
            "I am the weakest link. Goodbye!",
            "I look forward to our next meeting.",
            "I'm gonna make like a bakery truck and haul buns.",
            "Gotta roll!",
            "Autobots! Roll out!",
            "Oh, and in case I don't see you—good afternoon, good evening, and good night!",
            "Influence everyone in a good way!",
            "Don't forget to come back!",
            "Once more unto the breach, dear friends!",
            "See ya, wouldn't wanna be ya.",
            "Peace out, girl scout!",
            "You guys did awesome, thank you for having me!.",
            "Awesome, couldn't have done it without you guys.",
            "GG",
            "pew",
            "gg thanks",
            "ggs lads",
            "ggty",
            "GG thank you all",
            "gg",
            "ggs",
            "cya",
            "thanks",
            "ezpz",
            "tygg",
            "cheers",
            "Nice and clean, thanks!",
            "/goodbye",
            "gg everyone",
            "gg everyone, thank you",
            "ez",
            "Gg!",
            "Great job all!",
            "ggggggggggggggggggg",
            "RIP",
            "tyfp!",
            "GG everyone, thanks a lot.",
            "Welp, that was a lot of work. Think I need a shower now."
        };

        public override bool IsDone => _isDone;

        private static readonly Random _random = new Random();

        public LeaveDuty() : base()
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
            return new ActionRunCoroutine(r => LeaveDutyTask());
        }

        private async Task LeaveDutyTask()
        {
            Random rnd = new Random();
            int waitTime = rnd.Next(45000, 90000);

            if (SayGoodbye)
            {
                string sentfarewell = Farewells[_random.Next(0, Farewells.Length)];

                Log.Information($"Saying '{sentfarewell}' the group");
                await PartyBroadcaster.Send(sentfarewell);
            }

            if (RandomWait)
            {
                Log.Information($"Leaving dungeon in {waitTime / 1000} seconds or when party has disbanded.");
                await Coroutine.Wait(waitTime, () => !PartyManager.IsInParty);
            }

            ff14bot.Managers.DutyManager.LeaveActiveDuty();
            await Coroutine.Wait(20000, () => CommonBehaviors.IsLoading);
            if (CommonBehaviors.IsLoading)
            {
                await Coroutine.Wait(-1, () => !CommonBehaviors.IsLoading);
            }

            _isDone = true;
        }
    }
}