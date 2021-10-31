using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject2.Tests
{
    public abstract class BaseTest
    {
        private IWebDriver driver;

        public IWebDriver Driver {
            get { return driver; }
        }

        [SetUp]
        public void Before() {

            this.driver = new ChromeDriver("c:\\app\\WebDriver");
            this.driver.Manage().Timeouts().ImplicitWait = new System.TimeSpan(0, 0, 5);
        }

        [TearDown]
        public void After() {
            if (driver != null) {
                driver.Close();
                driver.Quit();
            }
        }
    }
}
