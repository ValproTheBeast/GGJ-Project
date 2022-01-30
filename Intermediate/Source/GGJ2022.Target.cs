using UnrealBuildTool;

public class GGJ2022Target : TargetRules
{
	public GGJ2022Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GGJ2022");
	}
}
