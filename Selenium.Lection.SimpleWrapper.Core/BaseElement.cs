using OpenQA.Selenium;

namespace Selenium.Lection.SimpleWrapper.Core;

public abstract class BaseElement
{
    protected By Locator { get; }

    protected string Name { get; }

    protected BaseElement(By locator, string name)
    {
        this.Locator = locator;
        Name = name;
    }

    private WebDriver WebDriver
    {
        get { return BrowserService.Browser.WebDriver; }
    }

    public void Click()
    {
        throw new NotImplementedException();
    }

    public string GetText()
    {
        return FindElement().Text;
    }

    public bool IsDisplayed()
    {
        return FindElement().Displayed;
    }

    protected IWebElement FindElement()
    {
        return WebDriver.FindElement(Locator);
    }
}