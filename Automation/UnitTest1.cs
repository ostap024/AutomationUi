using Automation.UI.Components.Helpers;
using Automation.UI.Components.Pages;

namespace Automation.UI.Tests;

public class UnitTest1
{
    [Fact]
    public void LoadDelayPage()
    {
        var homePage = new HomePage();
        homePage.LoadDelayLink.Click();
    }

    [Fact]
    public void ClientSideDelayPage()
    {
        var homePage = new HomePage();
        homePage.ClientSideDelayLink.Click();
        var clientSideDelayPage = new ClientSideDelayPage(); //тут би додати якийсь метод замість кнопки клік який би через дженерік повертав обʼєкт потрібної пейджі, щоб вручну не створювати
        clientSideDelayPage.ButtonTriggeringClientSideLogic.Click();
        //тут далі треба писати вейти нормальні, але мені лінь.
        //якщо це все буде переписуватись на плейврайт то нашо, там вже має це бути
    }
}
