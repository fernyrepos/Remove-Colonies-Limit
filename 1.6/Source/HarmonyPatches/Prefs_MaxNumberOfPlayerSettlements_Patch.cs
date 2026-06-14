using HarmonyLib;
using Verse;

namespace RemoveColoniesLimit
{
    [HarmonyPatch(typeof(Prefs), nameof(Prefs.MaxNumberOfPlayerSettlements), MethodType.Getter)]
    public class Prefs_MaxNumberOfPlayerSettlements_Patch
    {
        static void Postfix(ref int __result)
        {
            __result = 999;
        }
    }
}
