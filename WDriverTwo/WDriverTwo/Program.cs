﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WDriverTwo
{
    class Program
    {
        static void Main(string[] args)
        {



            // Internet Explorer
            //IWebDriver driver = new InternetExplorerDriver(@"C:\libraries");


            /*
             * Chrome trial : Does not work
             */
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:\\Libraries\\chromedriver.exe");
            //ChromeOptions options = new ChromeOptions();
            //options.BinaryLocation = "C:\\Libraries\\chromedriver.exe";
            //options.AddArgument("--test-type");
            //IWebDriver driver = new ChromeDriver(@"C:\Libraries", options);



            /*
             * Two types of wait conditions were used, the one with try/catch is the one generated by the Selenium IDE and the "driver.Manage()..." [line 65], version is manual entry.
             * In order to be able to click the image within Google's Image search, the Image link had to clicked twice [see lines 67 and 93] each with its own time delay, see previous paragraph.
             * It was once this redundant procedure was conducted that the first image result can be clicked on.
             */


            // Firefox default driver
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";

           var searchField = driver.FindElement(By.Id("lst-ib"));

            

            searchField.SendKeys("pluralsight");

            // To retrieve a list of results, otherwise google ajax will go into auto-complete
            // mode and render all other page elements null.
            driver.FindElement(By.Id("_fZl")).Click();

          // waitForVisible | css=a.q.qs utilising wait logic from Selenium IDE code export
            //for (int second = 0; ; second++)
            //{
            //    if (second >= 60)
            //    {
            //        Assert.Fail("timeout");
            //    }
            //    try
            //    {
            //        if (driver.FindElement(By.CssSelector("a.q.qs")).Displayed) break;
            //    }
            //    catch (Exception)
            //    { }
            //    Thread.Sleep(1000);
            //}



            // var imagesLink = driver.FindElement(By.CssSelector("div[class='q qs']"));
                        
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            //driver.FindElement(By.CssSelector("a.q.qs")).Click();
            driver.FindElements(By.ClassName("qs"))[0].Click();


            //var someImage = driver.FindElement(By.ClassName("rg_i"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //var firstImageLink = someImage.FindElements(By.TagName("a"))[0];
            //firstImageLink.Click();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //driver.FindElement(By.Name("rbc9XlfmBObC6M:")).Click();


            //for (int second = 0; ; second++)
            //{
            //    if (second >= 60) Assert.Fail("timeout");
            //    try
            //    {
            //        if (driver.FindElement(By.CssSelector("a.q.qs")).Displayed) break;
            //    }
            //    catch (Exception)
            //    { }
            //    Thread.Sleep(1000);
            //}
            //// second session to find the same image
            //// click | css=a.q.qs | 
            //driver.FindElement(By.CssSelector("a.q.qs")).Click();

            
            // click | name=rbc9XlfmBObC6M: | 
            driver.FindElement(By.Name("rbc9XlfmBObC6M:")).Click();

            


        }
    }
}
