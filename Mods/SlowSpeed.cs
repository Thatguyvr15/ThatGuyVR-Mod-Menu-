using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class SlowSpeed
    {
        public static void SlowSpeedMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 1f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 1f;
        }
    }
}
