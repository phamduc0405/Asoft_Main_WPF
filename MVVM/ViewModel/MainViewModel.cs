using Asoft_Main_WPF.Core;
using System;
using System.Windows.Threading;
using Asoft_Main_WPF.Properties;
using System.Windows;

namespace Asoft_Main_WPF.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ManualViewCommand { get; set; }
        public RelayCommand DataViewCommand { get; set; }
        public RelayCommand ConfigViewCommand { get; set; }
        public RelayCommand TeachingViewCommand { get; set; }
        public RelayCommand AlarmViewCommand { get; set; }
        public RelayCommand MonitorViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public ManualViewModel ManualVm { get; set; }
        public DataViewModel DataVm { get; set; }
        public TeachingViewModel TeachingVm { get; set; }
        public AlarmViewModel AlarmVm { get; set; }
        public ConfigViewModel ConfigVm { get; set; }
        public MonitorViewModel MonitorVm { get; set; }

        private string _header;
        public String Header
        {
            get { return _header; }
            set
            {
                _header = value;
                OnPropertyChanged();
            }
        }

        private object _currentview;
        public object Currentview
        {
            get { return _currentview; }
            set
            {
                _currentview = value;
                OnPropertyChanged();
            }
        }
        private DateTime _datetime;
        public DateTime Datetime
        {
            get { return _datetime; }
            set
            {
                _datetime = value;
                OnPropertyChanged();
            }
        }
        // public DateTime datetime { get; set; } = DateTime.Now;
        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            ManualVm = new ManualViewModel();
            DataVm = new DataViewModel();
            TeachingVm = new TeachingViewModel();
            AlarmVm = new AlarmViewModel();
            ConfigVm = new ConfigViewModel();
            MonitorVm = new MonitorViewModel();
            Currentview = ManualVm;
            Header = "Manual";
            #region Chuyển Màn Hình Child Auto,Manual
            HomeViewCommand = new RelayCommand(o =>
            {
                Currentview = HomeVm;
                Header = "Auto";
            });
            ManualViewCommand = new RelayCommand(o =>
            {
                Currentview = ManualVm;
                Header = "Manual";
            });
            DataViewCommand = new RelayCommand(o =>
            {
                Currentview = DataVm;
                Header = "Data";
            });
            TeachingViewCommand = new RelayCommand(o =>
            {
                Currentview = TeachingVm;
                Header = "Teaching";
            });
            ConfigViewCommand = new RelayCommand(o =>
            {
                Currentview = ConfigVm;
                Header = "Config";
            });
            AlarmViewCommand = new RelayCommand(o =>
            {
                Currentview = AlarmVm;
                Header = "Alarm";
            });
            MonitorViewCommand = new RelayCommand(o =>
            {
                Currentview = MonitorVm;
                Header = "Monitor";
            });
            #endregion

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval =new TimeSpan(0,0,1);
            timer.Tick += Timer_Tick;
            timer.Start();
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Datetime = DateTime.Now;
        }
    }
}
