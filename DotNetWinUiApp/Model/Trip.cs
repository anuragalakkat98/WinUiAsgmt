using Microsoft.UI.Xaml.Media;
using Microsoft.UI;

namespace DotNetWinUiApp.Model
{
    public class Trip
    {
        public string ServiceId { get; set; } = string.Empty;
        public string TripId { get; set; } = string.Empty;
        public string Direction { get; set; } = string.Empty;
        public string StartTime { get; set; } = string.Empty;
        public string TrainType { get; set; } = string.Empty;
        public string Length { get; set; } = string.Empty;
        public string PostFix { get; set; } = string.Empty;
        public string StartLocation { get; set; } = string.Empty;
        public string EndLocation { get; set; } = string.Empty;
        public int Conflicts { get; set; }
        public string ToolTipContent => $"{StartLocation} {EndLocation} {StartTime}";
        public SolidColorBrush ForegroundColor
        {
            get
            {
                return Conflicts > 0 ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Black);
            }
        }
    }
}
