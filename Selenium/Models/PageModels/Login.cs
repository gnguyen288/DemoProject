using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    class Login:BasePage
    {
        public Login(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement NewUserButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("newUser"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("login"));
            }
        }

        public IWebElement UserName
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("userName"));
            }
        }


        public IWebElement Password
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("password"));
            }
        }

        public IWebElement FirstName
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("firstname"));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("lastname"));
            }
        }

        public IWebElement RegisterButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("register"));
            }
        }

        public IWebElement BackToLoginButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("gotologin"));
            }
        }

        public IWebElement CaptchaFrame
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/div[1]/form/div[6]/div/div/div/iframe"));
            }
        }

        public void CaptchaClick()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", CaptchaFrame);
            driver.SwitchTo().Frame(CaptchaFrame);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("span#recaptcha-anchor")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().ParentFrame();
        }

    }
}
