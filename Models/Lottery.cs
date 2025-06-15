using System.Windows.Media;

namespace Luckerryy.Models
{
    public class Lottery
    {
        public string Name { get; set; } = string.Empty;
        public decimal TicketPrice { get; set; }
        public decimal Jackpot => PrizeTiers?.Any() == true ? PrizeTiers.Max(pt => pt.ProjectedPrize) : 0m;
        public decimal EV => PrizeTiers?.Sum(pt => pt.ProjectedPrize * pt.OddsRatio) ?? 0;
        public DrawSchedule Schedule { get; set; } = new();
        public List<NumberPool> NumberPools { get; set; } = new();
        public List<PrizeTier> PrizeTiers { get; set; } = new();
        public double X { get; set; }
        public double Y { get; set; }

        public Brush BackgroundBrush
        {
            get
            {
                return Name switch
                {
                    "Ötöslottó" => new SolidColorBrush(Color.FromRgb(0x00, 0xA7, 0x69)),
                    "Hatoslottó" => new SolidColorBrush(Color.FromRgb(0xEB, 0x0F, 0x42)),
                    "Skandinávlottó" => new SolidColorBrush(Color.FromRgb(0xFF, 0xD4, 0x1F)),
                    "Eurojackpot" => new SolidColorBrush(Color.FromRgb(0xFE, 0xD9, 0x01)),
                    "Joker" => new SolidColorBrush(Color.FromRgb(0xE2, 0x19, 0x40)),
                    _ => new SolidColorBrush(Colors.Gray)
                };
            }
        }
    }
}