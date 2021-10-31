using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject2.Tests
{
     public class HelloWorldTests : BaseTest
    {
        [Test]
        public void MainTest()
        {
            IWebDriver driver = Driver;

            driver.Url = "https://www.demoqa.com/books";

            Driver.FindElement(By.XPath("//button[@id='login']")).Click();

            driver.FindElement(By.Id("userName")).SendKeys("testuser_1");

            driver.FindElement(By.Id("password")).SendKeys("Test@123");

            driver.FindElement(By.Id("login")).Click();

            IWebElement buttonLogOut = driver.FindElement(By.XPath("//button[@id='submit' and text()='Log out']"));
            Assert.AreEqual("Log out", buttonLogOut.Text);
        }
    }
}