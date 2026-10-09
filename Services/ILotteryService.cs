using System;
using System.Threading.Tasks;

namespace Luckerryy.Services
{
    public interface ILotteryService
    {
        Task RefreshDataAsync();
        decimal GetJackpot(string lotteryName);
        IReadOnlyDictionary<string, decimal> GetAllJackpots();
        DateTime LastUpdated { get; }
    }
}