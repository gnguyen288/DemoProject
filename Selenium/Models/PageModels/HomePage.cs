using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{

    public class Homepage : BasePage
    {


        public Homepage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebElement Elements
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Elements']"));
            }
        }

        public IWebElement Forms
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Forms']"));
            }
        }


        public IWebElement Alerts
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Alerts, Frame & Windows']"));
            }
        }

        public IWebElement Widgets
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Widgets']"));
            }
        }

        public IWebElement BookStore
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Book Store Application']"));
            }
        }

    }
}
