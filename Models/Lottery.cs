using System.Windows.Media;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Luckerryy.Models
{
    public class Lottery : INotifyPropertyChanged
    {
        private decimal _jackpot;
        public string Name { get; set; } = string.Empty;
        public decimal TicketPrice { get; set; }
        public decimal Jackpot 
        {
            get => _jackpot;
            private set
            {
                if (_jackpot != value)
                {
                    _jackpot = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(EV));
                }
            }
        }
        public decimal TopTierOddsRatio { get; set; }
        public decimal EV =>
            (PrizeTiers?.Sum(pt => pt.ProjectedPrize * pt.OddsRatio) ?? 0) +
            (Jackpot * TopTierOddsRatio);
        public decimal? EVPercentage =>
            TicketPrice != 0 ? (EV / TicketPrice) * 100 : null;
        public string DisplayEV =>
            $"EV: {EV:0.000} Ft - {(EVPercentage.HasValue ? EVPercentage.Value.ToString("0.00") + "%" : "N/A")}";
        public void UpdateJackpot(decimal jackpot)
        {
            Jackpot = jackpot;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public DrawSchedule Schedule { get; set; } = new();
        public List<NumberPool> NumberPools { get; set; } = new();
        public List<PrizeTier> PrizeTiers { get; set; } = new();
        public double X { get; set; }
        public double Y { get; set; }

        public Brush BackgroundBrush
        {
            get
            {
                return Name switch
                {
                    "Ötöslottó" => new SolidColorBrush(Color.FromRgb(0x00, 0xA7, 0x69)),
                    "Hatoslottó" => new SolidColorBrush(Color.FromRgb(0xEB, 0x0F, 0x42)),
                    "Skandinávlottó" => new SolidColorBrush(Color.FromRgb(0xFF, 0xD4, 0x1F)),
                    "Eurojackpot" => new SolidColorBrush(Color.FromRgb(0xFE, 0xD9, 0x01)),
                    "Joker" => new SolidColorBrush(Color.FromRgb(0xE2, 0x19, 0x40)),
                    _ => new SolidColorBrush(Colors.Gray)
                };
            }
        }
    }
}