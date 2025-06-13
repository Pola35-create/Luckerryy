namespace Luckerryy.Models
{
    public class DrawSchedule
    {
        public List<DayOfWeek> Days { get; set; } = new();
        public TimeSpan DrawTime { get; set; }
        public TimeSpan Deadline { get; set; }
        public DateTime NextDeadline => NextDraw.Date + Deadline;
        public TimeSpan TimeUntilDeadline => NextDeadline - DateTime.Now;
        public DateTime NextDraw => CalculateNextDraw();

        private DateTime CalculateNextDraw()
        {
            var now = DateTime.Now;
            var upcomingDays = Days
                .Select(day =>
                {
                    var next = now.Date.AddDays(((int)day - (int)now.DayOfWeek + 7) % 7);
                    return next + DrawTime;
                })
                .Where(dt => dt > now)
                .OrderBy(dt => dt);

            return upcomingDays.FirstOrDefault();
        }
    }
}