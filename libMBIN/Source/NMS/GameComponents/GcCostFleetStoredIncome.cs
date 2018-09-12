﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x41905CFD44818266)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        public GcFrigateClass Class;
        public int RequiredAmount;
    }
}
