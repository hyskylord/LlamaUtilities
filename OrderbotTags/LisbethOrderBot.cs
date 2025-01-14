﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using Buddy.Coroutines;
using Clio.XmlEngine;
using ff14bot;
using ff14bot.AClasses;
using ff14bot.BotBases;
using ff14bot.Managers;
using ff14bot.NeoProfile;
using ff14bot.NeoProfiles;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TreeSharp;

namespace LlamaUtilities.OrderbotTags
{
    [XmlElement("LLisbeth")]
    public class LisbethOrderBot : LLProfileBehavior
    {
        public static bool loaded;
        public static bool tempbool;
        private bool _isDone;

        public override bool HighPriority => true;

        [XmlAttribute("Json")]
        public string Json { get; set; }

        public override bool IsDone => _isDone;

        protected override Color LogColor => Colors.Chocolate;

        public LisbethOrderBot() : base() { }

        private async void MyThread()
        {
            Log.Information("Thread Started");

            var profile = NeoProfileManager.CurrentProfile.Path;

            var lastBot = BotManager.Current;
            BotManager.Current.Stop();
            await TreeRoot.StopGently();

            await WaitUntil(() => !TreeRoot.IsRunning, timeout: 20000);

            if (!TreeRoot.IsRunning)
            {
                Log.Information($"Bot Stopped: {lastBot.Name} {profile}");

                var BotType = AppDomain.CurrentDomain.GetAssemblies().First(i => i.FullName.Contains("Lisbeth.Reborn")).DefinedTypes.First(i => i.Name == "LisbethBot");

                var method = BotType.GetMethod("Load", BindingFlags.Static | BindingFlags.NonPublic);

                if (method != null)
                {
                    method.Invoke(null, null);
                }

                Thread.Sleep(4000);

                BotManager.SetCurrent(BotManager.Bots.First(i => i.EnglishName.Contains("Lisbeth")));
                TreeRoot.Start();
            }
            else
            {
                Log.Information($"Failed Stopping bot");
            }

            await WaitUntil(() => TreeRoot.IsRunning, timeout: 20000);
            if (TreeRoot.IsRunning)
            {
                Log.Information($"Lisbeth Started");

                await WaitWhile(() => TreeRoot.IsRunning, 500);

                if (!TreeRoot.IsRunning)
                {
                    if (lastBot != null)
                    {
                        Log.Information($"Restarting {lastBot.Name}");
                        BotManager.SetCurrent(lastBot);
                        Thread.Sleep(1000);
                        loaded = false;
                        tempbool = false;
                        BotEvents.NeoProfile.OnNewProfileLoaded += OnNewProfileLoaded;
                        TreeRoot.OnStart += OnBotStart;
                        NeoProfileManager.Load(profile);
                        await WaitUntil(() => loaded, timeout: 20000);
                        loaded = false;
                        BotManager.Current.Initialize();
                        BotManager.Current.Start();
                        TreeRoot.Start();
                        await WaitUntil(() => tempbool, timeout: 20000);
                    }
                    else
                    {
                        Log.Information($"LastBot Null: Starting Orderbot");
                        BotManager.SetCurrent(new OrderBot());
                        BotManager.Current.Start();
                    }
                }
            }
            else
            {
                Log.Information($"Failed To Start Lisbeth");
            }

            Log.Information($"Thread Stopped");

            //_isDone = true;
        }

        private async Task<bool> CallLisbeth()
        {
            JObject settings;

            //var dlls = AppDomain.CurrentDomain.GetAssemblies().Where(i => i.FullName.Contains("Lisbeth"));

            var BotType = AppDomain.CurrentDomain.GetAssemblies().First(i => i.FullName.Contains("Lisbeth.Reborn")).DefinedTypes.FirstOrDefault(i => i.Name == "Directories");

            if (BotType == null)
            {
                BotType = AppDomain.CurrentDomain.GetAssemblies().First(i => i.FullName.Contains("Lisbeth")).DefinedTypes.FirstOrDefault(i => i.Name == "Directories");
            }

            Log.Information($"Lisbeth Type {BotType.FullName}");

            var settingsFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), (string)BotType.GetProperty("SettingsPath").GetValue(null));
            var resumePath = Path.Combine(Path.GetDirectoryName(settingsFilePath), "lisbeth-resume.json");
            using (var reader = File.OpenText(settingsFilePath))
            {
                settings = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                settings["Orders"] = JToken.Parse(Json);
            }

            await Coroutine.Sleep(30);

            using (var outputFile = new StreamWriter(settingsFilePath, false))
            {
                outputFile.Write(JsonConvert.SerializeObject(settings, Formatting.None));
            }

            if (File.Exists(resumePath))
            {
                File.Delete(resumePath);
            }

            Log.Information($"Settings Written");

            await Coroutine.Sleep(1000);

            var a = new Thread(MyThread);
            a.Start();

            _isDone = false;
            return true;
        }

        protected override Composite CreateBehavior()
        {
            return new ActionRunCoroutine(r => CallLisbeth());
        }

        private static void OnNewProfileLoaded(BotEvents.NeoProfile.NewProfileLoadedEventArgs args)
        {
            loaded = true;
        }

        private static string CreateOrderJson(List<LisbethOrder> orders)
        {
            return JsonConvert.SerializeObject(orders, Formatting.None);
        }

        private void OnBotStart(BotBase bot)
        {
            Log.Information($"{bot.Name} Started");
            tempbool = true;
        }

        /// <summary>
        ///     Blocks while condition is true or timeout occurs.
        /// </summary>
        /// <param name="condition">The condition that will perpetuate the block.</param>
        /// <param name="frequency">The frequency at which the condition will be check, in milliseconds.</param>
        /// <param name="timeout">Timeout in milliseconds.</param>
        /// <exception cref="TimeoutException"></exception>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task WaitWhile(Func<bool> condition, int frequency = 25, int timeout = -1)
        {
            var waitTask = Task.Run(async () =>
            {
                while (condition())
                {
                    await Task.Delay(frequency);
                }
            });

            if (waitTask != await Task.WhenAny(waitTask, Task.Delay(timeout)))
            {
                throw new TimeoutException();
            }
        }

        /// <summary>
        ///     Blocks until condition is true or timeout occurs.
        /// </summary>
        /// <param name="condition">The break condition.</param>
        /// <param name="frequency">The frequency at which the condition will be checked.</param>
        /// <param name="timeout">The timeout in milliseconds.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task WaitUntil(Func<bool> condition, int frequency = 25, int timeout = -1)
        {
            var waitTask = Task.Run(async () =>
            {
                while (!condition())
                {
                    await Task.Delay(frequency);
                }
            });

            if (waitTask != await Task.WhenAny(waitTask, Task.Delay(timeout)))
            {
                throw new TimeoutException();
            }
        }

        private class LisbethOrder
        {
            public readonly int Amount;
            public readonly bool Enabled = true;
            public readonly int Group;
            public readonly int Id;
            public readonly int Item;
            public readonly string Type;

            public LisbethOrder(int id, int group, int item, int amount, string type)
            {
                Id = id;
                Group = group;
                Item = item;
                Amount = amount;
                Type = type;
            }

            public override string ToString()
            {
                return $"{Id}, {Group}, {Item}, {Amount}, {Enabled}, {Type}";
            }
        }
    }
}