﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B3FD0C5AC8F65C2E)]
    public class GcWarpAction : NMSTemplate
    {
		public enum WarpTypeEnum { BlackHole }
		public WarpTypeEnum WarpType;
    }
}
