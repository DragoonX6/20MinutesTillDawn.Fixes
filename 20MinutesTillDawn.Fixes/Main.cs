using BepInEx;
using HarmonyLib;

namespace _20MinutesTillDawn.Fixes
{
[BepInPlugin("20MinutesTillDawn.Fixes", "20MinutesTillDawn Fixes", "1.0.0.0")]
[BepInProcess("MinutesTillDawn.exe")]
public class Fixes: BaseUnityPlugin
{
	private Harmony instance = new Harmony("Fixes");

	public void Awake()
	{
		Logger.LogInfo("Fixing done");
	}
}
}
