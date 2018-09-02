using System.IO;
using System.Reflection;
using QaAutomationExam2018.Pages.BlogPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Navigate to https://www.automatetheplanet.com/, select Blog
//and verify that every every link in Quick Navigation scroll to section
//in the article with the same name

namespace QaAutomationExam2018
{
    [TestFixture]
    public class AutomateThePlanetTest
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
        public void ScrollToQuickNavigation()
        {
            var blogPage = new BlogPage(driver);
            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            Assert.IsTrue(blogPage.QuickNavigation.Text.Contains("QUICK NAVIGATION"));

        }

        [Test]
        public void ValidateTestCaseLink()
        {
            var blogPage = new BlogPage(driver);

            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            blogPage.ClickFirstLink();

            Assert.IsTrue(blogPage.TestCaseHeader.Text.Contains("Test Case"));
        }

        [Test]
        public void ValidateHeadlessExecutionFirefoxDriverLink()
        {
            var blogPage = new BlogPage(driver);

            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            blogPage.ClickSecondLink();

            Assert.IsTrue(blogPage.HeadlessExecutionFirefoxDriverHeader.Text.Contains("Headless Execution Firefox Driver"));
        }

        [Test]
        public void ValidateBenchmarkAgainstOtherBrowsersLink()
        {
            var blogPage = new BlogPage(driver);

            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            blogPage.ClickThirdLink();

            Assert.IsTrue(blogPage.BenchmarkAgainstOtherBrowsersHeader.Text.Contains("Benchmark against Other Browsers"));
        }

        [Test]
        public void ValidateTestCaseCodeLink()
        {
            var blogPage = new BlogPage(driver);

            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            blogPage.ClickFourthLink();

            Assert.IsTrue(blogPage.TestCaseCodeHeader.Text.Contains("Test Case"));
        }

        [Test]
        public void ValidateBenchmarkExecutionTimeLink()
        {
            var blogPage = new BlogPage(driver);

            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            blogPage.ClickFifthLink();

            Assert.IsTrue(blogPage.BenchmarkExecutionTimeHeader.Text.Contains("Benchmark Execution Time"));
        }

        [Test]
        public void ValidateBenchmarkTestsLink()
        {
            var blogPage = new BlogPage(driver);

            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            blogPage.ClickSixthLink();

            Assert.IsTrue(blogPage.BenchmarkTestsHeader.Text.Contains("Benchmark Tests"));
        }

        [Test]
        public void ValidateBenchmarkResultsLink()
        {
            var blogPage = new BlogPage(driver);

            blogPage.NavigateTo();
            blogPage.GoToBlog();
            blogPage.ScrollDown();
            blogPage.ClickSeventhLink();

            Assert.IsTrue(blogPage.BenchmarkResultsHeader.Text.Contains("Benchmark Results"));
        }
    }
}
