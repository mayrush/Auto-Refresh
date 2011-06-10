using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SpicIE;
using SpicIE.Controls;
using System.Windows.Forms;

namespace PageRefresher
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid(PluginGuid)]
    [ProgId(PluginProgId)]
    public class PageRefresherPlugin : Host
    {
        public const string PluginGuid = "0CEF60D9-7010-4D7C-8DA7-D616D58C805F";
        public const string PluginProgId = "PageRefresherPlugin.SpicIE";

        public static PageRefresherPlugin HostInstance;

        public PageRefresherPlugin()
        {
            HostInstance = this;
        }

        internal static List<IControlBase> RunOnceCOMRegistration()
        {
            var controls = new List<IControlBase> { new AutoRefreshTooButton() };

            return controls;
        }

        #region SpicIE - Required methods, do not change

        /// <summary>
        /// This function is necessary to register this plugin using the functions provided in the SpicIE.Host
        /// The function and its contents must not be changed
        /// </summary>
        /// <param name="typeToRegister"></param>
        [ComRegisterFunction]
        internal static void RegisterControls(Type typeToRegister)
        {
            RegisterHost(typeToRegister, PluginGuid, PluginProgId);
            RegisterControls(RunOnceCOMRegistration());
        }

        /// <summary>
        /// This function is necessary to unregister this plugin using the functions provided in the SpicIE.Host
        /// The function and its contents must not be changed
        /// </summary>
        /// <param name="typeToRegister"></param>
        [ComUnregisterFunction]
        internal static void UnregisterControls(Type typeToRegister)
        {
            UnregisterHost(typeToRegister, PluginGuid);
            UnregisterControls(RunOnceCOMRegistration());
        }

        #endregion

    }
}
