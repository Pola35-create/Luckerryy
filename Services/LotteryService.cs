using Luckerryy.Models;

namespace Luckerryy.Services
{
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
}