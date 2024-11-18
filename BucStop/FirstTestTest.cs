// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void FirstTest() {
    driver.Navigate().GoToUrl("https://localhost:7182/");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.CssSelector(".carousel-control-next-icon")).Click();
    driver.FindElement(By.CssSelector(".carousel-control-next-icon")).Click();
    driver.FindElement(By.CssSelector(".carousel-control-next-icon")).Click();
    driver.FindElement(By.LinkText("Games")).Click();
    driver.FindElement(By.CssSelector(".col-sm-4:nth-child(1) .overlay")).Click();
    driver.FindElement(By.CssSelector("img")).Click();
  }
}
