﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x54D3FF1DCD34430F)]
    public class GcMissionSequenceWaitForSuitUpgrade : NMSTemplate        // size: 0x80
    {
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
