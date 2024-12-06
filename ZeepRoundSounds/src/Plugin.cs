using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace ZeepRoundSounds.src
{
    [BepInPlugin("andme123.ZeepRoundSounds", "ZeepRoundSounds", "1.0.0")]
    [BepInDependency("ZeepSDK")]
    public class Plugin : BaseUnityPlugin
    {
        private Harmony harmony;
        internal static new ManualLogSource Logger;

        public static Plugin Instance { get; private set; }

        private void Awake()
        {
            // Plugin startup logic
            Instance = this; // Assign the static instance
            Logger = base.Logger;
            harmony = new Harmony("andme123.ZeepRoundSounds");
            harmony.PatchAll();
            Logger.LogInfo($"Plugin {"andme123.ZeepRoundSounds"} is loaded!");

            ModConfig.Initialize(Config);

            gameObject.AddComponent<SER_GameEventsManager>();
            gameObject.AddComponent<SER_SoundEffectManager>();
        }



        private void OnDestroy()
        {
            harmony?.UnpatchSelf();
            harmony = null;
        }
    }
}
