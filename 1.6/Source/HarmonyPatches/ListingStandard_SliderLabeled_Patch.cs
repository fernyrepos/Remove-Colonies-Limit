using HarmonyLib;
using Verse;

namespace RemoveColoniesLimit
{
    [HarmonyPatch(typeof(Listing_Standard), nameof(Listing_Standard.SliderLabeled))]
    public class ListingStandard_SliderLabeled_Patch
    {
        private static readonly string SettlementsSliderPrefix = "MaxNumberOfPlayerSettlements".Translate();
        private static readonly string SettlementsSliderMatch = SettlementsSliderPrefix.Substring(0, SettlementsSliderPrefix.Length - 3);

        static bool Prefix(string label, ref float __result)
        {
            if (label.StartsWith(SettlementsSliderMatch))
            {
                __result = 999f;
                return false;
            }
            return true;
        }
    }
}
