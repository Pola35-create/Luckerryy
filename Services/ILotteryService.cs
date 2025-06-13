using Luckerryy.Models;

namespace Luckerryy.Services
{
    public interface ILotteryService
    {
        decimal? CalculatePercentageEV(PrizeTier tier, Lottery lottery);
        TimeSpan GetTimeUntilDeadline(Lottery lottery);
    }
}