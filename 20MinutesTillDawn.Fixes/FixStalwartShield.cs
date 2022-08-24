using HarmonyLib;

using flanne.PowerupSystem;

namespace _20MinutesTillDawn.Fixes
{
public static class FixStalwartShield
{
	[HarmonyPatch(typeof(PreventDamageCDRPowerup), "Apply")]
	[HarmonyPrefix]
	static void Apply(float ___additionalCDR)
	{
		___additionalCDR = 1f;
	}
}
}
