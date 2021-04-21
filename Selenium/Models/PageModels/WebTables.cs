using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class WebTables : BasePage
    {
        public WebTables(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement AddButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("addNewRecordButton"));
            }
        }

        public IWebElement FName
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("firstName"));
            }
        }

        public IWebElement LName
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("lastName"));
            }
        }

        public IWebElement Email
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("userEmail"));
            }
        }

        public IWebElement Age
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("age"));
            }
        }

        public IWebElement Salary
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("salary"));
            }
        }

        public IWebElement Department
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("department"));
            }
        }

        public IWebElement Submit
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("submit"));
            }
        }

        public IWebElement EditButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("edit-record-4"));
            }
        }
    }
}
