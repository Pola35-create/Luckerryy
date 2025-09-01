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
            Lotteries = new ObservableCollection<Lottery>(MockData.GetLotteries());
            LoadJackpotsAsync(lotteryService);
        }
        private async void LoadJackpotsAsync(ILotteryService lotteryService)
        {
            foreach (var lottery in Lotteries)
            {
                var jackpot = await lotteryService.GetJackpotAsync(lottery.Name);
                lottery.UpdateJackpot(jackpot);
            }
        }
        public DateTime LastUpdated => _lotteryService.LastUpdated;
    }
}
