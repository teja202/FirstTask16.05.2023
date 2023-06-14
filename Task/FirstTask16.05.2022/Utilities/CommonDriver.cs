using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Utilities
{
    public class Commondriver
    {
        public static IWebDriver driver;

        public static IWebDriver Driver { get => driver; set => driver = value; }

        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        public static void UseWait()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public void Close()
        {
            Driver.Quit();
        }
    }
}





