using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow.Hooks
{
    [Binding]
    public sealed class ScenarioHooks
    {
        private readonly IObjectContainer _container;
        private readonly ScenarioContext _context;
        private IWebDriver driver;

        public ScenarioHooks(ScenarioContext injectedContext, IObjectContainer container)
        {
            _container = container;
            this._context = injectedContext;
        }

        [BeforeScenario]
        public void GivenIHaveNavigatedToMyTestSite()
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            driver = new Selenium.Selenium.Browserfactory.Browsers().GetBrowser();
            driver.Manage().Window.Maximize();
            _container.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void IShutdownMyBrowser()
        {
            driver.Close();
            driver.Quit();
            _container.Dispose();
        }
    }
}
