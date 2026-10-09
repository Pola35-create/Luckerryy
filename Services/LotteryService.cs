using Luckerryy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luckerryy.Services
{
    public class LotteryService : ILotteryService
    {
        private readonly LotteryScraper _scraper;
        private readonly Dictionary<string, decimal> _jackpotCache = new(StringComparer.OrdinalIgnoreCase);
        
        private static readonly string[] SupportedGames = new[]
        {
            "otoslotto",
            "hatoslotto",
            "skandinavlotto",
            "eurojackpot",
            "joker"
        };

        public LotteryService(LotteryScraper scraper)
        {
            _scraper = scraper;
            LastUpdated = DateTime.MinValue;
        }

        public async Task RefreshDataAsync()
        {
            _jackpotCache.Clear();

            // Fetch all jackpots concurrently in parallel using Task.WhenAll
            var tasks = SupportedGames.Select(async game =>
            {
                string rawText = await _scraper.ScrapeJackpotTextAsync(game);
                decimal amount = LotteryUtils.ParseJackpot(rawText);
                return (Game: game, Amount: amount);
            });

            var results = await Task.WhenAll(tasks);

            foreach (var result in results)
            {
                _jackpotCache[result.Game] = result.Amount;
            }

            LastUpdated = DateTime.Now;
        }

        public decimal GetJackpot(string lotteryName)
        {
            return _jackpotCache.TryGetValue(lotteryName, out decimal amount) ? amount : 0m;
        }

        public IReadOnlyDictionary<string, decimal> GetAllJackpots() => _jackpotCache;

        public DateTime LastUpdated { get; private set; }
    }
}