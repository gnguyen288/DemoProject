using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class WidgetsMenu:BasePage
    {
        public WidgetsMenu(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement DatePicker
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Date Picker']"));
            }
        }

        public IWebElement ProgressBar
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Progress Bar']"));
            }
        }

        public IWebElement SelectMenu
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Select Menu']"));
            }
        }
    }
}
