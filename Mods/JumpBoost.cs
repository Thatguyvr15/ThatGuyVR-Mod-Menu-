using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    class JumpBoost
    {
        public static void JumpBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 9f;
        }
    }
}
