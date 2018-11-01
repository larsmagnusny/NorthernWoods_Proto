// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class NorthernWoods_ProtoEditorTarget : TargetRules
{
	public NorthernWoods_ProtoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("NorthernWoods_Proto");
	}
}
