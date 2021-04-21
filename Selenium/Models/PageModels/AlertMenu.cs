using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class AlertMenu : BasePage
    {
        public AlertMenu(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement ModalDialogs
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Modal Dialogs']"));
            }
        }
    }
}
