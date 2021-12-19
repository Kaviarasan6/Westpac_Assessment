using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westpac_Assessment.Helpers
{
    class Drivers
    {
        // Initialize the browser
        public static IWebDriver driver { get; set; }


        public static void InitializeBrowser()
        {
            // Defining the browser
            driver = new ChromeDriver();

            // Maximise the window
            driver.Manage().Window.Maximize();
        }

        // Closing Browser
        public static void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
