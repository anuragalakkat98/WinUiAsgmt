using DotNetWinUiApp.Data;
using DotNetWinUiApp.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

        //public void SortTripsByServiceId(bool ascending)
        //{
        //    var sortedTrips = ascending
        //        ? Trips.OrderBy(t => t.ServiceId).ToList()
        //        : Trips.OrderByDescending(t => t.ServiceId).ToList();
        //    Trips.Clear();
        //    foreach (var trip in sortedTrips)
        //    {
        //        Trips.Add(trip);
        //    }
        //}

        public void SortTripsByProperty(string propertyName, bool ascending)
        {
            var propertyInfo = typeof(Trip).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfo == null) return;

            var sortedTrips = ascending
                ? Trips.OrderBy(t => propertyInfo.GetValue(t, null)).ToList()
                : Trips.OrderByDescending(t => propertyInfo.GetValue(t, null)).ToList();

            Trips.Clear();
            foreach (var trip in sortedTrips)
            {
                Trips.Add(trip);
            }
        }
    }
}
