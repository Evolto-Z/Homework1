using UnrealBuildTool;
using System.Collections.Generic;

public class NetshootServerTarget : TargetRules
{
    public NetshootServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("Netshoot");
    }
}