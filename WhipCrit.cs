using MonoMod.RuntimeDetour;
using Terraria.ModLoader;

namespace WhipCrit
{
	public class WhipCrit : Mod
	{
        public override void Load()
        {
			WhipCritPatch.Apply();
        }

        public override void Unload()
        {
			WhipCritPatch.Undo();
        }
    }
}
