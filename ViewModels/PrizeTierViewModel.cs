using System.Collections.ObjectModel;
using Luckerryy.Models;
using Luckerryy.Data;

namespace Luckerryy.ViewModels
{
    public class PrizeTierViewModel
    {
        public PrizeTier Tier { get; set; } = new();
        public Lottery Lottery { get; set; } = new();
    }
}