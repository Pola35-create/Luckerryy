namespace Luckerryy.Models
{
    public class Lottery
    {
        public string Name { get; set; } = string.Empty;
        public decimal TicketPrice { get; set; }
        public decimal Jackpot => PrizeTiers?.Any() == true ? PrizeTiers.Max(pt => pt.ProjectedPrize) : 0m;
        public DrawSchedule Schedule { get; set; } = new();
        public List<NumberPool> NumberPools { get; set; } = new();
        public List<PrizeTier> PrizeTiers { get; set; } = new();
    }
}