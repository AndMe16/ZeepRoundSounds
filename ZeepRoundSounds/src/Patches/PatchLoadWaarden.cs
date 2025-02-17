﻿using System;
using HarmonyLib;

namespace ZeepRoundSounds.src.Patches
{
    [HarmonyPatch(typeof(Instellingen), "LoadWaarden")]
    public class PatchLoadWaarden
    {
        public static event Action<GameSettingsScriptableObject> OnLoadWaarden;

        [HarmonyPostfix]
        static void Postfix(Instellingen __instance)
        {
            OnLoadWaarden?.Invoke(__instance.GlobalSettings);
        }
    }
}