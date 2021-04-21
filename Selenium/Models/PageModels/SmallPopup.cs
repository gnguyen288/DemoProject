using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class SmallPopup:BasePage
    {
        public SmallPopup(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement Close
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("closeSmallModal"));
            }
        }

        public IWebElement Body
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.modal-body"));
            }
        }
    }
}
