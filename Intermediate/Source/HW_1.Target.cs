using UnrealBuildTool;

public class HW_1Target : TargetRules
{
	public HW_1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HW_1");
	}
}
