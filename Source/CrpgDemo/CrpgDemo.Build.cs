// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CrpgDemo : ModuleRules
{
	public CrpgDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CrpgDemo",
			"CrpgDemo/Variant_Strategy",
			"CrpgDemo/Variant_Strategy/UI",
			"CrpgDemo/Variant_TwinStick",
			"CrpgDemo/Variant_TwinStick/AI",
			"CrpgDemo/Variant_TwinStick/Gameplay",
			"CrpgDemo/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
