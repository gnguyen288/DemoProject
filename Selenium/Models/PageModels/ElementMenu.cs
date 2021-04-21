using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class ElementMenu : BasePage
    {
        [Obsolete]
        public ElementMenu(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebElement TextBox
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Text Box']"));
            }
        }

        public IWebElement CheckBox
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Check Box']"));
            }
        }

        public IWebElement RadioButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Radio Button']"));
            }
        }

        public IWebElement WebTables
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Web Tables']"));
            }
        }

        public IWebElement Links
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Links']"));
            }
        }
    }
}
