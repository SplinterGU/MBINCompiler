using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x70905D32A9E74330, NameHash = 0x89317714328CB341)]
    public class TkInteractiveSceneData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Id;
        /* 0x20 */ public List<TkInteractiveControlData> Controls;
    }
}
