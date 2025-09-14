using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Luckerryy.Services
{
    public class LotteryScraper
    {
        private ChromeDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");

            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            return new ChromeDriver(service, options);
        }
        public string ScrapeOtosLotto()
        {
            using var driver = CreateDriver();
            driver.Navigate().GoToUrl("https://bet.szerencsejatek.hu/jatekok/otoslotto");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var jackpotElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".expected-price")));
            return jackpotElement.Text;

        }
        public string ScrapeHatosLotto()
        {
            using var driver = CreateDriver();
            driver.Navigate().GoToUrl("https://bet.szerencsejatek.hu/jatekok/hatoslotto");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var jackpotElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".expected-price")));
            return jackpotElement.Text;
        }
        public string ScrapeSkandiLotto()
        {
            using var driver = CreateDriver();
            driver.Navigate().GoToUrl("https://bet.szerencsejatek.hu/jatekok/skandinavlotto");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var jackpotElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".expected-price")));
            return jackpotElement.Text;
        }
        public string ScrapeEurojackpot()
        {
            using var driver = CreateDriver();
            driver.Navigate().GoToUrl("https://bet.szerencsejatek.hu/jatekok/eurojackpot");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var jackpotElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".expected-price h3")));
            return jackpotElement.Text;
        }
        public string ScrapeJoker()
        {
            using var driver = CreateDriver();
            driver.Navigate().GoToUrl("https://bet.szerencsejatek.hu/jatekok/joker");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var jackpotElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".expected-price")));
            return jackpotElement.Text;
        }
    }
}
