using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Westpac_Assessment.Helpers.Drivers;

namespace Westpac_Assessment.Base
{
    class BaseClass { 
        // Initializing Path variables
        public string BaseUrl = "https://buggy.justtestit.org/";

        //Browser Initialization
        public void Initialize()
        {
            //initialize browser
            InitializeBrowser();
            driver.Navigate().GoToUrl(BaseUrl);
        }

}
}
