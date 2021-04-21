using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageModels
{
    class RadioButton : BasePage
    {
        public RadioButton(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement Impressive
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//label[@for='impressiveRadio']"));
            }
        }

        public IWebElement Yes
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//label[@for='yesRadio']"));
            }
        }
    }
}
