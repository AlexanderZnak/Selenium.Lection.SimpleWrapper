using Selenium.Lection.SimpleWrapper.Core;

namespace Selenium.Lection._SimpleWrapper.Tests;

public abstract class BasePage : Page
{
    protected BasePage(BaseElement uniqueElement, string pageName) : base(uniqueElement, pageName)
    {
    }
}