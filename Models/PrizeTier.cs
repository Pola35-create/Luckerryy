namespace Luckerryy.Models
{
    public record PrizeTier(
        string Name = "",
        int MainMatches = 0,
        int ExtraMatches = 0,
        decimal OddsRatio = 0m,
        decimal ProjectedPrize = 0m,
        bool IsJackpot = false
    )
    {
        public double Probability => OddsRatio > 0 ? (double)OddsRatio : 0.0;
        public decimal AvgPrize => ProjectedPrize;
    }
}