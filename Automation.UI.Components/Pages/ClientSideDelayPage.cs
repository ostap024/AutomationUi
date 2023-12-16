using OpenQA.Selenium;

namespace Automation.UI.Components.Pages;

public class ClientSideDelayPage : BasePage
{
    public override string Url => "/clientd1elay";

    public IWebElement ButtonTriggeringClientSideLogic => Driver.GetInstance().FindElement(By.CssSelector(".btn-primary"));
    public IWebElement Spinner => Driver.GetInstance().FindElement(By.Id("spinner"));
}

