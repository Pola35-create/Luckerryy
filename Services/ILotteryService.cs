using Luckerryy.Models;
using System;

namespace Luckerryy.Services
{
    public interface ILotteryService
    {
        decimal? CalculatePercentageEV(PrizeTier tier, Lottery lottery);
        TimeSpan GetTimeUntilDeadline(Lottery lottery);
        void RefreshData();
        decimal GetJackpot(string lotteryKey);
        DateTime LastUpdated { get; }
    }
}