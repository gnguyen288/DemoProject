using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    class BooksStoreApp:BasePage
    {
        public BooksStoreApp(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement SelectValue
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Login']"));
            }
        }
    }
}
