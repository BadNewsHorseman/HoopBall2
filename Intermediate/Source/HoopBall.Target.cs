using UnrealBuildTool;

public class HoopBallTarget : TargetRules
{
	public HoopBallTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("HoopBall");
	}
}
