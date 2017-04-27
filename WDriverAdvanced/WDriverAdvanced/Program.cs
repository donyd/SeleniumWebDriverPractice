using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using OpenQA.Selenium.Support.UI;

namespace WDriverAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver myDriver = new ChromeDriver();
            myDriver.Url = @"D:\My Files\OneDrive\Selenium\Webdriver\WDriverAdvanced\WDriverAdvanced\TestPage.html";

            // RADIOBUTTONS
            //var radioButtons = myDriver.FindElements(By.Name("color"));

            //foreach (var radioButton in radioButtons)
            //{
            //    if(radioButton.Selected)
            //        Console.WriteLine(radioButton.GetAttribute("value"));
            //}

            // CHECKBOX
            //var checkBox = myDriver.FindElement(By.Id("check1"));
            //checkBox.Click();
            //Thread.Sleep(2000);
            //checkBox.Click();


            // SELECT OPTIONS
            var select = myDriver.FindElement(By.Id("select1"));

            // General
            //var aOption = select.FindElements(By.TagName("option"))[3];
            //aOption.Click();

            // Using SelectElement
            var selectElement = new SelectElement(select);
            selectElement.SelectByText("Joe");






            // myDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // myDriver.FindElement(By.ClassName("gb_7c")).Click();
        }
    }
}
