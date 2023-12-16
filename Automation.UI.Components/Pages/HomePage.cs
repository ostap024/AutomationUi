using OpenQA.Selenium;

namespace Automation.UI.Components.Pages;

public class HomePage: BasePage
{
    public override string Url => "/";

    public IWebElement LoadDelayLink => Driver.GetInstance().FindElement(By.CssSelector("a[href=\"/loaddelay\"]"));
    public IWebElement ClientSideDelayLink => Driver.GetInstance().FindElement(By.CssSelector("a[href=\"/clientdelay\"]"));
}

