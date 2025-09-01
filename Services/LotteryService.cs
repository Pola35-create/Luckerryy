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
        public decimal GetJackpot(string lotteryKey)
        {
            if (_jackpotCache.ContainsKey(lotteryKey))
                return _jackpotCache[lotteryKey];
            throw new Exception($"Jackpot for {lotteryKey} not available. Did you call RefreshData()?");
        }
        public DateTime LastUpdated => _lastUpdated;
    }
}