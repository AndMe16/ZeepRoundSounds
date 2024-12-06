using UnityEngine;
using ZeepSDK.Racing;

namespace ZeepRoundSounds.src
{
    public class SER_GameEventsManager : MonoBehaviour
    {

        // Sound Effects
        SER_SoundEffectManager soundEffectManager;

        void Start()
        {
            soundEffectManager = FindObjectOfType<SER_SoundEffectManager>();

            RacingApi.LevelLoaded += OnRoundStarted;
            RacingApi.RoundEnded += OnRoundEnded;
        }

        private void OnRoundEnded()
        {
            soundEffectManager.PlaySound("EndedRoundSound");
        }

        private void OnRoundStarted()
        {
            soundEffectManager.PlaySound("StartedRoundSound");
        }

        private void OnDestroy()
        {
            RacingApi.RoundStarted -= OnRoundStarted;
            RacingApi.RoundEnded -= OnRoundEnded;
        }
    }
}
