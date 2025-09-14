using System;
using System.Linq;

namespace Luckerryy.Utils
{
    public static class LotteryUtils
    {
        public static decimal ParseJackpot(string jackpotText)
        {
            var numericText = new string(jackpotText.Where(c => char.IsDigit(c)).ToArray());
            if (jackpotText.Contains("millió", StringComparison.OrdinalIgnoreCase))
            {
                return decimal.Parse(numericText) * 1_000_000;
            }
            if (jackpotText.Contains("milliárd", StringComparison.OrdinalIgnoreCase))
            {
                return decimal.Parse(numericText) * 100_000_000;
            }
            return decimal.Parse(numericText);
        }
        public static string FormatJackpot(decimal jackpot)
        {
            return string.Format("{0:N0} Ft", jackpot).Replace(",", " ");
        }
    }
}
