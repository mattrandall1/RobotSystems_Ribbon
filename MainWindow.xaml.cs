using System.Windows;
using System.Windows.Controls.Ribbon;

namespace RobotSystems_Ribbon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            // Maximises Screen
            //Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }
    }
}
