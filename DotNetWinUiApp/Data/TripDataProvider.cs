using DotNetWinUiApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetWinUiApp.Data
{
    public interface ITripDataProvider
    {
        Task<IEnumerable<Trip>?> GetTripListAsync();
    }

    public class TripDataProvider : ITripDataProvider
    {
        public async Task<IEnumerable<Trip>?> GetTripListAsync()
        {
            await Task.Delay(100);
            return new List<Trip>
            {
                new Trip { ServiceId = "01", TripId = "0101", Direction = "R", StartTime = "10-15-24 06:12", TrainType = "Suburban", Length = "9", PostFix = "None", StartLocation = "PVO1_DAR", EndLocation = "P1C_SKU", Conflicts = 0 },
                new Trip { ServiceId = "01", TripId = "0102", Direction = "L", StartTime = "10-15-24 07:40", TrainType = "Suburban", Length = "8", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO2_DAR", Conflicts = 1 },
                new Trip { ServiceId = "02", TripId = "0201", Direction = "R", StartTime = "10-16-24 08:12", TrainType = "Freight", Length = "12", PostFix = "None", StartLocation = "PVO2_DAR", EndLocation = "P1C_SKU", Conflicts = 2 },
                new Trip { ServiceId = "02", TripId = "0202", Direction = "L", StartTime = "10-16-24 09:40", TrainType = "Passenger", Length = "10", PostFix = "Express", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = 0 },
                new Trip { ServiceId = "03", TripId = "0301", Direction = "R", StartTime = "10-17-24 10:12", TrainType = "Express", Length = "15", PostFix = "None", StartLocation = "PVO1_DAR", EndLocation = "P1C_LIL", Conflicts = 3 },
                new Trip { ServiceId = "03", TripId = "0302", Direction = "L", StartTime = "10-17-24 11:40", TrainType = "Suburban", Length = "9", PostFix = "None", StartLocation = "P1C_LIL", EndLocation = "PVO2_DAR", Conflicts = 1 },
                new Trip { ServiceId = "04", TripId = "0401", Direction = "R", StartTime = "10-18-24 12:12", TrainType = "Suburban", Length = "7", PostFix = "Local", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = 0 },
                new Trip { ServiceId = "04", TripId = "0402", Direction = "L", StartTime = "10-18-24 13:40", TrainType = "Freight", Length = "12", PostFix = "Cargo", StartLocation = "P1C_SKU", EndLocation = "PVO2_DAR", Conflicts = 2 },
                new Trip { ServiceId = "05", TripId = "0501", Direction = "R", StartTime = "10-19-24 14:12", TrainType = "Passenger", Length = "10", PostFix = "None", StartLocation = "PVO2_DAR", EndLocation = "P1C_SKU", Conflicts = 1 },
                new Trip { ServiceId = "05", TripId = "0502", Direction = "L", StartTime = "10-19-24 15:40", TrainType = "Express", Length = "15", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = 3 },
                new Trip { ServiceId = "06", TripId = "0601", Direction = "R", StartTime = "10-20-24 08:30", TrainType = "Suburban", Length = "9", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO2_DAR", Conflicts = 2 },
                new Trip { ServiceId = "06", TripId = "0602", Direction = "L", StartTime = "10-20-24 09:15", TrainType = "Freight", Length = "14", PostFix = "Cargo", StartLocation = "PVO2_DAR", EndLocation = "P1C_LIL", Conflicts = 0 },
                new Trip { ServiceId = "07", TripId = "0701", Direction = "R", StartTime = "10-21-24 16:50", TrainType = "Passenger", Length = "9", PostFix = "Express", StartLocation = "P1C_SKU", EndLocation = "P1C_LIL", Conflicts = 1 },
                new Trip { ServiceId = "07", TripId = "0702", Direction = "L", StartTime = "10-21-24 17:20", TrainType = "Suburban", Length = "11", PostFix = "None", StartLocation = "P1C_LIL", EndLocation = "PVO1_DAR", Conflicts = 1 },
                new Trip { ServiceId = "08", TripId = "0801", Direction = "R", StartTime = "10-22-24 11:00", TrainType = "Express", Length = "16", PostFix = "Fast", StartLocation = "PVO1_DAR", EndLocation = "P1C_SKU", Conflicts = 0 },
                new Trip { ServiceId = "08", TripId = "0802", Direction = "L", StartTime = "10-22-24 11:50", TrainType = "Freight", Length = "13", PostFix = "Heavy", StartLocation = "P1C_SKU", EndLocation = "PVO2_DAR", Conflicts = 2 },
                new Trip { ServiceId = "09", TripId = "0901", Direction = "R", StartTime = "10-23-24 14:00", TrainType = "Passenger", Length = "10", PostFix = "None", StartLocation = "PVO1_DAR", EndLocation = "P1C_LIL", Conflicts = 0 },
                new Trip { ServiceId = "09", TripId = "0902", Direction = "L", StartTime = "10-23-24 14:50", TrainType = "Suburban", Length = "8", PostFix = "None", StartLocation = "P1C_LIL", EndLocation = "P1C_SKU", Conflicts = 0 },
                new Trip { ServiceId = "10", TripId = "1001", Direction = "R", StartTime = "10-24-24 08:30", TrainType = "Express", Length = "15", PostFix = "None", StartLocation = "PVO1_DAR", EndLocation = "P1C_SKU", Conflicts = 0 },
                new Trip { ServiceId = "10", TripId = "1002", Direction = "L", StartTime = "10-24-24 09:15", TrainType = "Freight", Length = "14", PostFix = "Heavy", StartLocation = "PVO2_DAR", EndLocation = "PVO1_DAR", Conflicts = 0 },
                new Trip { ServiceId = "11", TripId = "1101", Direction = "R", StartTime = "10-25-24 06:50", TrainType = "Freight", Length = "13", PostFix = "Cargo", StartLocation = "P1C_LIL", EndLocation = "PVO2_DAR", Conflicts = 0 },
                new Trip { ServiceId = "11", TripId = "1102", Direction = "L", StartTime = "10-25-24 07:30", TrainType = "Passenger", Length = "9", PostFix = "Local", StartLocation = "PVO1_DAR", EndLocation = "P1C_SKU", Conflicts = 0 },
                new Trip { ServiceId = "12", TripId = "1201", Direction = "R", StartTime = "10-26-24 09:10", TrainType = "Express", Length = "12", PostFix = "None", StartLocation = "PVO2_DAR", EndLocation = "P1C_LIL", Conflicts = 0 },
                new Trip { ServiceId = "12", TripId = "1202", Direction = "L", StartTime = "10-26-24 10:20", TrainType = "Freight", Length = "15", PostFix = "Heavy", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = 0 },
                new Trip { ServiceId = "13", TripId = "1301", Direction = "R", StartTime = "10-27-24 13:30", TrainType = "Passenger", Length = "10", PostFix = "Express", StartLocation = "PVO1_DAR", EndLocation = "P1C_LIL", Conflicts = 0 },
                new Trip { ServiceId = "13", TripId = "1302", Direction = "L", StartTime = "10-27-24 14:05", TrainType = "Suburban", Length = "8", PostFix = "None", StartLocation = "PVO2_DAR", EndLocation = "P1C_SKU", Conflicts = 0 },
                new Trip { ServiceId = "14", TripId = "1401", Direction = "R", StartTime = "10-28-24 15:50", TrainType = "Freight", Length = "14", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "P1C_LIL", Conflicts = 0 },
                new Trip { ServiceId = "14", TripId = "1402", Direction = "L", StartTime = "10-28-24 16:25", TrainType = "Express", Length = "9", PostFix = "Fast", StartLocation = "PVO1_DAR", EndLocation = "PVO2_DAR", Conflicts = 0 },
                new Trip { ServiceId = "15", TripId = "1501", Direction = "R", StartTime = "10-29-24 08:45", TrainType = "Passenger", Length = "11", PostFix = "None", StartLocation = "P1C_SKU", EndLocation = "PVO1_DAR", Conflicts = 0 },
                new Trip { ServiceId = "15", TripId = "1502", Direction = "L", StartTime = "10-29-24 09:20", TrainType = "Freight", Length = "13", PostFix = "Heavy", StartLocation = "P1C_LIL", EndLocation = "PVO2_DAR", Conflicts = 0 },
            };
        }
    }
}
