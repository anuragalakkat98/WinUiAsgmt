using DotNetWinUiApp.Data;
using DotNetWinUiApp.ViewModel;
using Microsoft.UI.Xaml;

namespace DotNetWinUiApp
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel(new TripDataProvider());
            TripsListView.DataContext = ViewModel;
            TripsListView.Loaded += TripsListView_Loaded;
        }

        private async void TripsListView_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadAsync();
        }

        public MainViewModel ViewModel { get; }

        private bool _sortDirectionAsc = true;

        //private void OnServiceIdHeaderClicked(object sender, RoutedEventArgs e)
        //{
        //    ViewModel.SortTripsByServiceId(_sortDirectionAsc);
        //    _sortDirectionAsc = !_sortDirectionAsc;
        //}
        private void OnColumnHeaderClicked(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement header && header.Tag is string propertyName)
            {
                ViewModel.SortTripsByProperty(propertyName, _sortDirectionAsc);
                _sortDirectionAsc = !_sortDirectionAsc;
            }
        }
    }
}
