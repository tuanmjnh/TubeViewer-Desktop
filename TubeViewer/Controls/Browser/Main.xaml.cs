using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;

namespace TubeViewer.Controls.Browser
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            //InitBrowser();
            //Perform dependency check to make sure all relevant resources are in our output directory.
            //var settings = new CefSettings();
            //settings.EnableInternalPdfViewerOffScreen();
            // Disable GPU in WPF and Offscreen examples until #1634 has been resolved
            //settings.CefCommandLineArgs.Add("disable-gpu", "1");
            //settings.CachePath = "cache";

            //Cef.Initialize(settings, performDependencyCheck: true);
        }
        public void InitBrowser()
        {
            //public ChromiumWebBrowser browser;
            //Cef.Initialize(new CefSettings());
            //    browser = new ChromiumWebBrowser("www.google.com");
            //    this.main.Children.Add(browser);
            //browser.Dock = DockStyle.Fill;
        }
    }
}
