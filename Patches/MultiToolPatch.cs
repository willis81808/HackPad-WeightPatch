using PortableMultiTool.Items;

namespace HackPadWeightPatch.Patches;

[HarmonyPatch(typeof(MultiTool))]
internal class MultiToolPatch
{
    [HarmonyPrefix]
    [HarmonyPatch("Awake")]
    static void Awake_Patch(MultiTool __instance)
    {
        __instance.itemProperties.weight = 1;
    }
}
