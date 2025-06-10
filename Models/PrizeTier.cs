public class PrizeTier
{
    public int MainMatches { get; set; }
    public int ExtraMatches { get; set; }
    public decimal OddsRatio { get; set; }
    public long ProjectedPrize { get; set; }
    public decimal? EstimatedValue => ProjectedPrize * OddsRatio;
}