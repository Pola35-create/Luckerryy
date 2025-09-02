using Luckerryy.Models;
using System;
using System.Threading.Tasks;

namespace Luckerryy.Services
{
    public interface ILotteryService
    {
        TimeSpan GetTimeUntilDeadline(Lottery lottery);
        void RefreshData();
        Task<decimal> GetJackpotAsync(string lotteryName);
        DateTime LastUpdated { get; }
    }
}