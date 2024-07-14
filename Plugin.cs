using UnityEngine;
using BepInEx;
using PortableMultiTool;
using System.Reflection;
using BepInEx.Logging;

namespace HackPadWeightPatch;

[BepInDependency("com.willis.lc.portablehackpad")]
[BepInPlugin(GeneratedPluginInfo.Identifier, GeneratedPluginInfo.Name, GeneratedPluginInfo.Version)]
public class Plugin : BaseUnityPlugin
{
    internal static Plugin Instance { get; private set; }

    public new ManualLogSource Logger => base.Logger;

    public void Awake()
    {
        Instance = this;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), GeneratedPluginInfo.Identifier);
    }
}