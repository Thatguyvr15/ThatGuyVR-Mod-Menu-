using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class SpeedBoost
    {
        public static void SpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 9f;
        }
    }
}
