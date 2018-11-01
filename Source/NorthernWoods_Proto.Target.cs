// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class NorthernWoods_ProtoTarget : TargetRules
{
	public NorthernWoods_ProtoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("NorthernWoods_Proto");
	}
}
