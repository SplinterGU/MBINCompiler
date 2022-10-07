using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8785035A0CB4CE75, NameHash = 0x9B5DDD6D76FBC918)]
    public class GcVehicleGlobals : NMSTemplate
    {
        /* 0x000 */ public float UnderwaterScannerIconRangeBoost;
        /* 0x004 */ public float VehicleSolarRegenFactor;
        /* 0x008 */ public NMSString0x10 VehicleStrongLaser;
        /* 0x018 */ public NMSString0x10 MechStrongLaser;
        /* 0x028 */ public NMSString0x10 SentinelRightArmTech;
        /* 0x038 */ public NMSString0x10 SentinelLeftArmTech;
        /* 0x048 */ public NMSString0x20A SentinelRightArmTechNameOverride;
        /* 0x068 */ public NMSString0x10 SentinelRightLeftArmLaserData;
        /* 0x078 */ public bool UseFirstPersonCamera;
        /* 0x07C */ public float LevelVehicleCameraFactor;
        /* 0x080 */ public bool ShowAllCheckpoints;
        /* 0x084 */ public float ControlStickRecenterSpeedDegPerSec;
        /* 0x088 */ public float SteeringWheelPushRange;
        /* 0x08C */ public float SteeringWheelPitchAngle;
        /* 0x090 */ public float SteeringWheelSpringBothHands;
        /* 0x094 */ public float SteeringWheelSpringOneHand;
        /* 0x098 */ public float SteeringWheelCentreOffset;
        /* 0x09C */ public TkCurveType SteeringWheelOutputCurve;
        /* 0x0A0 */ public float RemoteBoostingEffectTimeout;
        /* 0x0A4 */ public float TestFrictionStat;
        /* 0x0A8 */ public float TestSkidFrictionStat;
        /* 0x0AC */ public bool TestAnims;
        /* 0x0B0 */ public float TestAnimThrust;
        /* 0x0B4 */ public float TestAnimBoost;
        /* 0x0B8 */ public float TestAnimTurn;
        /* 0x0BC */ public float VisualTurnUnderwaterSpring;
        /* 0x0C0 */ public float VisualTurnSpring;
        /* 0x0D0 */ public Colour DefaultBoosterColour;
        /* 0x0E0 */ public float WheelDustColourLightFactor;
        /* 0x0E4 */ public Vector2f MechMovementStickSpeedLimit;
        /* 0x0EC */ public Vector2f MechLookStickSpeedLimit;
        /* 0x0F4 */ public int DamageTechNumHitsRequired;
        /* 0x0F8 */ public float DamageTechMinHitIntervalSeconds;
        /* 0x0FC */ public float MechAIResummonTriggerDistance;
        /* 0x100 */ public float MechAIResummonMinSpawnDistance;
        /* 0x104 */ public float MechAIResummonMinSpeedForVelBasedSpawnPos;
        /* 0x108 */ public float MechAIResummonVelBasedSpawnSpeedMultiplier;
        /* 0x10C */ public bool MechStrafeEnabled;
        /* 0x10D */ public bool MechAltJumpMode;
        /* 0x110 */ public float MechContrailAlpha;
        /* 0x114 */ public float MechJetpackJetScaleTime;
        /* 0x118 */ public NMSString0x10 MechLandingImpactEffect;
        /* 0x128 */ public NMSString0x10 MechJetpackEffect;
        /* 0x138 */ public NMSString0x10 MechJetpackLaunchEffect;
        /* 0x148 */ public NMSString0x10 MechJetpackLaunchGroundEffect;
        /* 0x158 */ public float MechPlayerGroundTurnSpeed;
        /* 0x15C */ public float MechAIGroundTurnSpeed;
        /* 0x160 */ public float MechJetpackTurnSpeed;
        /* 0x164 */ public float MechArmPitchAngleMin;
        /* 0x168 */ public float MechArmPitchAngleMax;
        /* 0x16C */ public float MechArmPitchLerpSpeed;
        /* 0x170 */ public NMSString0x10 MechArmPitchAnimLeft;
        /* 0x180 */ public NMSString0x10 MechArmPitchAnimRight;
        /* 0x190 */ public float MechMaxTurnAngleWhileStationary;
        /* 0x194 */ public float MechTurretTurnTimeGround;
        /* 0x198 */ public float MechTurretMaxAngleGround;
        /* 0x19C */ public float MechTurretTurnTimeGroundPlayerCombat;
        /* 0x1A0 */ public float MechTurretTurnTimeAir;
        /* 0x1A4 */ public float MechTurretMaxAngleAir;
        /* 0x1A8 */ public float MechTurretTimeVRModifier;
        /* 0x1B0 */ public Vector3f MechCrouchOffset;
        /* 0x1C0 */ public Vector3f MechWalkBackwardsCoGOffset;
        /* 0x1D0 */ public float MechCoGAdjustTimeWindUp;
        /* 0x1D4 */ public float MechCoGAdjustTimeAir;
        /* 0x1D8 */ public float MechCoGAdjustTimeLand;
        /* 0x1DC */ public float MechCrouchTime;
        /* 0x1E0 */ public float MechWalkToRunTimeIdle;
        /* 0x1E4 */ public float MechWalkToRunTimeSkid;
        /* 0x1E8 */ public float MechArmSwingAngleWalk;
        /* 0x1EC */ public float MechArmSwingPhaseWalk;
        /* 0x1F0 */ public TkCurveType MechArmSwingCurveWalk;
        /* 0x1F4 */ public float MechArmSwingAngleFastWalk;
        /* 0x1F8 */ public float MechArmSwingPhaseFastWalk;
        /* 0x1FC */ public TkCurveType MechArmSwingCurveFastWalk;
        /* 0x200 */ public float MechLandBrake;
        /* 0x204 */ public float MechJetpackStrafeStrength;
        /* 0x208 */ public float MechJetpackLandTime;
        /* 0x20C */ public float MechJetpackForce;
        /* 0x210 */ public float MechJetpackBrake;
        /* 0x214 */ public float MechJetpackMaxSpeed;
        /* 0x218 */ public float MechJetpackMaxUpSpeed;
        /* 0x21C */ public float MechJetpackUpForce;
        /* 0x220 */ public float MechJetpackAvoidGroundForce;
        /* 0x224 */ public float MechJetpackFallForce;
        /* 0x228 */ public float MechJetpackAvoidGroundProbeLength;
        /* 0x22C */ public float MechJetpackIgnitionForce;
        /* 0x230 */ public float MechJetpackIgnitionTime;
        /* 0x234 */ public float MechJetpackMaxCoGAdjustX;
        /* 0x238 */ public float MechCameraOffsetTime;
        /* 0x23C */ public float MechCameraOffsetAmount;
        /* 0x240 */ public float MechJetpackDrainRate;
        /* 0x244 */ public float MechJetpackFillRate;
        /* 0x248 */ public float MechDefaultBlendTime;
        /* 0x24C */ public float MechSpeedBlendTime;
        /* 0x250 */ public float MechLandBlendTime;
        /* 0x254 */ public float MechJumpBlendTime;
        /* 0x258 */ public float MechJumpFlyBlendTime;
        /* 0x25C */ public float MechJumpDownBlendTime;
        /* 0x260 */ public float MechIdleLowBlendTime;
        /* 0x264 */ public float MechIdleLowDelay;
        /* 0x268 */ public float MechIdleStopDelay;
        /* 0x26C */ public float MechFirstPersonTurretTurnModerator;
        /* 0x270 */ public float MechFirstPersonTurretPitchModerator;
        /* 0x274 */ public bool MechFirstPersonTurretTweaksEnabled;
        /* 0x278 */ public float MechFirstPersonTurretShootTimer;
        /* 0x27C */ public float MechFirstPersonTurretBaseThrottleThreshold;
        /* 0x280 */ public float MechFirstPersonIgnoreReverseThreshold;
        /* 0x284 */ public float MechFirstPersonTurretThrottleLookThreshold;
        /* 0x288 */ public float MechFirstPersonTurretBaseTurnThreshold;
        /* 0x28C */ public float MechFirstPersonTurretAngleThrottleThreshold;
        /* 0x290 */ public float MechFirstPersonTurretAngleThrottleStrength;
        /* 0x294 */ public float MechFirstPersonDamping;
        /* 0x298 */ public float MechFirstPersonStickXModerator;
        /* 0x29C */ public float MechFirstPersonMaxTurnTurret;
        /* 0x2A0 */ public float MechFirstPersonMaxLookTurret;
        /* 0x2A4 */ public float MechFirstPersonCrouchAmount;
        /* 0x2A8 */ public float MechPowerUpTime;
        /* 0x2AC */ public float MechCockPitBobX;
        /* 0x2B0 */ public float MechCockPitBobY;
        /* 0x2B4 */ public float MechCockPitBobPitch;
        /* 0x2B8 */ public float MechCockPitBobRoll;
        /* 0x2BC */ public float MechCockPitBobYaw;
        /* 0x2C0 */ public float MechCockPowerDownY;
        /* 0x2C4 */ public float MechTitanFallHeight;
        /* 0x2C8 */ public bool MechTitanFallTerrainEditEnabled;
        /* 0x2CC */ public float MechTitanFallTerrainEditSize;
        /* 0x2D0 */ public float MechTitanFallTerrainEditOffset;
        /* 0x2D4 */ public float MechTitanFallLandIdleTime;
        /* 0x2D8 */ public float MechTitanFallLandIntroTime;
        /* 0x2DC */ public float MechTitanFallCameraShakeDist;
        /* 0x2E0 */ public float MechLandCameraShakeDist;
        /* 0x2E4 */ public float MechFootprintFadeTime;
        /* 0x2E8 */ public float MechFootprintFadeDist;
        /* 0x2F0 */ public GcMechAudioEventTable MechAudioEventTable;
        /* 0x410 */ public float AIMechLaserFireDurationMin;
        /* 0x414 */ public float AIMechLaserFireDurationMax;
        /* 0x418 */ public NMSString0x10 AIMechGunProjectile;
        /* 0x428 */ public float AIMechGunFireInterval;
        /* 0x42C */ public int AIMechGunNumShotsMin;
        /* 0x430 */ public int AIMechGunNumShotsMax;
        /* 0x434 */ public float AIMechGunExplosionRadius;
        /* 0x438 */ public float AIMechGunInheritVelocity;
        /* 0x43C */ public float MechWeaponInterpSpeed;
        // size: 0x4
        public enum MechWeaponLocatorNamesEnum {
            TurretExocraft,
            TurretSentinel,
            ArmLeft,
            ArmRight
        }
        [NMS(Size = 0x4, EnumType = typeof(MechWeaponLocatorNamesEnum))]
        /* 0x440 */ public NMSString0x20[] MechWeaponLocatorNames;
        // size: 0x4
        public enum MechWeaponDataEnum {
            Laser,
            Gun,
            TerrainEdit,
            StunGun
        }
        [NMS(Size = 0x4, EnumType = typeof(MechWeaponDataEnum))]
        /* 0x4C0 */ public GcExoMechWeaponData[] MechWeaponData;
        /* 0x6A0 */ public GcMechMeshPartTable MechMeshPartsTable;
        /* 0x880 */ public float WeaponInterpSpeed;
        /* 0x884 */ public float SubmarineMinSummonDepth;
        /* 0x888 */ public float SubmarineEjectRadius;
        /* 0x88C */ public float SubmarineEjectDownOffset;
        /* 0x890 */ public float SubmarineFirstPersonSteeringSensitivity;
        /* 0x894 */ public float FirstPersonSteeringAdditionalForward;
        /* 0x898 */ public float FirstPersonSteeringAdditionalForwardThreshold;
        /* 0x89C */ public float FirstPersonSteeringAdditionalReverseThreshold;
        /* 0x8A0 */ public float FirstPersonSteeringMinThrottleHardLeftRight;
        /* 0x8A4 */ public float FirstPersonSteeringLowSpeedTurnDamping;
        /* 0x8B0 */ public Vector3f FirstPersonNonVRCameraOffset;
        /* 0x8C0 */ public Vector3f FirstPersonNonVRCameraOffsetMech;
        /* 0x8D0 */ public float UnderwaterBuoyancySurfaceOffset;
        /* 0x8D4 */ public float UnderwaterBuoyancyRange;
        /* 0x8D8 */ public float UnderwaterSummonSurfaceOffset;
        /* 0x8DC */ public float UnderwaterSurfaceTension;
        /* 0x8E0 */ public float UnderwaterSurfaceOffset;
        /* 0x8E4 */ public float UnderwaterSurfaceGravity;
        /* 0x8E8 */ public float UnderwaterFlattenMinDepth;
        /* 0x8EC */ public float UnderwaterFlattenRange;
        /* 0x8F0 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        /* 0x8F4 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        /* 0x8F8 */ public float UnderwaterSurfaceSplashdownForce;
        /* 0x8FC */ public float UnderwaterSurfaceSplashdownMinSpeed;
        /* 0x900 */ public float UnderwaterJumpForce;
        /* 0x904 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        /* 0x928 */ public List<Vector3f> UnderwaterBubbleOffset;
        /* 0x938 */ public float HeadlightIntensitySpringTime;
        /* 0x93C */ public bool VehicleAltControlScheme;
        /* 0x940 */ public float VehicleAltControlStickSmoothInTime;
        /* 0x944 */ public float VehicleAltControlStickSmoothOutTime;
        /* 0x948 */ public float VehicleBoostSpeedMultiplierPercent;
        /* 0x94C */ public float VehicleGarageHologramMinFadeRange;
        /* 0x950 */ public float VehicleGarageHologramFadeRange;
        /* 0x954 */ public float CheckpointPlacementOffset;
        /* 0x958 */ public float CheckpointPlacementRayLength;
        /* 0x95C */ public float CheckpointDeleteDistance;
        /* 0x960 */ public float CheckpointDeleteAngle;
        /* 0x964 */ public float BoostPadTime;
        /* 0x968 */ public float BoostPadStrength;
        /* 0x96C */ public float DisablePhysicsRange;
        /* 0x970 */ public float RaceMultipleStartOffset;
        /* 0x974 */ public float RaceMultipleStartCaptureRange;
        /* 0x978 */ public float MiningLaserDrainSpeed;
        /* 0x97C */ public float ProjectileDrainPerShot;
        /* 0x980 */ public float RaceStartSpawnUpOffset;
        /* 0x984 */ public float RaceInteractRespawnOffset;
        /* 0x988 */ public float RaceInteractRespawnUpOffset;
        /* 0x98C */ public float StickTurnReducer;
        /* 0x990 */ public float StickTurnReducerVR;
        /* 0x994 */ public float StickTurnReducerAlt;
        /* 0x998 */ public float TravelSpeedReportReducer;
        /* 0x99C */ public float HornScareRadius;
        /* 0x9A0 */ public float HornScareFleeRadius;
        /* 0x9A4 */ public float HornScareTime;
        /* 0x9A8 */ public float AttractAmount;
        /* 0x9AC */ public float AttractMaxSpeed;
        /* 0x9B0 */ public float AttractAlign;
        /* 0x9B4 */ public float AttractDirectionBrakeThresholdSq;
        /* 0x9B8 */ public float ExitStopTime;
        /* 0x9BC */ public float ExitStopForce;
        /* 0x9C0 */ public float GunFireRate;
        /* 0x9C4 */ public float SummoningRange;
        /* 0x9C8 */ public float CheckpointRadius;
        /* 0x9CC */ public float RaceCooldown;
        /* 0x9D0 */ public bool RaceFinishAtStart;
        /* 0x9D4 */ public float RaceResetFlashDuration;
        /* 0x9D8 */ public float RaceResetFlashIntensity;
        /* 0x9DC */ public float CheckpointFlashDuration;
        /* 0x9E0 */ public float CheckpointFlashIntensity;
        /* 0x9F0 */ public Colour CheckpointBeamColourActive;
        /* 0xA00 */ public Colour CheckpointBeamColourNormal;
        /* 0xA10 */ public List<NMSString0x10> DefaultBuggyLoadout;
        /* 0xA20 */ public List<NMSString0x10> DefaultBikeLoadout;
        /* 0xA30 */ public List<NMSString0x10> DefaultTruckLoadout;
        /* 0xA40 */ public float CheckpointBeamSizeNormal;
        /* 0xA44 */ public float CheckpointBeamSizeActive;
        /* 0xA48 */ public float CheckpointBeamOffset;
        /* 0xA4C */ public float SpawnRotation;
        /* 0xA50 */ public float MechSpawnRotation;
        /* 0xA54 */ public float MiningLaserRadius;
        /* 0xA58 */ public int MiningLaserMiningDamage;
        /* 0xA5C */ public int MiningLaserDamage;
        /* 0xA60 */ public float MiningLaserSpeed;
        /* 0xA64 */ public int GunBaseDamage;
        /* 0xA68 */ public int StunGunBaseDamage;
        /* 0xA6C */ public float StunGunFireRate;
        /* 0xA70 */ public int GunBaseMiningDamage;
        /* 0xA74 */ public float ResourceCollectOffset;
        /* 0xA78 */ public float VehicleWheelNoise;
        /* 0xA7C */ public float VehicleWheelNoiseScale;
        /* 0xA80 */ public float WheelSideVerticalFactor;
        /* 0xA84 */ public float SuspensionDamping;
        /* 0xA88 */ public float SuspensionDampingAngularFactor;
        /* 0xA8C */ public bool ShowTempVehicleMesh;
        /* 0xA8D */ public bool ShowVehicleDebugging;
        /* 0xA8E */ public bool ShowVehicleWheelGuards;
        /* 0xA8F */ public bool ShowVehicleText;
        /* 0xA90 */ public float VehicleTextSize;
        /* 0xA94 */ public bool ShowVehicleParticleDebug;
        /* 0xA95 */ public bool VehicleDrawAudioDebug;
        /* 0xA98 */ public float VehicleSuspensionAudioSpacing;
        /* 0xA9C */ public float VehicleSuspensionAudioDelay;
        /* 0xAA0 */ public float VehicleSuspensionAudioScale;
        /* 0xAA4 */ public float VehicleSuspensionAudioTrigger;
        /* 0xAA8 */ public float VehicleFadeTime;
        /* 0xAAC */ public float VehicleMinSummonDistance;
        /* 0xAB0 */ public float VehicleMaxSummonDistance;
        /* 0xAB4 */ public float VehicleMaxSummonDistanceUnderwater;
        /* 0xAB8 */ public float VehicleDeactivateRange;
        /* 0xABC */ public float VehicleBoostFuelRate;
        /* 0xAC0 */ public float VehicleBoostFuelRateSurvival;
        /* 0xAC4 */ public float VehicleFuelRate;
        /* 0xAC8 */ public float VehicleFuelRateTruckMultiplier;
        /* 0xACC */ public float VehicleJumpTimeMin;
        /* 0xAD0 */ public float VehicleJumpTimeMax;
        /* 0xAD4 */ public float VehicleJumpCooldown;
        /* 0xAD8 */ public float VehicleMotionDeadZone;
        /* 0xADC */ public float WheelForceHalflife;
        /* 0xAE0 */ public bool ThrottleButtonCamRelative;
        /* 0xAE4 */ public float StickReverseTurnThreshold;
        /* 0xAE8 */ public float StickReverseTurnStiffness;
        /* 0xAEC */ public GcScanData VehicleScan;
        /* 0xB00 */ public GcScanData VehicleLocalScan;
        // size: 0x7
        public enum VehicleWeaponMuzzleFlashEnum {
            Buggy,
            Bike,
            Truck,
            WheeledBike,
            Hovercraft,
            Submarine,
            Mech
        }
        [NMS(Size = 0x7, EnumType = typeof(VehicleWeaponMuzzleFlashEnum))]
        /* 0xB18 */ public GcVehicleMuzzleData[] VehicleWeaponMuzzleFlash;
        /* 0xCD8 */ public List<GcVehicleWeaponMuzzleData> VehicleWeaponMuzzleDataTable;
        /* 0xCE8 */ public List<GcVehicleData> VehicleDataTable;
    }
}
