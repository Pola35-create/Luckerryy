using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Luckerryy.Data;
using Luckerryy.Models;
using Luckerryy.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=================================================");
Console.WriteLine("   HUNGARIAN LOTTERY EXPECTED VALUE CALCULATOR   ");
Console.WriteLine("=================================================\n");

// 1. Setup HTTP Client & Services
using var httpClient = new HttpClient();
var scraper = new LotteryScraper(httpClient);
var lotteryService = new LotteryService(scraper);

Console.Write("Fetching live jackpot data from Szerencsejáték Zrt... ");
await lotteryService.RefreshDataAsync();
Console.WriteLine("Done!\n");

// 2. Retrieve lotteries from data source
List<Lottery> lotteries = LotteryData.GetLotteries();

// 3. Update live jackpots
foreach (var lottery in lotteries)
{
    decimal liveJackpot = lotteryService.GetJackpot(lottery.Name);
    lottery.UpdateJackpot(liveJackpot);
}

// 4. Output Games Ranked by Expected Value Ratio (Highest EV first)
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine($"{"Rank",-6} | {"Lottery",-16} | {"Price",-8} | {"Live Jackpot",-18} | {"Expected Return",-16} | {"EV %",-8}");
Console.WriteLine("----------------------------------------------------------------------------------");

int rank = 1;
foreach (var lottery in lotteries.OrderByDescending(r => r.EVPercentage))
{
    Console.WriteLine($"{rank,-6} | {lottery.Name,-16} | {lottery.TicketPrice + " Ft",-8} | {lottery.Jackpot,15:N0} Ft | {lottery.EV,13:N2} Ft | {lottery.EVPercentage,7:F2}%");
    rank++;
}

Console.WriteLine("----------------------------------------------------------------------------------\n");
Console.WriteLine($"Last refreshed: {lotteryService.LastUpdated:yyyy-MM-dd HH:mm:ss}\n");