﻿using MvvmGen;
using System.Collections.ObjectModel;

namespace DotNetWinUiApp.ViewModels
{
    [ViewModel]
    public partial class MainViewModel
    {
        partial void OnInitialize()
        {
            Trips.Add(new TripViewModel { ServiceId = "01", TripId = "0101", Direction = "R", StartTime = "10-15-24 06:12", TrainType = "Suburban", Length = "9", PostFix = "None", StartLocation = "PVO1_DAR", EndLocation = "P1C_SKU", Conflicts = "0" });
            Trips.Add(new TripViewModel { ServiceId = "01", TripId = "0102", Direction = "L", StartTime = "10-15-24 07:40", TrainType = "Suburban", Length = "9", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = "1" });
            Trips.Add(new TripViewModel { ServiceId = "02", TripId = "0201", Direction = "R", StartTime = "10-16-24 08:12", TrainType = "Suburban", Length = "9", PostFix = "None", StartLocation = "PVO2_DAR", EndLocation = "P1C_SKU", Conflicts = "2" });
            Trips.Add(new TripViewModel { ServiceId = "02", TripId = "0202", Direction = "L", StartTime = "10-16-24 09:40", TrainType = "Freight", Length = "12", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO2_DAR", Conflicts = "0" });
            Trips.Add(new TripViewModel { ServiceId = "03", TripId = "0301", Direction = "R", StartTime = "10-17-24 10:12", TrainType = "Passenger", Length = "10", PostFix = "None", StartLocation = "PVO1_DAR", EndLocation = "P1C_LIL", Conflicts = "1" });
            Trips.Add(new TripViewModel { ServiceId = "03", TripId = "0302", Direction = "L", StartTime = "10-17-24 11:40", TrainType = "Freight", Length = "11", PostFix = "None", StartLocation = "P1C_LIL", EndLocation = "PVO1_DAR", Conflicts = "1" });
            Trips.Add(new TripViewModel { ServiceId = "04", TripId = "0401", Direction = "R", StartTime = "10-18-24 12:12", TrainType = "Passenger", Length = "9", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = "0" });
            Trips.Add(new TripViewModel { ServiceId = "04", TripId = "0402", Direction = "L", StartTime = "10-18-24 13:40", TrainType = "Suburban", Length = "9", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO2_DAR", Conflicts = "1" });
            Trips.Add(new TripViewModel { ServiceId = "05", TripId = "0501", Direction = "R", StartTime = "10-19-24 14:12", TrainType = "Suburban", Length = "8", PostFix = "None", StartLocation = "PVO2_DAR", EndLocation = "P1C_SKU", Conflicts = "0" });
            Trips.Add(new TripViewModel { ServiceId = "05", TripId = "0502", Direction = "L", StartTime = "10-19-24 15:40", TrainType = "Passenger", Length = "9", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = "2" });
        }

        public ObservableCollection<TripViewModel> Trips { get; set; } = new();
    }

    [ViewModel]
    public partial class TripViewModel
    {
        [Property] private string _serviceId;
        [Property] private string _tripId;
        [Property] private string _direction;
        [Property] private string _startTime;
        [Property] private string _trainType;
        [Property] private string _length;
        [Property] private string _postFix;
        [Property] private string _startLocation;
        [Property] private string _endLocation;
        [Property] private string _conflicts;

        public string ToolTipString => $"{_startLocation} {_endLocation} {_startTime}";
    }
}