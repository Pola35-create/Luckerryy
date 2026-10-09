using System;
using System.Globalization;
using System.Linq;

namespace Luckerryy.Utils
{
    public static class LotteryUtils
    {
        public static decimal ParseJackpot(string jackpotText)
        {
            if (string.IsNullOrWhiteSpace(jackpotText))
                return 0m;

            var mainText = jackpotText.Split('(')[0];

            var numericText = new string(jackpotText
                .Where(c => char.IsDigit(c) || c == ',' || c == '.')
                .ToArray());

            numericText = numericText.Replace(',', '.');

            if (!decimal.TryParse(numericText, NumberStyles.Any, CultureInfo.InvariantCulture, out var number))
            {
                throw new FormatException($"Could not parse jackpot text: {jackpotText}");
            }

            if (mainText.Contains("milliárd", StringComparison.OrdinalIgnoreCase))
            {
                return number * 1_000_000_000m;
            }
            if (mainText.Contains("millió", StringComparison.OrdinalIgnoreCase))
            {
                return number * 1_000_000m;
            }

            return number;
        }
    }
}