using Luckerryy.Models;
using Luckerryy.Utils;
using System;
using System.Collections.Generic;

namespace Luckerryy.Services
{
    public class LotteryService : ILotteryService
    {
        private readonly LotteryScraper _scraper;
        private Dictionary<string, decimal> _jackpotCache;
        private DateTime _lastUpdated;
        public LotteryService()
        {
            _scraper = new LotteryScraper();
            _jackpotCache = new Dictionary<string, decimal>();
            _lastUpdated = DateTime.MinValue;
        }
        public TimeSpan GetTimeUntilDeadline(Lottery lottery)
        {
            var nextDeadLine = lottery.Schedule.NextDraw.Date + lottery.Schedule.Deadline;
            return nextDeadLine - DateTime.Now;
        }
        public void RefreshData()
        {
            _jackpotCache.Clear();

            string otosJackpotText = _scraper.ScrapeOtosLotto();
            _jackpotCache["ötöslottó"] = LotteryUtils.ParseJackpot(otosJackpotText);
            string hatosJackpotText = _scraper.ScrapeHatosLotto();
            _jackpotCache["hatoslottó"] = LotteryUtils.ParseJackpot(hatosJackpotText);
            string skandiJackpotText = _scraper.ScrapeSkandiLotto();
            _jackpotCache["skandinávlottó"] = LotteryUtils.ParseJackpot(skandiJackpotText);
            string euroJackpotText = _scraper.ScrapeEurojackpot();
            _jackpotCache["eurojackpot"] = LotteryUtils.ParseJackpot(euroJackpotText);
            string jokerJackpotText = _scraper.ScrapeJoker();
            _jackpotCache["joker"] = LotteryUtils.ParseJackpot(jokerJackpotText);

            _lastUpdated = DateTime.Now;
        }
        public async Task<decimal> GetJackpotAsync(string lotteryName)
        {
            return await Task.Run(() =>
            {
                return lotteryName.ToLower() switch
                {
                    "ötöslottó" => LotteryUtils.ParseJackpot(_scraper.ScrapeOtosLotto()),
                    "hatoslottó" => LotteryUtils.ParseJackpot(_scraper.ScrapeHatosLotto()),
                    "skandinávlottó" => LotteryUtils.ParseJackpot(_scraper.ScrapeSkandiLotto()),
                    "eurojackpot" => LotteryUtils.ParseJackpot(_scraper.ScrapeEurojackpot()),
                    "joker" => LotteryUtils.ParseJackpot(_scraper.ScrapeJoker()),
                    _ => 0
                };
            });
        }
        public DateTime LastUpdated => _lastUpdated;
    }
}