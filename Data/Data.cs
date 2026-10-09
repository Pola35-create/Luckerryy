using Luckerryy.Models;

namespace Luckerryy.Data
{
    public static class LotteryData
    {
        public static List<Lottery> GetLotteries()
        {
            return new List<Lottery>
            {
                new Lottery
                {
                    Name = "Otoslotto",
                    TicketPrice = 500,
                    TopTierOddsRatio = 1m/43949268m,
                    X = 170,
                    Y = 62,
                    
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Foszamok",
                            NumbersToPick = 5,
                            TotalNumberRange = 90
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/103410m, ProjectedPrize = 2651779 },
                        new PrizeTier{ MainMatches = 3, OddsRatio = 1m/1231m, ProjectedPrize = 31481 },
                        new PrizeTier{ MainMatches = 2, OddsRatio = 1m/44m, ProjectedPrize = 3944 }
                    }
                },
                new Lottery
                {
                    Name = "Hatoslotto",
                    X = 923,
                    Y = 62,
                    TicketPrice = 500,
                    TopTierOddsRatio = 1m/8145060m,
                    
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Foszamok",
                            NumbersToPick = 6,
                            TotalNumberRange = 45
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 5, OddsRatio = 1m/34808m, ProjectedPrize = 820439 },
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/733m, ProjectedPrize = 14056 },
                        new PrizeTier{ MainMatches = 3, OddsRatio = 1m/45m, ProjectedPrize = 3700 }
                    }
                },
                new Lottery
                {
                    Name = "Skandinavlotto",
                    X = 170,
                    Y = 313,
                    TicketPrice = 500,
                    TopTierOddsRatio = 1m/3362260m,
                    
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Foszamok",
                            NumbersToPick = 7,
                            TotalNumberRange = 35
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 6, OddsRatio = 1m/17155m, ProjectedPrize = 453482 },
                        new PrizeTier{ MainMatches = 5, OddsRatio = 1m/424m, ProjectedPrize = 9779 },
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/30m, ProjectedPrize = 2951 }
                    }
                },
                new Lottery
                {
                    Name = "Eurojackpot",
                    X = 923,
                    Y = 313,
                    TicketPrice = 760,
                    TopTierOddsRatio = 1m/139838160m,
                    
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Foszámok",
                            NumbersToPick = 5,
                            TotalNumberRange = 50,
                        },
                        new NumberPool
                        {
                            Name = "Mellekszamok",
                            NumbersToPick = 2,
                            TotalNumberRange = 12
                        },
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 5, ExtraMatches = 1, OddsRatio = 1m/6991908m, ProjectedPrize = 267940256 },
                        new PrizeTier{ MainMatches = 5, ExtraMatches = 0, OddsRatio = 1m/3107515m, ProjectedPrize = 56670540 },
                        new PrizeTier{ MainMatches = 4, ExtraMatches = 2, OddsRatio = 1m/621503m, ProjectedPrize = 1777670 },
                        new PrizeTier{ MainMatches = 4, ExtraMatches = 1, OddsRatio = 1m/31075m, ProjectedPrize = 111219 },
                        new PrizeTier{ MainMatches = 3, ExtraMatches = 2, OddsRatio = 1m/14125m, ProjectedPrize = 60998 },
                        new PrizeTier{ MainMatches = 4, ExtraMatches = 0, OddsRatio = 1m/13811m, ProjectedPrize = 40889 },
                        new PrizeTier{ MainMatches = 2, ExtraMatches = 2, OddsRatio = 1m/985m, ProjectedPrize = 10033 },
                        new PrizeTier{ MainMatches = 3, ExtraMatches = 1, OddsRatio = 1m/706m, ProjectedPrize = 7190 },
                        new PrizeTier{ MainMatches = 3, ExtraMatches = 0, OddsRatio = 1m/314m, ProjectedPrize = 6111 },
                        new PrizeTier{ MainMatches = 1, ExtraMatches = 2, OddsRatio = 1m/188m, ProjectedPrize = 5130 },
                        new PrizeTier{ MainMatches = 2, ExtraMatches = 1, OddsRatio = 1m/49m, ProjectedPrize = 3687 },
                    }
                },
                new Lottery
                {
                    Name = "Joker",
                    X = 546,
                    Y = 545,
                    TicketPrice = 500,
                    TopTierOddsRatio = 1m/1000000m,
                    
                    NumberPools = new List<NumberPool>
                    {
                        new NumberPool
                        {
                            Name = "Foszámok",
                            NumbersToPick = 6,
                            TotalNumberRange = 10
                        }
                    },
                    PrizeTiers = new List<PrizeTier>
                    {
                        new PrizeTier{ MainMatches = 5, OddsRatio = 1m/111111m, ProjectedPrize = 3000000 },
                        new PrizeTier{ MainMatches = 4, OddsRatio = 1m/11111m, ProjectedPrize = 300000 },
                        new PrizeTier{ MainMatches = 3, OddsRatio = 1m/1111m, ProjectedPrize = 30000 },
                        new PrizeTier{ MainMatches = 2, OddsRatio = 1m/111m, ProjectedPrize = 3000 }
                    }
                }
            };
        }
    }
}