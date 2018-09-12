﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0A5C891B043A1F0F3)]
    public class GcTeleporterType : NMSTemplate
    {
		public enum TeleporterDestinationTypeEnum { Base, Spacestation, Atlas, PlanetAwayFromShip, ExternalBase, EmergencyGalaxyFix }
		public TeleporterDestinationTypeEnum TeleporterDestinationType;
    }
}
