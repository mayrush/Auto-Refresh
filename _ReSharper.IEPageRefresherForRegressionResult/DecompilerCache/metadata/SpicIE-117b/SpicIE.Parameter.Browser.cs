// Type: SpicIE.Parameter.Browser
// Assembly: SpicIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7066b1a7ed5618f
// Assembly location: C:\Documents and Settings\chaaa\My Documents\Projects\IEPageRefresherForRegressionResult\Libraries\SpicIE.dll

using SHDocVw;
using System;

namespace SpicIE.Parameter
{
    [CLSCompliant(false)]
    public class Browser
    {
        #region BrowserBar enum

        public enum BrowserBar
        {
            clsid = 0,
            addressbar = 9,
            toolbar = 10,
            linkbar = 11,
        }

        #endregion

        #region BrowserNavConstants enum

        public enum BrowserNavConstants
        {
            navOpenInNewWindow = 1,
            navNoHistory = 2,
            navNoReadFromCache = 4,
            navNoWriteToCache = 8,
            navAllowAutosearch = 16,
            navBrowserBar = 32,
            navHyperlink = 64,
            navEnforceRestricted = 128,
            navNewWindowsManaged = 256,
            navUntrustedForDownload = 512,
            navTrustedForActiveX = 1024,
            navOpenInNewTab = 2048,
            navOpenInBackgroundTab = 4096,
            navKeepWordWheelText = 8192,
        }

        #endregion

        #region RefreshConstants enum

        public enum RefreshConstants
        {
            REFRESH_NORMAL = 0,
            REFRESH_IFEXPIRED = 1,
            REFRESH_COMPLETELY = 3,
        }

        #endregion

        #region State enum

        public enum State
        {
            complete,
            interactive,
            loaded,
            loading,
            uninitialized,
        }

        #endregion

        #region TargetFrameName enum

        public enum TargetFrameName
        {
            _blank,
            _parent,
            _self,
            _top,
        }

        #endregion

        protected static IWebBrowser2 browserRef;
        public Browser(IWebBrowser2 browser);
        public bool AddressBar { get; set; }
        public bool IsBusy { get; }
        public bool FullScreen { get; set; }
        public bool Visible { get; set; }
        public bool Resizable { get; set; }
        public bool TheaterMode { get; set; }
        public bool RegisterAsBrowser { get; set; }
        public bool MenuBar { get; set; }
        public int ToolBar { get; set; }
        public int HWND { get; }
        public bool Offline { get; set; }
        public bool Silent { get; set; }
        public bool StatusBar { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public object Parent { get; }
        public Document CurrentDocument { get; }
        public string Path { get; }
        public string StatusText { get; set; }
        public string LocationName { get; }
        public string LocationURL { get; }
        public string Name { get; }
        public Browser.State ReadyState { get; }
        public void ShowBrowserBar(Browser.BrowserBar target, string clsid, bool isVisible);
        public void Refresh();
        public void Refresh2(Browser.RefreshConstants refreshType);

        public void Navigate(string url, Browser.BrowserNavConstants[] flags, Browser.TargetFrameName target,
                             byte[] postdata, string[] headers);

        public void Navigate2(string url, Browser.BrowserNavConstants[] flags, Browser.TargetFrameName target,
                              byte[] postdata, string[] headers);

        public void Client2Window(int width, int height);
        public void Stop();
        public void Quit();
        public void GoBack();
        public void GoForward();
        public void GoHome();
        public void GoSearch();
    }
}
