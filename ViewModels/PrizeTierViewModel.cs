using System.Collections.ObjectModel;
using Luckerryy.Models;
using Luckerryy.Data;

namespace Luckerryy.ViewModels
{
    public class PrizeTierViewModel
    {
        public ObservableCollection<Lottery> Lotteries { get; }
        public PrizeTierViewModel()
        {
            Lotteries = new ObservableCollection<Lottery>(MockData.GetLotteries());
        }
        public PrizeTier Tier { get; set; } = new();
        public Lottery Lottery { get; set; } = new();

        public decimal? PercentageEV => (Tier.EstimatedValue.HasValue && Lottery.TicketPrice != 0)
            ? Tier.EstimatedValue / Lottery.TicketPrice * 100
            : null;

        public string DisplayPercentageEV => PercentageEV.HasValue ? $"{Math.Round(PercentageEV.Value, 2)}%" : "N/A";

        public string DisplayTier => Tier.ExtraMatches > 0 ? $"{Tier.MainMatches}+{Tier.ExtraMatches}" : Tier.MainMatches.ToString();

        public string DisplayOdds => Tier.OddsRatio > 0 ? $"1 : {(1m / Tier.OddsRatio).ToString("N0")}" : "N/A";
    }
}