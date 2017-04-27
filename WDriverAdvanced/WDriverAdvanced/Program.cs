using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDriverAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver myDriver = new FirefoxDriver();
            myDriver.Url = "file:///C:/Users/ddsilva/OneDrive/Selenium/Webdriver/WDriverAdvanced/WDriverAdvanced/TestPage.html";

            var radiodButton = myDriver.FindElements(By.Name("color"))[1];
            radiodButton.Click();

            // myDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // myDriver.FindElement(By.ClassName("gb_7c")).Click();
        }
    }
}
