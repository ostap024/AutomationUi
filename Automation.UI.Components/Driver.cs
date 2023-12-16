using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.UI.Components
{
    public class Driver
    {
        [ThreadStatic]
        private static WebDriver? driver;

        private Driver() { }

        public static WebDriver GetInstance()
        {
            driver ??= new ChromeDriver()
            {
                Url = "http://uitestingplayground.com/"
            };
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}

