public class Lottery
{
    public string Name { get; set; } = string.Empty;
    public DrawSchedule Schedule { get; set; } = new();
    public List<NumberPool> NumberPools { get; set; } = new();
    public decimal TicketPrice { get; set; }
    public List<PrizeTier> PrizeTiers { get; set; } = new();
}