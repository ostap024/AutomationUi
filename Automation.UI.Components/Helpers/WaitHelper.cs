using OpenQA.Selenium.Support.UI;

namespace Automation.UI.Components.Helpers;

public class WaitHelper
{
    private static WebDriverWait? webDriverWait;

    private WaitHelper() { }

    public static WebDriverWait GetInstanse(TimeSpan timeSpan)
    {
        webDriverWait ??= new WebDriverWait(Driver.GetInstance(), timeSpan);

        return webDriverWait;
    }
}


