// Type: SpicIE.Controls.ToolbarButton
// Assembly: SpicIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7066b1a7ed5618f
// Assembly location: C:\Documents and Settings\chaaa\My Documents\Projects\IEPageRefresherForRegressionResult\Libraries\SpicIE.dll

using SpicIE.Common;
using System;
using System.Runtime.InteropServices;

namespace SpicIE.Controls
{
    public abstract class ToolbarButton : IControlBase, IOleCommandTarget
    {
        #region Delegates

        public delegate void OLECommand(int value);

        #endregion

        #region ButtonAppearanceEnum enum

        public enum ButtonAppearanceEnum
        {
            COMObject = 1,
            Executables = 2,
        }

        #endregion

        #region ButtonCustomEnum enum

        public enum ButtonCustomEnum
        {
            Tools = 1,
            Help = 2,
        }

        #endregion

        protected Guid AssociatedBandObjectID;
        protected Guid AssociatedCLSIDExtension;
        [ComVisible(false)] public ToolbarButton.ButtonCustomEnum ButtomCustomMenu;
        [ComVisible(false)] public ToolbarButton.ButtonAppearanceEnum ButtonAppearance;
        protected string ButtonName;
        protected string ButtonText;
        protected bool DefaultVisibility;
        protected string ExecutePath;
        protected string HotIconPath;
        protected string IconPath;
        protected string MenuStatusBar;
        protected string MenuText;

        public abstract string PluginGuid { get; }
        public abstract string PluginProgID { get; }
        public Guid ButtonID { get; }
        public string ButtonProgID { get; }
        public Guid BandObjectID { get; }
        public Guid CLSIDExtension { get; }
        public string ToolbarButtonName { get; }
        public string ToolbarButtonText { get; }
        public string ToolbarHotIconPath { get; }
        public string ToolbarIconPath { get; }
        public string ToolbarExecutePath { get; }
        public string ToolbarMenuStatusBar { get; }
        public string ToolbarMenuText { get; }
        public bool ToolbarDefaultVisibility { get; }

        #region IControlBase Members

        public void Register();
        public void Unregister();

        #endregion

        [CLSCompliant(false)]
        public int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText);

        [CLSCompliant(false)]
        public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut);

        public event ToolbarButton.OLECommand OnButtonCommand;
    }
}
