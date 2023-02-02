using OpenQA.Selenium;
using Selenium.Lection.SimpleWrapper.Core;

namespace Selenium.Lection._SimpleWrapper.Tests;

public class Tests
{
    private Browser Browser => BrowserService.Browser;
    
    [SetUp]
    public void Setup()
    {
    }

    [TearDown]
    public void TearDown()
    {
        Browser.Quit();
    }

    [Test]
    public void Test1()
    {
        // go to google.com
        var googleUrl = "https://www.google.com/";
        Browser.GoToUrl(googleUrl);
        
        // search smth
        Text googleSearchInput = new Text(By.CssSelector("[name=\"q\"]"), "Google Search Input");
        var searchText = "Hello world";
        googleSearchInput.Input(searchText);
        
        // assertion
        var getSearchedText = googleSearchInput.GetValue();
        
        Assert.AreEqual(searchText, getSearchedText);
    }
    
    [Test]
    public void Test2()
    {
        // go to google.com
        var googleUrl = "https://www.google.com/";
        Browser.GoToUrl(googleUrl);
        
        // search smth
        Text googleSearchInput = new Text(By.CssSelector("[name=\"q\"]"), "Google Search Input");
        var searchText = "Hello world";
        googleSearchInput.Input(searchText);
        
        // assertion
        var getSearchedText = googleSearchInput.GetValue();
        
        Assert.AreEqual(searchText, getSearchedText);
    }
}