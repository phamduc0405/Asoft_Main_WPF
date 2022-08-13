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

namespace Asoft_Main_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private int _selected;
        public int Selected 
        { 
            get { return _selected; }
            set 
            { 
                _selected = value;
                switch (_selected)
                {
                    case 0: // Auto
                        btn_Auto.Background = Brushes.DarkSlateBlue;
                        btn_Manual.Background = btn_Teaching.Background = btn_Monitor.Background = btn_Data.Background = btn_Alarm.Background = btn_Config.Background = Brushes.Transparent;
                        break;
                    case 1: // Manual
                        btn_Manual.Background = Brushes.DarkSlateBlue;
                        btn_Auto.Background = btn_Teaching.Background = btn_Monitor.Background = btn_Data.Background = btn_Alarm.Background = btn_Config.Background = Brushes.Transparent;
                        break;
                        case 2: // Teaching
                        btn_Teaching.Background = Brushes.DarkSlateBlue;
                        btn_Auto.Background = btn_Manual.Background = btn_Monitor.Background = btn_Data.Background = btn_Alarm.Background = btn_Config.Background = Brushes.Transparent;
                        break;
                    case 3: // Monitor
                        btn_Monitor.Background = Brushes.DarkSlateBlue;
                        btn_Auto.Background = btn_Manual.Background = btn_Teaching.Background = btn_Data.Background = btn_Alarm.Background = btn_Config.Background = Brushes.Transparent;
                        break;
                    case 4: // Data
                        btn_Data.Background = Brushes.DarkSlateBlue;
                        btn_Auto.Background = btn_Manual.Background = btn_Teaching.Background = btn_Monitor.Background = btn_Alarm.Background = btn_Config.Background = Brushes.Transparent;
                        break;
                    case 5: // Alarm
                        btn_Alarm.Background = Brushes.DarkSlateBlue;
                        btn_Auto.Background = btn_Manual.Background = btn_Teaching.Background = btn_Monitor.Background = btn_Data.Background = btn_Config.Background = Brushes.Transparent;
                        break;
                    case 6: // Config
                        btn_Config.Background = Brushes.DarkSlateBlue;
                        btn_Auto.Background = btn_Manual.Background = btn_Teaching.Background = btn_Monitor.Background = btn_Data.Background = btn_Alarm.Background = Brushes.Transparent;
                        break;

                    default:
                        break;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // MessageBox.Show("DucPH");
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
            if (e.ClickCount == 2)
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                }
                else
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnAuto_Click(object sender, RoutedEventArgs e)
        {
            Selected = 0;

        }
        private void btnManual_Click(object sender, RoutedEventArgs e)
        {
            Selected = 1;

        }
        private void btnTeaching_Click(object sender, RoutedEventArgs e)
        {
            Selected = 2;

        }
        private void btnMonitor_Click(object sender, RoutedEventArgs e)
        {
            Selected = 3;

        }
        private void btnData_Click(object sender, RoutedEventArgs e)
        {
            Selected = 4;

        }
        private void btnAlarm_Click(object sender, RoutedEventArgs e)
        {
            Selected = 5;

        }
        private void btnConfig_Click(object sender, RoutedEventArgs e)
        {
            Selected = 6;

        }
        
        
        
        
    }
}
