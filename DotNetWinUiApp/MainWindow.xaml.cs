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
    }
}
