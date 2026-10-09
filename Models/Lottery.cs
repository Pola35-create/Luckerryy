using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Luckerryy.Models
{
    public class Lottery : INotifyPropertyChanged
    {
        private decimal _jackpot;

        public List<NumberPool> NumberPools { get; set; } = new();
        public List<PrizeTier> PrizeTiers { get; set; } = new();
        public double X { get; set; }
        public double Y { get; set; }

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
                    OnPropertyChanged(nameof(EVPercentage));
                    OnPropertyChanged(nameof(DisplayEV));
                }
            }
        }
        public decimal TopTierOddsRatio { get; set; }
        public decimal EV =>
            (PrizeTiers?.Sum(pt => pt.ProjectedPrize * pt.OddsRatio) ?? 0) +
            (Jackpot * TopTierOddsRatio);
        public decimal? EVPercentage =>
            TicketPrice != 0 ? EV / TicketPrice * 100 : null;
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
    }
}