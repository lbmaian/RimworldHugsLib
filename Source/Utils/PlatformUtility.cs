﻿using UnityEngine;
using Verse;

namespace HugsLib.Utils {
    /// <summary>
    /// A tool to identify the platform the game is running on.
    /// </summary>
    public static class PlatformUtility {
        public static PlatformType GetCurrentPlatform() {
            // Will need changing if another platform is supported by RimWorld in the future
            if (UnityData.platform == RuntimePlatform.OSXPlayer ||
                    UnityData.platform == RuntimePlatform.OSXEditor)
                return PlatformType.MacOSX;
            else if (UnityData.platform == RuntimePlatform.WindowsPlayer ||
                    UnityData.platform == RuntimePlatform.WindowsEditor)
                return PlatformType.Windows;
            else if (UnityData.platform == RuntimePlatform.LinuxPlayer)
                return PlatformType.Linux;
            else
                return PlatformType.Unknown;
        }
    }

    public enum PlatformType { Linux, MacOSX, Windows, Unknown }}
