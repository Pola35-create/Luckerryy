using Luckerryy.Models;
using Luckerryy.Services;
using Luckerryy.Utils;

namespace Luckerryy.Data
{
    public static class MockData
    {
        public static List<Lottery> GetLotteries()
        {
            var scraper = new LotteryScraper();
            string jackpotText = scraper.ScrapeOtosLotto();
            decimal jackpot = LotteryUtils.ParseJackpot(jackpotText);

            return new List<Lottery>
            {
                new Lottery
                {
                    Name = "Ötöslottó",
                    TicketPrice = 400,
                    Jackpot = jackpot,
                    TopTierOddsRatio = 1m/43949268m,
                    X = 170,
                    Y = 62,
                    Schedule = new DrawSchedule
                    {
                        Days = new List<DayOfWeek> {DayOfWeek.Saturday},
                        DrawTime = new TimeSpan(18, 45, 0),
                        Deadline = new TimeSpan(17, 30, 0)
                    },
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Főszámok",
                            NumbersToPick = 5,
                            TotalNumberRange = 90
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/103410m, ProjectedPrize = 1993021 },
                        new PrizeTier{ MainMatches = 3, OddsRatio = 1m/1231m, ProjectedPrize = 22509 },
                        new PrizeTier{ MainMatches = 2, OddsRatio = 1m/44m, ProjectedPrize = 3108 }
                    }
                },
                new Lottery
                {
                    Name = "Hatoslottó",
                    X = 923,
                    Y = 62,
                    TicketPrice = 400,
                    Schedule = new DrawSchedule
                    {
                        Days = new List<DayOfWeek> {DayOfWeek.Sunday},
                        DrawTime = new TimeSpan(16, 00, 0),
                        Deadline = new TimeSpan(14, 30, 0)
                    },
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Főszámok",
                            NumbersToPick = 6,
                            TotalNumberRange = 45
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 6, OddsRatio = 1m/8145060m, ProjectedPrize = 230000000 },
                        new PrizeTier{ MainMatches = 5, OddsRatio = 1m/34808m, ProjectedPrize = 237300 },
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/733m, ProjectedPrize = 6220 },
                        new PrizeTier{ MainMatches = 3, OddsRatio = 1m/45m, ProjectedPrize = 2705 }
                    }
                },
                new Lottery
                {
                    Name = "Skandinávlottó",
                    X = 170,
                    Y = 313,
                    TicketPrice = 400,
                    Schedule = new DrawSchedule
                    {
                        Days = new List<DayOfWeek> {DayOfWeek.Wednesday},
                        DrawTime = new TimeSpan(20, 45, 0),
                        Deadline = new TimeSpan(19, 00, 0)
                    },
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Főszámok",
                            NumbersToPick = 7,
                            TotalNumberRange = 35
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 7, OddsRatio = 1m/3362260m, ProjectedPrize = 210000000 },
                        new PrizeTier{ MainMatches = 6, OddsRatio = 1m/17155m, ProjectedPrize = 197830 },
                        new PrizeTier{ MainMatches = 5, OddsRatio = 1m/424m, ProjectedPrize = 6060 },
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/30m, ProjectedPrize = 2425 }
                    }
                },
                new Lottery
                {
                    Name = "Eurojackpot",
                    X = 923,
                    Y = 313,
                    TicketPrice = 860,
                    Schedule = new DrawSchedule
                    {
                        Days = new List<DayOfWeek> {DayOfWeek.Tuesday, DayOfWeek.Friday},
                        DrawTime = new TimeSpan(21, 00, 0),
                        Deadline = new TimeSpan(19, 00, 0)
                    },
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Főszámok",
                            NumbersToPick = 5,
                            TotalNumberRange = 50,
                        },
                        new NumberPool
                        {
                            Name = "Mellékszámok",
                            NumbersToPick = 2,
                            TotalNumberRange = 12
                        },
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 5, ExtraMatches = 2, OddsRatio = 1m/139838160m, ProjectedPrize = 16200000000 },
                        new PrizeTier{ MainMatches = 5, ExtraMatches = 1, OddsRatio = 1m/6991908m, ProjectedPrize = 732181883 },
                        new PrizeTier{ MainMatches = 5, ExtraMatches = 0, OddsRatio = 1m/3107515m, ProjectedPrize = 49124190 },
                        new PrizeTier{ MainMatches = 4, ExtraMatches = 2, OddsRatio = 1m/621503m, ProjectedPrize = 2278955 },
                        new PrizeTier{ MainMatches = 4, ExtraMatches = 1, OddsRatio = 1m/31075m, ProjectedPrize = 102855 },
                        new PrizeTier{ MainMatches = 3, ExtraMatches = 2, OddsRatio = 1m/14125m, ProjectedPrize = 66950 },
                        new PrizeTier{ MainMatches = 4, ExtraMatches = 0, OddsRatio = 1m/13811m, ProjectedPrize = 34355 },
                        new PrizeTier{ MainMatches = 2, ExtraMatches = 2, OddsRatio = 1m/985m, ProjectedPrize = 11910 },
                        new PrizeTier{ MainMatches = 3, ExtraMatches = 1, OddsRatio = 1m/706m, ProjectedPrize = 7010 },
                        new PrizeTier{ MainMatches = 3, ExtraMatches = 0, OddsRatio = 1m/314m, ProjectedPrize = 5975 },
                        new PrizeTier{ MainMatches = 1, ExtraMatches = 2, OddsRatio = 1m/188m, ProjectedPrize = 5975 },
                        new PrizeTier{ MainMatches = 2, ExtraMatches = 1, OddsRatio = 1m/49m, ProjectedPrize = 3870 },
                    }
                },
                new Lottery
                {
                    Name = "Joker",
                    X = 546,
                    Y = 545,
                    TicketPrice = 400,
                    Schedule = new DrawSchedule
                    {
                        Days = new List<DayOfWeek> {DayOfWeek.Saturday},
                        DrawTime = new TimeSpan(18, 45, 0),
                        Deadline = new TimeSpan(17, 30, 0)
                    },
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Főszámok",
                            NumbersToPick = 6,
                            TotalNumberRange = 60
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 6, OddsRatio = 1m/1000000m, ProjectedPrize = 30000000 },
                        new PrizeTier{ MainMatches = 5, OddsRatio = 1m/111111m, ProjectedPrize = 2500000 },
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/11111m, ProjectedPrize = 250000 },
                        new PrizeTier{ MainMatches = 3, OddsRatio = 1m/1111m, ProjectedPrize = 25000 },
                        new PrizeTier{ MainMatches = 2, OddsRatio = 1m/111m, ProjectedPrize = 2500 }
                    }
                }
            };
        }
    }
}