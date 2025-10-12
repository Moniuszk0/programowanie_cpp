// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class programowanie : ModuleRules
{
	public programowanie(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"programowanie",
			"programowanie/Variant_Platforming",
			"programowanie/Variant_Platforming/Animation",
			"programowanie/Variant_Combat",
			"programowanie/Variant_Combat/AI",
			"programowanie/Variant_Combat/Animation",
			"programowanie/Variant_Combat/Gameplay",
			"programowanie/Variant_Combat/Interfaces",
			"programowanie/Variant_Combat/UI",
			"programowanie/Variant_SideScrolling",
			"programowanie/Variant_SideScrolling/AI",
			"programowanie/Variant_SideScrolling/Gameplay",
			"programowanie/Variant_SideScrolling/Interfaces",
			"programowanie/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
