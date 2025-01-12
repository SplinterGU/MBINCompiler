using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x790A4A578F2ABC82, NameHash = 0x9904F7D363A81377)]
    public class GcCharacterGlobals : NMSTemplate
    {
        /* 0x000 */ public float HoldWeaponAsPropXRotationDegrees;
        /* 0x008 */ public NMSString0x10 NPCStaffPropTag;
        /* 0x018 */ public float NPCScalingMaxRandomVariance;
        /* 0x01C */ public float PitchTest;
        /* 0x020 */ public float RollTest;
        /* 0x024 */ public float WaterEffectHeightOffset;
        /* 0x028 */ public float WaterEffectHeightRange;
        /* 0x02C */ public float WaterEffectFadeSpring;
        /* 0x030 */ public float WaterEffectSpeedFade;
        /* 0x034 */ public float WaterEffectSpeedFadeMin;
        /* 0x038 */ public float WaterEffectSpeedOffset;
        /* 0x03C */ public float WaterEffectMinScale;
        /* 0x040 */ public float WaterEffectSideOffset;
        /* 0x044 */ public float WaterEffectRearOffset;
        /* 0x048 */ public float WaterEffectRearBackOffset;
        /* 0x04C */ public float CharacterRotationOffsetY;
        /* 0x050 */ public float CharacterRoughHeadHeight;
        /* 0x054 */ public NMSString0x80 CharacterFile;
        /* 0x0D8 */ public GcSeed CharacterSeedOverride;
        /* 0x0E8 */ public float DontShowCharacterWithinCameraDistance;
        /* 0x0EC */ public float CharacterTurnSpeed;
        /* 0x0F0 */ public float CharacterRunTurnSpeed;
        /* 0x0F4 */ public float CharacterJetpackTurnSpeed;
        /* 0x0F8 */ public float CharacterJetpackTurnAimSpeed;
        /* 0x0FC */ public float CharacterTurnAimSpeed;
        /* 0x100 */ public float CharacterSwimmingTurnSpeed;
        /* 0x104 */ public float CharacterSwimmingTurnAimSpeed;
        /* 0x108 */ public float RocketBootsLandedTurnSpeed;
        /* 0x10C */ public float RocketBootsTurnSpeed;
        /* 0x110 */ public float FeetShiftOnTurnSpeed;
        /* 0x114 */ public float FeetShiftOnTurnMaxSpeed;
        /* 0x118 */ public float MinTurnAngle;
        /* 0x11C */ public float YawPullSpeed;
        /* 0x120 */ public float GunRotationSpeed;
        /* 0x124 */ public float AimPitchAnimScale;
        /* 0x128 */ public float AimYawAnimScale;
        /* 0x12C */ public float AimPitchInterpSpeed;
        /* 0x130 */ public float MinSwimmingPitchRotation;
        /* 0x134 */ public float MaxSwimmingPitchRotation;
        /* 0x138 */ public float JetpackSwimmingPitchRotation;
        /* 0x13C */ public float MinSwimmingRollRotation;
        /* 0x140 */ public float MaxSwimmingRollRotation;
        /* 0x144 */ public float SwimmingSmoothTime;
        /* 0x148 */ public float SwimmingSmoothTimeWithWeapon;
        /* 0x14C */ public float SwimmingRollSmoothTime;
        /* 0x150 */ public float SwimmingRollSmoothTimeWithWeapon;
        /* 0x154 */ public float LadderDistanceToAutoMount;
        /* 0x158 */ public float LadderCooldownAfterBeforeAutoClimb;
        /* 0x160 */ public NMSString0x10 LadderClimbIdle;
        /* 0x170 */ public NMSString0x10 LadderClimbUp;
        /* 0x180 */ public NMSString0x10 LadderClimbDown;
        /* 0x190 */ public NMSString0x10 LadderMountBottom;
        /* 0x1A0 */ public NMSString0x10 LadderDismountBottom;
        /* 0x1B0 */ public NMSString0x10 LadderMountTop;
        /* 0x1C0 */ public NMSString0x10 LadderDismountTop;
        /* 0x1D0 */ public float SlopeAngleForUphillClimb;
        /* 0x1D4 */ public float SlopeAngleForDownhillClimb;
        /* 0x1D8 */ public float SlidingBrake;
        /* 0x1DC */ public float SlopeAngleForSlide;
        /* 0x1E0 */ public float UphillSpeedMultiplier;
        /* 0x1E4 */ public float TrudgeUphillSpeed;
        /* 0x1E8 */ public float MaxAnkleRotationAngle;
        /* 0x1EC */ public float RotateToFaceSlopeSpeed;
        /* 0x1F0 */ public float TimeNotOnGroundToBeConsideredInAir;
        /* 0x1F4 */ public float TimeNotOnGroundToUseFallingCamera;
        /* 0x1F8 */ public float TimeFallingUntilPanic;
        /* 0x1FC */ public float BankingMinimumSpeed;
        /* 0x200 */ public float BankingMaxStrength;
        /* 0x204 */ public float BankingSpeedForMaxStrength;
        /* 0x208 */ public float MinimumIdleToJogAnimSpeed;
        /* 0x20C */ public float RootedAnimInterpolationTime;
        /* 0x210 */ public float IKLegStretchStrength;
        /* 0x214 */ public float IkBlendStrengthSpeed;
        /* 0x218 */ public float FootPlantedTolerance;
        /* 0x21C */ public float FootPlantSpring;
        /* 0x220 */ public float BlendToNewFeetSpeed;
        /* 0x224 */ public float TimeAfterDeathRagdollIsEnabledForward;
        /* 0x228 */ public float TimeAfterDeathRagdollIsEnabledBackward;
        /* 0x22C */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
        /* 0x230 */ public float RagdollTau;
        /* 0x234 */ public float RagdollDamping;
        /* 0x238 */ public float RagdollConeLimit;
        /* 0x23C */ public float RagdollTwistLimit;
        /* 0x240 */ public float RagdollMotorFadeStart;
        /* 0x244 */ public float RagdollMotorFadeEnd;
        /* 0x248 */ public float MinStickForIntoJogAnim;
        /* 0x24C */ public float SmoothVelocitySpeed;
        /* 0x250 */ public float TimeToShowSplashEffect;
        /* 0x254 */ public float UnderwaterToAirTolerance;
        /* 0x258 */ public float WaterBottomSmoothPushUp;
        /* 0x25C */ public float WaterBottomSmoothPushUpDepth;
        /* 0x260 */ public float SitPostureChangeTimeMin;
        /* 0x264 */ public float SitPostureChangeTimeMax;
        /* 0x268 */ public bool NPCUseBehaviourTree;
        /* 0x269 */ public bool NPCLightsAlwaysOn;
        /* 0x26C */ public GcNPCPropType NPCForceProp;
        /* 0x270 */ public float NPCPropScaleTime;
        /* 0x274 */ public float NPCReactionChance;
        /* 0x278 */ public float NPCReactCooldown;
        /* 0x27C */ public float NPCIKBodyWeightNormalGek;
        /* 0x280 */ public float NPCIKBodyWeightNormal;
        /* 0x284 */ public float NPCIKBodyWeightSeated;
        /* 0x288 */ public float NPCSpineAdjustGek;
        /* 0x28C */ public float NPCSpineAdjustVykeen;
        /* 0x290 */ public float NPCAnimSpeedMin;
        /* 0x294 */ public float NPCAnimSpeedMax;
        /* 0x298 */ public float NPCBehaviourTimeModifier;
        /* 0x29C */ public bool NPCBehaviourInfo;
        /* 0x2A0 */ public float NPCStaticDistance;
        /* 0x2A4 */ public float NPCStaticTimeUntilFail;
        /* 0x2A8 */ public float NPCPermittedNavigationDelayFactor;
        /* 0x2AC */ public int NPCNumNavFailuresUntilNoPhysFallback;
        /* 0x2B0 */ public float NPCWalkSpeedMech;
        /* 0x2B4 */ public float NPCWalkSpeed;
        /* 0x2B8 */ public float NPCWalkSpeedGek;
        /* 0x2BC */ public float NPCRunSpeed;
        /* 0x2C0 */ public float NPCRunSpeedGek;
        /* 0x2C4 */ public float NPCArriveDist;
        /* 0x2C8 */ public float NPCIncreasedSteeringDist;
        /* 0x2CC */ public float NPCMinTurnSpeed;
        /* 0x2D0 */ public float NPCMaxTurnSpeed;
        /* 0x2D4 */ public float NPCMinTurnSpeedMech;
        /* 0x2D8 */ public float NPCDecelerateStrength;
        /* 0x2DC */ public float NPCStaticTurnTime;
        /* 0x2E0 */ public float NPCTeleportEffectTime;
        /* 0x2E4 */ public float NPCCamoWipeEffectTime;
        /* 0x2E8 */ public float NPCCamoScanRevealTime;
        /* 0x2EC */ public float NPCMinStaticTurnAngle;
        /* 0x2F0 */ public float NPCFastStaticTurnAngle;
        /* 0x2F4 */ public float NPCSlowStaticTurnAngle;
        /* 0x2F8 */ public float NPCMaxStaticTurnSpeed;
        /* 0x2FC */ public float NPCActiveListenChance;
        /* 0x300 */ public float NPCLookAtThingChance;
        /* 0x304 */ public float NPCLookAtThingTimeMin;
        /* 0x308 */ public float NPCLookAtThingTimeMax;
        /* 0x30C */ public float NPCLookAwayTimeMin;
        /* 0x310 */ public float NPCLookAwayTimeMax;
        /* 0x314 */ public float NPCMaxLookAtAngleMoving;
        /* 0x318 */ public float NPCMaxLookAtAngleStatic;
        /* 0x31C */ public float NPCLookAtTerminateAngle;
        /* 0x320 */ public float NPCSeatedLookAtLateralReduction;
        /* 0x324 */ public float NPCMinInteractionSearchDist;
        /* 0x328 */ public float NPCMaxInteractionSearchDist;
        /* 0x32C */ public float NPCMaxFreighterInteractionSearchDist;
        /* 0x330 */ public float NPCMaxSettlementInteractionSearchDist;
        /* 0x334 */ public float NPCSteeringSpringTime;
        /* 0x338 */ public float NPCPerceptionRadius;
        /* 0x33C */ public float NPCSteeringObstacleAvoidStrength;
        /* 0x340 */ public float NPCSteeringFollowStrength;
        /* 0x344 */ public float NPCSteeringAvoidStrength;
        /* 0x348 */ public float NPCSteeringRadius;
        /* 0x34C */ public float NPCSteeringRepelDist;
        /* 0x350 */ public float NPCSteeringComingTowardsDegrees;
        /* 0x354 */ public float NPCSteeringCollisionAvoidAngle;
        /* 0x358 */ public float NPCSteeringCollisionAvoidStrength;
        /* 0x35C */ public float NPCSteeringRaySpread;
        /* 0x360 */ public float NPCSteeringRayLength;
        /* 0x364 */ public float NPCSteeringRaySphereSize;
        /* 0x368 */ public float NPCMaxRandomNavPathMinIndoorOffset;
        /* 0x36C */ public float NPCMaxRandomNavPathMaxIndoorOffset;
        /* 0x370 */ public float NPCMaxRandomNavPathMinOutdoorOffset;
        /* 0x374 */ public float NPCMaxRandomNavPathMaxOutdoorOffset;
        /* 0x378 */ public float NPCBlockedDestRadius;
        /* 0x37C */ public float NPCFlavourIdleTimeMin;
        /* 0x380 */ public float NPCFlavourIdleTimeMax;
        /* 0x384 */ public float NPCMoodIdleDelayChance;
        /* 0x388 */ public float NPCMoodIdleLowIntensityChance;
        /* 0x38C */ public float NPCReactToPlayerPresenceDist;
        /* 0x390 */ public float NPCReactToPlayerPresenceIndividualCooldown;
        /* 0x394 */ public float NPCReactToPlayerPresenceGloablCooldown;
        /* 0x398 */ public float NPCReactToPlayerPresenceStaticTimer;
        /* 0x39C */ public float NPCDisplayThoughtsMaxDuration;
        /* 0x3A0 */ public float NPCDisplayThoughtsMaxDistance;
        /* 0x3A4 */ public float NPCDisplayThoughtsRefreshInterval;
        /* 0x3A8 */ public float NPCDisplayThoughtsProbability;
        /* 0x3AC */ public float NPCPOISelectionNearbyNPCBaseMultiplier;
        /* 0x3B0 */ public float NPCHackMoveUpToStopFallingThoughFloor;
    }
}
