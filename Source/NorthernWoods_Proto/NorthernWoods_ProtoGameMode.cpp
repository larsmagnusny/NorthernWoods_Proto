// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "NorthernWoods_ProtoGameMode.h"
#include "NorthernWoods_ProtoCharacter.h"
#include "UObject/ConstructorHelpers.h"

ANorthernWoods_ProtoGameMode::ANorthernWoods_ProtoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
