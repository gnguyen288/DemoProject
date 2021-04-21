using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
   public class Link:BasePage
    {
        public Link(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement Home
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("simpleLink"));
            }
        }
    }
}
