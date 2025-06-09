public class PrizeTier
{
    public int MainMatches { get; set; }
    public int ExtraMatches { get; set; }
    public decimal OddsRatio { get; set; }
    public string DisplayOdds => $"1 in {OddsRatio:N0}";
    public long ProjectedPrize { get; set; }
    public decimal? EstimatedValue { get; set; }
    public string Display => ExtraMatches > 0 ? $"{MainMatches}+{ExtraMatches}" : MainMatches.ToString(); 
}