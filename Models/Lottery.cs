public class Lottery
{
    public string Name { get; set; } = string.Empty;
    public DrawSchedule Schedule { get; set; } = new();
    public List<NumberPool> NumberPools { get; set; } = new();
    public int TicketPrice { get; set; }
    public List<PrizeTier> PrizeTiers { get; set; } = new();
    public string ImagePath { get; set; } = string.Empty;
}