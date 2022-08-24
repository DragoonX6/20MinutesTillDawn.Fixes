using BepInEx;
using HarmonyLib;

namespace _20MinutesTillDawn.Fixes
{
[BepInPlugin("20MinutesTillDawn.Fixes", "Fixes not yet in the game", "1.0.0.0")]
[BepInProcess("MinutesTillDawn.exe")]
public class Fixes: BaseUnityPlugin
{
	private Harmony instance = new Harmony("Fixes");

	public void Awake()
	{
		instance.PatchAll(typeof(FixElementStatPowerup));
		Logger.LogInfo("Fixing done");
	}
}
}
