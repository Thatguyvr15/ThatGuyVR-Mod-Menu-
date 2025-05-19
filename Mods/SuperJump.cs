using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class SuperJump
    {
        public static void SuperJumpMod()
        {
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 99f;
        }
    }
}
