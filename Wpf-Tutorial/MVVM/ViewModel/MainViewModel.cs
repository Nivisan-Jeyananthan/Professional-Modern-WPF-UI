using Wpf_Tutorial.Core;

namespace Wpf_Tutorial.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeViewModel { get; set; }
        public DiscoveryViewModel DiscoveryViewModel { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeViewModel = new HomeViewModel();
            DiscoveryViewModel = new DiscoveryViewModel();
            CurrentView = HomeViewModel;

            HomeViewCommand = new(o => { 
            CurrentView = HomeViewModel;
            });

            DiscoveryViewCommand = new(o => {
                CurrentView = DiscoveryViewModel;
            });
        }




    }
}
