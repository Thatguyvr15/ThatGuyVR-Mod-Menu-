using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    class SuperSpeed
    {
        public static void SuperSpeedMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 99f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 99f;
        }
    }
}
