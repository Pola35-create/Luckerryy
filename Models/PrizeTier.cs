namespace Luckerryy.Models
{
    public class PrizeTier
    {
        public int MainMatches { get; set; }
        public int ExtraMatches { get; set; }
        public decimal OddsRatio { get; set; }
        public decimal ProjectedPrize { get; set; }
        public decimal? EstimatedValue => ProjectedPrize * OddsRatio;
    }
}