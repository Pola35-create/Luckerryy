using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Luckerryy.Services
{
    public class LotteryScraper
    {
        public string ScrapeOtosLotto()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://bet.szerencsejatek.hu/jatekok/otoslotto");
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                var jackpotElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".expected-price")));
                return jackpotElement.Text;
            }
        }
    }
}
