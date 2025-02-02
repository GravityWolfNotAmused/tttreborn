using System;

using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TTTReborn.UI
{
    public partial class DropdownOption : Panel
    {
        public readonly Dropdown Dropdown;

        public readonly TranslationLabel TextLabel;

        public object Data { get; set; }

        public Action<Panel> OnSelect { get; set; }

        public DropdownOption(Dropdown dropdown, Sandbox.UI.Panel parent = null, string text = "", object data = null, params object[] translationData) : base(parent)
        {
            Dropdown = dropdown;
            TextLabel = Add.TryTranslationLabel(text, "optiontext", translationData);
            Data = data;
        }

        protected override void OnClick(MousePanelEvent e)
        {
            OnSelect?.Invoke(this);
            Dropdown.OnSelectDropdownOption(this);
        }
    }
}
