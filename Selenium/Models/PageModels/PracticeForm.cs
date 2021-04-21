using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
   public class PracticeForm: BasePage
    {
        public PracticeForm(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement FirstName
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("firstName"));
            }
        }

        public IWebElement LastName
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


        public IWebElement Mobile
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("userNumber"));
            }
        }

        public IWebElement DOB
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("dateOfBirth"));
            }
        }

        public IWebElement Subject
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("subjectsContainer"));
            }
        }

        public IWebElement CurrentAddress
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("currentAddress"));
            }
        }

        public IWebElement Submit
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("submit"));
            }
        }

        public IWebElement Gender
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Name("gender"));
            }
        }

        public IWebElement State
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Name("state"));
            }
        }

        public IWebElement City
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Name("city"));
            }
        }

        public void FillIn(string FName, string LName, string Em, string Gen, string Mob, string Birth, string Subjects, string Hobbies, string CAddress, string State, string City)
        {
            FirstName.SendKeys(FName);
            LastName.SendKeys(LName);
            Email.SendKeys(Em);
            Gender.SendKeys(Gen);
            Mobile.SendKeys(Mob);
            DOB.SendKeys(Birth);
            CurrentAddress.SendKeys(CAddress);
            
        }

    }
}
