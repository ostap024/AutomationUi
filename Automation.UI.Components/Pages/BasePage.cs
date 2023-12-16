using OpenQA.Selenium.Support.UI;

namespace Automation.UI.Components.Pages;

public abstract class BasePage
{
    public abstract string Url { get; }

    public BasePage()
    {
        var wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromSeconds(10));
        wait.Until(driver => driver.Url.Contains(Url));
    }
}
