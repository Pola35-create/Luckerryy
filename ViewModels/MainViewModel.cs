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
            _lotteryService = lotteryService ?? throw new ArgumentNullException(nameof(lotteryService));
            Lotteries = new ObservableCollection<Lottery>(MockData.GetLotteries());
            LoadJackpotsAsync();
        }
        private async void LoadJackpotsAsync()
        {
            foreach (var lottery in Lotteries)
            {
                var jackpot = await _lotteryService.GetJackpotAsync(lottery.Name);
                lottery.UpdateJackpot(jackpot);
            }
        }
        public DateTime LastUpdated => _lotteryService.LastUpdated;
    }
}
