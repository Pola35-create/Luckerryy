using System.Collections.ObjectModel;
using Luckerryy.Models;
using Luckerryy.Data;
using Luckerryy.Services;
using System;

namespace Luckerryy.ViewModels
{
    public class MainViewModel
    {
        private readonly ILotteryService _lotteryService;
        public ObservableCollection<Lottery> Lotteries { get; }
        public MainViewModel(ILotteryService lotteryService)
        {
            _lotteryService = lotteryService;
            var lotteries = MockData.GetLotteries();
            _lotteryService.RefreshData();
            foreach (var lottery in lotteries)
            {
                if (lottery.Name == "Ötöslottó")
                {
                    lottery.Jackpot = _lotteryService.GetJackpot("ötöslottó");
                }
            }
            Lotteries = new ObservableCollection<Lottery>(lotteries);
        }
        public DateTime LastUpdated => _lotteryService.LastUpdated;
    }
}
