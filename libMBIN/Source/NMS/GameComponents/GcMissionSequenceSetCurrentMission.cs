﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x0F4F36BE36E16AFF7)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string MissionID;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
    }
}
