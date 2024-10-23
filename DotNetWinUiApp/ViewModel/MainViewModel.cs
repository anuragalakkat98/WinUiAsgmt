using DotNetWinUiApp.Data;
using DotNetWinUiApp.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace DotNetWinUiApp.ViewModel
{
    public class MainViewModel
    {
        private ITripDataProvider _tripDataProvider;
        public ObservableCollection<Trip> Trips { get; set; } = new();

        public MainViewModel(ITripDataProvider tripDataProvider) 
        {
            _tripDataProvider = tripDataProvider;
        }

        public async Task LoadAsync()
        {
            var trips = await _tripDataProvider.GetTripListAsync();
            if(trips != null)
            {
                foreach(var trip in trips)
                {
                    Trips.Add(trip);
                }
            }
        }
    }
}
