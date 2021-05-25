using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
[TestFixture]
public class IETest { 

      private IWebDriver driver;
    [SetUp]
    public void SetupTest()
    {

        driver = new InternetExplorerDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        driver.Url = "https://code.visualstudio.com/";
    }
    [TearDown]
    public void TeardownTest()
    {
        driver.Quit();
    }
    [Test]
    public void testMethod()
    {
        String title = driver.Title;
        System.Console.WriteLine("title of site is : " + title);
        IWebElement button = driver.FindElement(By.XPath("//*[text()='Download for Windows']"));
        System.Console.WriteLine("button.text is: "+ button.Text);
        Assert.AreEqual("Download for Windows\r\nStable Build", button.Text);
    }
}