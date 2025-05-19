using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;
using UnityEngine;
using System.Collections;
namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "TikTok", method =() => TikTokLink.TikTok(), isTogglable = false,toolTip = "Menu Devs TikTok"},
                new ButtonInfo { buttonText = "Discord", method =() => DiscordLink.Discord(), isTogglable = false,toolTip = "Discord"},
                new ButtonInfo { buttonText = "Jump Boost", method =() => JumpBoost.JumpBoostMod(), toolTip = "Enables a slight Jump boost"},                
                new ButtonInfo { buttonText = "No AFK Kick", method =() => NoAFKKick.NoAFKKickMod(), toolTip = "Disables the AFK Kick"},
                new ButtonInfo { buttonText = "Slow Player Speed", method =() => SlowSpeed.SlowSpeedMod(), toolTip = "Enables Slow Player Speed"},
                new ButtonInfo { buttonText = "Speed Boost", method =() => SpeedBoost.SpeedBoostMod(), toolTip = "Enables a slight Speed Boost"},
                new ButtonInfo { buttonText = "Super Speed", method =() => SuperSpeed.SuperSpeedMod(), toolTip = "Enables Super Speed"},
                new ButtonInfo { buttonText = "Super Jump", method =() => SuperJump.SuperJumpMod(), toolTip = "Enables Super Jump"},
                new ButtonInfo { buttonText = "FPS Unlocker", method =() => FPSUnlocker.FPSUnlockerMod(), toolTip = "Unlocks The FPS"},
                new ButtonInfo { buttonText = "No Tag Freeze", method =() => NoTagFreeze.NoTagFreezeMod(), toolTip = "Disables the Tag Freeze"},
                new ButtonInfo { buttonText = "Game Mode Set Casual", method =() => GameModeCasual.GameModeSetCasual(), isTogglable = false,toolTip = "Sets to GameMode to Casual"},
                new ButtonInfo { buttonText = "Game Mode Set Infection", method =() => GameModeInfection.GameModeSetInfection(), isTogglable = false,toolTip = "Sets GameMode to Infection"},
                new ButtonInfo { buttonText = "Game Mode Set Guardian", method =() => GameModeGuardian.GameModeSetGuardian(), isTogglable = false, toolTip = "Sets GameMode to Guardian"},
                new ButtonInfo { buttonText = "Game Mode Set Freeze Tag", method =() => GameModeFreezeTag.GameModeSetFreezeTag(), isTogglable = false, toolTip = "Sets GameMode to FreezeTag"},
                new ButtonInfo { buttonText = "Game Mode Set Hunt", method =() => GameModeHunt.GameModeSetHunt(), isTogglable = false, toolTip = "Sets GameMode to Hunt"},
                new ButtonInfo { buttonText = "Quit Gorilla Tag", method =() => QuitGame.ExitGame(), isTogglable = false, toolTip = "Quits the Game."},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "regular placeholder 1", isTogglable = false}
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "regular placeholder 1", isTogglable = false}
            },
        };
    }
}
