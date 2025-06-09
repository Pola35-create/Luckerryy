public static class MockData
{
    public static List<Lottery> GetLotteries()
    {
        return new List<Lottery>
        {
            new Lottery
            {
                Name = "Ötöslottó",
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
                        NumbersToPick = 5,
                        TotalNumberRange = 90
                    }
                },
                PrizeTiers = new List<PrizeTier>
                {
                    new PrizeTier{ MainMatches = 5, OddsRatio = 1/43949268, ProjectedPrize = 2966000000 },
                    new PrizeTier{ MainMatches = 4, OddsRatio = 1/103410, ProjectedPrize = 1376935 },
                    new PrizeTier{ MainMatches = 3, OddsRatio = 1/1231, ProjectedPrize = 15845 },
                    new PrizeTier{ MainMatches = 2, OddsRatio = 1/44, ProjectedPrize = 2460 }
                }
            },
            new Lottery
            {
                Name = "Hatoslottó",
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
                    new PrizeTier{ MainMatches = 6, OddsRatio = 1/8145060, ProjectedPrize = 221000000 },
                    new PrizeTier{ MainMatches = 5, OddsRatio = 1/34808, ProjectedPrize = 237300 },
                    new PrizeTier{ MainMatches = 4, OddsRatio = 1/733, ProjectedPrize = 6220 },
                    new PrizeTier{ MainMatches = 3, OddsRatio = 1/45, ProjectedPrize = 2705 }
                }
            },
            new Lottery
            {
                Name = "Skandinávlottó",
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
                    new PrizeTier{ MainMatches = 7, OddsRatio = 1/3362260, ProjectedPrize = 70000000 },
                    new PrizeTier{ MainMatches = 6, OddsRatio = 1/17155, ProjectedPrize = 197830 },
                    new PrizeTier{ MainMatches = 5, OddsRatio = 1/424, ProjectedPrize = 6060 },
                    new PrizeTier{ MainMatches = 4, OddsRatio = 1/30, ProjectedPrize = 2425 }
                }
            },
            new Lottery
            {
                Name = "Eurojackpot",
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
                    new PrizeTier{ MainMatches = 5, ExtraMatches = 2, OddsRatio = 1/139838160, ProjectedPrize = 8800000000 },
                    new PrizeTier{ MainMatches = 5, ExtraMatches = 1, OddsRatio = 1/6991908, ProjectedPrize = 732181883 },
                    new PrizeTier{ MainMatches = 5, ExtraMatches = 0, OddsRatio = 1/3107515, ProjectedPrize = 49124190 },
                    new PrizeTier{ MainMatches = 4, ExtraMatches = 2, OddsRatio = 1/621503, ProjectedPrize = 2278955 },
                    new PrizeTier{ MainMatches = 4, ExtraMatches = 1, OddsRatio = 1/31075, ProjectedPrize = 102855 },
                    new PrizeTier{ MainMatches = 3, ExtraMatches = 2, OddsRatio = 1/14125, ProjectedPrize = 66950 },
                    new PrizeTier{ MainMatches = 4, ExtraMatches = 0, OddsRatio = 1/13811, ProjectedPrize = 34355 },
                    new PrizeTier{ MainMatches = 2, ExtraMatches = 2, OddsRatio = 1/985, ProjectedPrize = 11910 },
                    new PrizeTier{ MainMatches = 3, ExtraMatches = 1, OddsRatio = 1/706, ProjectedPrize = 7010 },
                    new PrizeTier{ MainMatches = 3, ExtraMatches = 0, OddsRatio = 1/314, ProjectedPrize = 5975 },
                    new PrizeTier{ MainMatches = 1, ExtraMatches = 2, OddsRatio = 1/188, ProjectedPrize = 5975 },
                    new PrizeTier{ MainMatches = 2, ExtraMatches = 1, OddsRatio = 1/49, ProjectedPrize = 3870 },
                }
            },
            new Lottery
            {
                Name = "Joker",
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
                    new PrizeTier{ MainMatches = 6, OddsRatio = 1/1000000, ProjectedPrize = 72000000 },
                    new PrizeTier{ MainMatches = 5, OddsRatio = 1/111111, ProjectedPrize = 2500000 },
                    new PrizeTier{ MainMatches = 4, OddsRatio = 1/11111, ProjectedPrize = 250000 },
                    new PrizeTier{ MainMatches = 3, OddsRatio = 1/1111, ProjectedPrize = 25000 },
                    new PrizeTier{ MainMatches = 2, OddsRatio = 1/111, ProjectedPrize = 2500 }
                }
            }
        };
    }
}