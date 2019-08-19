using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TubeViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Window = null;
        public static Dictionary<string, SubWindow> listSubWindow = new Dictionary<string, SubWindow>();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += Window_Loaded;
            Closed += Window_Closed;
            Closing += Window_Closing;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadMenu();
        }
        private async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void Window_Closed(object sender, EventArgs e)
        {
            //Dispose();
            //base.OnClosed(e);
            //Application.Current.Shutdown();
        }
        private void OpenBrowser_Click(object sender, RoutedEventArgs e)
        {
            if (listSubWindow.ContainsKey("AuthSetting")) listSubWindow["AuthSetting"].Focus();
            else
            {
                var subWindow = new SubWindow();
                var userControl = new Controls.Browser.Main();
                listSubWindow.Add("Browser.Main", subWindow);
                TMWPF.Windows.setWindowSize(subWindow, userControl.Width + 30, userControl.Height + 50, ResizeMode.NoResize, 1);
                subWindow.Title = "Viewer";
                subWindow.Icon = Utils.Config.ImageSource(FontAwesome.WPF.FontAwesomeIcon.Chrome);
                subWindow.StackContent.Children.Clear();
                subWindow.StackContent.Children.Add(userControl);
                subWindow.Owner = this;
                subWindow.Show();
                subWindow.Focus();
            }
        }
    }
}
