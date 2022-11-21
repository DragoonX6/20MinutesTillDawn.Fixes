using HarmonyLib;
using Mono.Cecil.Cil;
using MonoMod.Cil;

using flanne.PerkSystem;

namespace _20MinutesTillDawn.Fixes;

public static class FixPowerupStacking
{
	[HarmonyPatch(typeof(PlayerPerks), nameof(PlayerPerks.Equip))]
	[HarmonyILManipulator]
	static void FixEquip(ILContext il)
	{
		ILCursor c = new(il);

		c.GotoNext(
			MoveType.Before,
			x => x.MatchLdfld(
				AccessTools.DeclaredField(
					typeof(PlayerPerks),
					"_equippedPerks")),
			x => x.Match(OpCodes.Ldloc_0));

		++c.Index;

		c.Remove();
		c.Emit(OpCodes.Ldarg_1);
	}
}
