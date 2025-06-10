public interface ILotteryService
{
    decimal? CalculatePercentageEV(PrizeTier tier, Lottery lottery);
    TimeSpan GetTimeUntilDeadline(Lottery lottery);
}
public class LotteryService : ILotteryService
{
    public decimal? CalculatePercentageEV(PrizeTier tier, Lottery lottery)
    {
        if (lottery.TicketPrice == 0 || !tier.EstimatedValue.HasValue)
            return null;

        return tier.EstimatedValue.Value / lottery.TicketPrice * 100;
    }
    public TimeSpan GetTimeUntilDeadline(Lottery lottery)
    {
        var nextDeadLine = lottery.Schedule.NextDraw.Date + lottery.Schedule.Deadline;
        return nextDeadLine - DateTime.Now;
    }
}
public class PrizeTierViewModel
{
    public PrizeTier Tier { get; set; } = new();
    public Lottery Lottery { get; set; } = new();

    public decimal? PercentageEV => (Tier.EstimatedValue.HasValue && Lottery != null && Lottery.TicketPrice != 0)
        ? Tier.EstimatedValue / Lottery.TicketPrice * 100
        : null;

    public string DisplayPercentageEV => PercentageEV.HasValue ? $"{Math.Round(PercentageEV.Value, 2)}%" : "N/A";

    public string DisplayTier => Tier.ExtraMatches > 0 ? $"{Tier.MainMatches}+{Tier.ExtraMatches}" : Tier.MainMatches.ToString();

    public string DisplayOdds => Tier.OddsRatio > 0 ? $"1 : {Math.Round(1m / Tier.OddsRatio):N0}" : "N/A";
}