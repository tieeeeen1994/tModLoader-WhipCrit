using System;
using MonoMod.RuntimeDetour;
using Terraria.ModLoader;

namespace WhipCrit
{
	public class WhipCritPatch
	{
		private static Hook _hook;

		public static void Apply()
		{
			// Hook into the Terraria.Player.Update method
			_hook = new Hook(
				typeof(SummonMeleeSpeedDamageClass).GetProperty("UseStandardCritCalcs").GetGetMethod(),
				typeof(WhipCritPatch).GetMethod("UseStandardCritCalcs_Getter")
			);
		}

        public static void Undo()
        {
            _hook?.Dispose();
            _hook = null;
        }

		public static bool UseStandardCritCalcs_Getter(Func<SummonMeleeSpeedDamageClass, bool> orig, SummonMeleeSpeedDamageClass self)
        {
            return true;
        }
	}
}
