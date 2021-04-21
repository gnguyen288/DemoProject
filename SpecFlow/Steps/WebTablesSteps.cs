using OpenQA.Selenium;
using NUnit.Framework;
using Selenium.PageModels;
using Selenium.Models.PageModels;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Features
{
    [Binding]
    public class WebTablesSteps : BasePage

    {

        private readonly WebTables webtables;
        private readonly ElementMenu elementmenu;

        public WebTablesSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            webtables = new WebTables(driver);
            elementmenu = new ElementMenu(driver);
        }


        [Given(@"I click on Web Tables section")]
        public void GivenIClickOnWebTablesSection()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", elementmenu.WebTables);
            elementmenu.WebTables.Click();
        }

        [Given(@"I click Add button")]
        public void GivenIClickAddButton()
        {
            webtables.AddButton.Click();
        }


        [Given(@"I fill in '(.*)' as First Name, '(.*)' as Last Name, '(.*)' as Email, '(.*)' as Age, '(.*)' as Salary, '(.*)' as Department")]
        public void GivenIFillInAsFirstNameAsLastNameAsEmailAsAgeAsSalaryAsDepartment(string FName, string LName, string Email, string Age, string Salary, string Department)
        {
            webtables.FName.SendKeys(FName);
            webtables.LName.SendKeys(LName);
            webtables.Email.SendKeys(Email);
            webtables.Age.SendKeys(Age);
            webtables.Salary.SendKeys(Salary);
            webtables.Department.SendKeys(Department);

        }

        [Given(@"I click Submit on page")]
        public void GivenIClickSubmitOnPage()
        {
            webtables.Submit.Click();
        }


        [Then(@"I should see the new record added")]
        public void ThenIShouldSeeTheNewRecordAdded()
        {
            Assert.IsTrue(webtables.EditButton.Displayed);
        }
    }
}
