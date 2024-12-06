using BepInEx.Configuration;
using UnityEngine;

namespace ZeepRoundSounds.src
{
    public class ModConfig : MonoBehaviour
    {
        public static ConfigEntry<int> sFX_volume;

        // Constructor that takes a ConfigFile instance from the main class
        public static void Initialize(ConfigFile config)
        {
            sFX_volume = config.Bind("1. Audio", "1.1. SFX Volume", 100, new ConfigDescription("SFX volume [0-100]", new AcceptableValueRange<int>(0, 100)));
        }
    }
}
