using HarmonyLib;
using Verse;

namespace RemoveColoniesLimit
{
    public class RemoveColoniesLimitMod : Mod
    {
        public RemoveColoniesLimitMod(ModContentPack pack) : base(pack)
        {
            new Harmony("RemoveColoniesLimitMod").PatchAll();
        }
    }
}