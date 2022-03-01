using UnrealBuildTool;

public class UR_WeihnachtsgruppeTarget : TargetRules
{
	public UR_WeihnachtsgruppeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("UR_Weihnachtsgruppe");
	}
}
