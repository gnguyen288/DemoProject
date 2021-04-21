using Configuration.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium.Models.PageModels;
using Selenium.PageModels;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow.Features
{
    [Binding]
    public class TextBoxSteps: BasePage
    {
        private readonly Homepage homepage;
        private readonly ElementMenu elementmenu;
        private readonly TextBox textbox;
        private readonly bool _IsPageReady = false;

      
        public TextBoxSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            homepage = new Homepage(driver);
            elementmenu = new ElementMenu(driver);
            textbox = new TextBox(driver);
        }


        [Given(@"I navigate to ToolsQA demo site")]
        public void GivenINavigateToToolsQADemoSite()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.GetJsonConfig.DemoURL);
            //use wait for element to be visible - improvement
            _seleniumExtGeneral.Wait(_IsPageReady, 15);
        }
        
        [Given(@"I click on Element")]
        public void GivenIClickOnElement()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            homepage.Elements.Click();
        }
        

        [Given(@"I click on Text Box section")]
        public void GivenIClickOnTextBoxSection()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            elementmenu.TextBox.Click();
        }

        [Given(@"I fill in all fields '(.*)' in Full Name, '(.*)' in Email, '(.*)' in Current Address and '(.*)' in Permanent Address")]
        public void GivenIFillInAllFieldsInFullNameInEmailInCurrentAddressAndInPermanentAddress(string Name, string Email, string CAddress, string PAddress)
        {
            textbox.Name.SendKeys(Name);
            textbox.Email.SendKeys(Email);
            textbox.Address1.SendKeys(CAddress);
            textbox.Address2.SendKeys(PAddress);
        }


        [Given(@"I click Submit")]
        public void GivenIClickSubmit()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _seleniumExtGeneral.ScrollToElement(textbox.Submit);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", textbox.Submit);
            textbox.Submit.Click();
            Thread.Sleep(3000);
            
        }

        [Then(@"The Output box is displayed")]
        public void ThenTheOutputBoxIsDisplayed()
        {
            Assert.IsTrue(textbox.OuputBox.Displayed);
        }


    }
}
