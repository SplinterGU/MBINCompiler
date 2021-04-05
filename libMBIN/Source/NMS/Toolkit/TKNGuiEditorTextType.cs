using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x0, NameHash = 0x4780AB6325CE84C6)]
    public class TKNGuiEditorTextType : NMSTemplate
    {
        // 0xE entries
        public enum NGuiEditorTextEnum {
            Text, Button, WindowTab, WindowTabInactive, TreeNode, CheckBox, TextInput, TextInputLabel, TextInputLabelHeader, Category,
            TaskBar, GroupTitle, TreeNodeSelected, DynamicPanelTitle
        };
        public NGuiEditorTextEnum NGuiEditorText;
    }
}