using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        public void Initialize()
        {
            IWebdriver driver = new ChromeDriver();
        }

        public static void UseWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Close()
        {
            driver.Quit();
        }
    }
}



