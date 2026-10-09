using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Luckerryy.Services
{
    public class LotteryScraper
    {
        private readonly HttpClient _httpClient;

        public LotteryScraper(HttpClient httpClient)
        {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        if (!_httpClient.DefaultRequestHeaders.Contains("User-Agent"))
        {
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
        }
        }

        public async Task<string> ScrapeJackpotTextAsync(string gameEndpoint)
        {
            try
            {
                string url = $"https://bet.szerencsejatek.hu/jatekok/{gameEndpoint}";
                string html = await _httpClient.GetStringAsync(url);

                var doc = new HtmlDocument();
                doc.LoadHtml(html);

                // Selector target based on site structure
                var node = doc.DocumentNode.SelectSingleNode("//*[contains(@class, 'expected-price')]")
                           ?? doc.DocumentNode.SelectSingleNode("//meta[@property='og:description']");

                return node?.InnerText?.Trim() ?? string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Warning] Failed to scrape {gameEndpoint}: {ex.Message}");
                return string.Empty;
            }
        }
    }
}