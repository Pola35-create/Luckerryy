using Luckerryy.Models;
using System;
using System.Threading.Tasks;

namespace Luckerryy.Services
{
    public interface ILotteryService
    {
        decimal? CalculatePercentageEV(PrizeTier tier, Lottery lottery);
        TimeSpan GetTimeUntilDeadline(Lottery lottery);
        void RefreshData();
        Task<decimal> GetJackpotAsync(string lotteryName);
        DateTime LastUpdated { get; }
    }
}