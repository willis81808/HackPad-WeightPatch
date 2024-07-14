namespace PortableMultiTool.Patches;

[HarmonyPatch(typeof(Items.MultiTool))]
internal class MultiToolPatch
{
    [HarmonyPrefix]
    [HarmonyPatch("Awake")]
    static void Awake_Patch(Items.MultiTool __instance)
    {
        __instance.itemProperties.weight = 1;
    }
}
