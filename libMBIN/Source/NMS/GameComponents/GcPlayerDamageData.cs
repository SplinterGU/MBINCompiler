﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x130, GUID = 0x53406B443DE8066D)]
    public class GcPlayerDamageData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string DeathMessage;
        /* 0x030 */ public TkTextureResource HitIcon;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB4;
        [NMS(Size = 0x20)]
        /* 0x0B8 */ public string HitMessage;
        [NMS(Size = 0x20)]
        /* 0x0D8 */ public string CriticalHitMessage;
        /* 0x0F8 */ public float Damage;
        /* 0x0FC */ public float HardModeMultiplier;
        /* 0x100 */ public float PushForce;
        /* 0x104 */ public float CameraTurn;
        [NMS(Size = 0x10)]
        /* 0x108 */ public string CameraShakeShield;
        [NMS(Size = 0x10)]
        /* 0x118 */ public string CameraShakeNoShield;
        /* 0x128 */ public bool ShowTrackicon;
		public enum PlayerDamageTypeEnum { Normal, Toxic, Radioactive, Freeze, Scorch }
		public PlayerDamageTypeEnum PlayerDamageType;
    }
}
