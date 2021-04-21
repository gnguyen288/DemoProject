using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageModels
{
    public class TextBox : BasePage
    {
        [Obsolete]
        public TextBox(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement Name
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("userName"));
            }
        }

        public IWebElement Email
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("userEmail"));
            }
        }

        public IWebElement Address1
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("currentAddress"));
            }
        }

        public IWebElement Address2
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("permanentAddress"));
            }
        }

        public IWebElement Submit
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("submit"));
            }
        }

        public IWebElement OuputBox
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("output"));
            }
        }




        //public void FillIn( string FName, string FEmail, string FAddress1, string FAddress2)
        //  {
        //      Name.SendKeys(FName);
        //      Email.SendKeys(FEmail);
        //      Address1.SendKeys(FAddress1);
        //      Address2.SendKeys(FAddress2);
        //      Submit.Click();
        //  }

    }
}
