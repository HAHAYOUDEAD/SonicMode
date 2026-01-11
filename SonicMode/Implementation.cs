using MelonLoader;

namespace SonicMode;

internal sealed partial class Implementation : MelonMod
{
	public override void OnInitializeMelon()
	{
		Settings.Instance.AddToModSettings("Sonic Mode");
	}
}