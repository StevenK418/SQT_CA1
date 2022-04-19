using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new Chromedriver instance
            IWebDriver driver = new ChromeDriver("drivers");

            //Test driver by opening a url
            driver.Url = "https://www.geeksforgeeks.org/";
        }
    }
}
