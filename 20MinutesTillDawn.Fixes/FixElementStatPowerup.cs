using System;

using HarmonyLib;

using UnityEngine;

using flanne.PowerupSystem;

namespace _20MinutesTillDawn.Fixes
{
// Fix the Tome of Elements no decreasing damage.
public static class FixElementStatPowerup
{
	static bool applied = false;
	static Action<StatPowerup, GameObject> baseMethod;

	[HarmonyPatch(typeof(ElementStatPowerup), "Apply")]
	[HarmonyPrefix]
	static void Apply(ElementStatPowerup __instance, GameObject target)
	{
		if(!applied)
		{
			baseMethod =
				AccessTools.MethodDelegate<Action<StatPowerup, GameObject>>(
					AccessTools.DeclaredMethod(typeof(StatPowerup), "Apply"), null, false);

			applied = true;
		}

		baseMethod(__instance, target);
	}
}
}
