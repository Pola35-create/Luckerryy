public class PrizeTier
{
    public int MatchedNumbers { get; set; }
    public decimal? OddsRatio { get; set; }
    public string DisplayOdds => $"1 in {OddsRatio:N0}";
    public decimal? AveragePrize { get; set; }
    public decimal? EstimatedValue { get; set; }
}