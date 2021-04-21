using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
   public class ModalDialogs: BasePage
    {
        public ModalDialogs(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement SmallModal
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("showSmallModal"));
            }
        }

        public IWebElement LargeModal
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("showLargeModal"));
            }
        }

        public IWebElement InnerText
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div.modal-body"));
            }
        }

        public IWebElement CloseButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("closeSmallModal"));
            }
        }
    }
}
