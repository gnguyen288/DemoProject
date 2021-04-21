using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlow.Features
{
    [Binding]
    public class LinkSteps:BasePage
    {
        private readonly ElementMenu elementmenu;
        private readonly Link link;
        private readonly bool _IsPageReady = false;

        public LinkSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            link = new Link(driver);
            elementmenu = new ElementMenu(driver);
        }


        [Given(@"I click on Links section")]
        public void GivenIClickOnLinksSection()
        {
            _seleniumExtGeneral.ScrollToElement(elementmenu.Links);
            elementmenu.Links.Click();
        }

        [Given(@"I click on Home")]
        public void GivenIClickOnHome()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            link.Home.Click();
        }
        
        [Then(@"I should see a new tab opened")]
        public void ThenIShouldSeeANewTabOpened()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 8);
            string newwindow = driver.WindowHandles.Last();
            var win2 = driver.SwitchTo().Window(newwindow);
            Assert.IsTrue(win2.FindElement(By.XPath("//a[@href='https://www.toolsqa.com/selenium-training/']")).Displayed);

        }
    }
}
