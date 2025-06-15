using System.Collections.ObjectModel;
using Luckerryy.Models;
using Luckerryy.Data;

namespace Luckerryy.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Lottery> Lotteries { get; }
        public MainViewModel() 
        {
            Lotteries = new ObservableCollection<Lottery>(MockData.GetLotteries());
        }
    }
}
