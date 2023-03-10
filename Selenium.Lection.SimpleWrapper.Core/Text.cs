using OpenQA.Selenium;

namespace Selenium.Lection.SimpleWrapper.Core;

public class Text : BaseElement
{
    public Text(By locator, string name) : base(locator, name)
    {
    }

    public void Input(string text)
    {
        FindElement().SendKeys(text);
    }

    public string GetValue()
    {
        return FindElement().GetAttribute("value");
    }
}