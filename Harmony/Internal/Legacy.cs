﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib.Internal;
using HarmonyLib.Internal.Util;

// ReSharper disable once CheckNamespace
namespace HarmonyLib
{
    [Obsolete("Exists for legacy support", true)]
    internal static class HarmonySharedState
    {
        [Obsolete("Exists for legacy support", true)]
        public static PatchInfo GetPatchInfo(MethodBase method)
        {
            return method.ToPatchInfo();
        }

        [Obsolete("Exists for legacy support", true)]
        public static IEnumerable<MethodBase> GetPatchedMethods()
        {
            return GlobalPatchState.GetPatchedMethods();
        }

        [Obsolete("Exists for legacy support", true)]
        public static void UpdatePatchInfo()
        {
            // skip
        }
    }

    [Obsolete("Exists for legacy support", true)]
    internal static class PatchFunctions
    {
        [Obsolete("Exists for legacy support", true)]
        public static DynamicMethod UpdateWrapper(MethodBase original, PatchInfo info, string id)
        {
            original.GetILHook().MarkApply(true).Apply();
            return null;
        }
    }
}