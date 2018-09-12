﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C23149018DEB60)]
    public class GcRewardSecondarySubstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        public float Amountfactor;
        public bool RewardAsBlobs;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
