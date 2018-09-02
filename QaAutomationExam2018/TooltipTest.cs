using System.IO;
using System.Reflection;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QaAutomationExam2018.Pages.TooltipPage;

//Navigate to http://demoqa.com/, click on Tooltip and verify that
//after hover input field, there is tooltip shown
//Also verify that text in tooltip is: We ask for your age only for statistical purposes.

namespace QaAutomationExam2018
{
    [TestFixture]
    public class TooltipTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [TearDown]
        public void EndTest()
        {
            //take screenshot in case of test failure
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotLocation = Path.GetFullPath(@"..\..\..\Screenshots\");
                string testName = TestContext.CurrentContext.Test.Name;
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(screenshotLocation + testName + ".png", ScreenshotImageFormat.Png);
            }
            driver.Close();
        }

        [Test]
        public void VerifyTooltipShownTest()
        {
            var tooltipPage = new TooltipPage(driver);

            tooltipPage.NavigateTo();
            tooltipPage.VerifyTooltipShown();
              
            Assert.IsTrue(tooltipPage.HoverField.Text.Contains("We ask for your age only for statistical purposes."));
        }
    }
}
