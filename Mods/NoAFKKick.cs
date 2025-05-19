using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class NoAFKKick
    {
        public static void NoAFKKickMod()
        {
            static void Update()
            {
                {
                    GorillaLocomotion.GTPlayer.Instance.isUserPresent = true;
                }
            }
        }
    }
}
