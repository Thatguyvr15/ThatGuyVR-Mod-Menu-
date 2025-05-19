using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    class NoTagFreeze
    {
        public static bool isEnabled = false;
        public static void NoTagFreezeMod()
        {
            static void Update()
            {
                if (isEnabled)
                {
                    if (GorillaLocomotion.GTPlayer.Instance.disableMovement)
                    {
                       GorillaLocomotion.GTPlayer.Instance.disableMovement = false;
                    }
                }
            }
        }
    }
}
