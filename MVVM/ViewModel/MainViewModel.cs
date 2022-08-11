using Asoft_Main_WPF.Core;
using System;


namespace Asoft_Main_WPF.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ManualViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        //public ManualViewModel ManualVm { get; set; }
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


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            //ManualVm = new ManualViewModel();
            Currentview = HomeVm;
            HomeViewCommand = new RelayCommand(o =>
            {
                Currentview = HomeVm;
            });
            //ManualViewCommand = new RelayCommand(o =>
            //{
            //    Currentview = ManualVm;
            //});
        }
    }
}
