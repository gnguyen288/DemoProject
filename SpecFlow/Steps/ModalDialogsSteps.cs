using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlow.Features
{
    [Binding]
    public class ModalDialogsSteps:BasePage
    {
        private readonly Homepage homepage;
        private readonly AlertMenu alertmenu;
        private readonly ModalDialogs md;
        private readonly bool _IsPageReady = false;
        

        public ModalDialogsSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            homepage = new Homepage(driver);
            alertmenu = new AlertMenu(driver);
            md = new ModalDialogs(driver);
        }

        [Given(@"I click on Alert menu item")]
        public void GivenIClickOnAlertMenuItem()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _seleniumExtGeneral.ScrollToElement(homepage.Alerts);
            homepage.Alerts.Click();
        }
        
        [Given(@"I click on Modal Dialogs")]
        public void GivenIClickOnModalDialogs()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            _seleniumExtGeneral.ScrollToElement(alertmenu.ModalDialogs);
            alertmenu.ModalDialogs.Click();
        }
        
        [Given(@"I choose Small modal")]
        public void GivenIChooseSmallModal()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            md.SmallModal.Click();
        }
        
        [Then(@"The text '(.*)' is shown and I close the popup")]
        public void ThenTheTextIsShownAndICloseThePopup(string p0)
        {
            string sample = md.InnerText.Text;
            Assert.IsTrue(p0 == sample);
            _seleniumExtGeneral.Wait(_IsPageReady, 2);
            md.CloseButton.Click();
        }
    }
}
