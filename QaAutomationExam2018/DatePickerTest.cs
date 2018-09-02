using System.IO;
using System.Reflection;
using QaAutomationExam2018.Pages.DatePickerPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//1. Navigate to http://demoqa.com/
//2. Click on Date Picker
//3. Click on Format date
//4. Select 01.3.2018 for date
//5. Verify all formats change value in date to right value
    //- March 1, 2018
    //- 2018-03-01
    //- 1 Mar, 18
    //- 1 March, 18
    //- Thursday, 1 March, 2018
    //- Day 1 of March in the year 2018

namespace QaAutomationExam2018
{
    [TestFixture]
    public class DatePickerTest
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
            //driver.Close();
        }

        [Test]
        public void DefaultDateFormatTest()
        {
            var datePickerPage = new DatePickerPage(driver);

            datePickerPage.NavigateTo();
            datePickerPage.GoToSelectDatePage();
            datePickerPage.SelectDesiredDate();
            datePickerPage.VerifyISO8601DateFormat();
            datePickerPage.VerifyDefaultDateFormat();

            Assert.AreEqual(datePickerPage.DatePickerField.GetAttribute("value"), "03/01/2018");
        }

        [Test]
        public void ISO8601DateFormatTest()
        {
            var datePickerPage = new DatePickerPage(driver);

            datePickerPage.NavigateTo();
            datePickerPage.GoToSelectDatePage();
            datePickerPage.SelectDesiredDate();
            datePickerPage.VerifyISO8601DateFormat();

            Assert.AreEqual(datePickerPage.DatePickerField.GetAttribute("value"), "2018-03-01");
        }

        [Test]
        public void ShortDateFormatTest()
        {
            var datePickerPage = new DatePickerPage(driver);

            datePickerPage.NavigateTo();
            datePickerPage.GoToSelectDatePage();
            datePickerPage.SelectDesiredDate();
            datePickerPage.VerifyShortDateFormat();

            Assert.AreEqual(datePickerPage.DatePickerField.GetAttribute("value"), "1 Mar, 18");
        }

        [Test]
        public void MediumDateFormatTest()
        {
            var datePickerPage = new DatePickerPage(driver);

            datePickerPage.NavigateTo();
            datePickerPage.GoToSelectDatePage();
            datePickerPage.SelectDesiredDate();
            datePickerPage.VerifyMediumDateFormat();

            Assert.AreEqual(datePickerPage.DatePickerField.GetAttribute("value"), "1 March, 18");
        }

        [Test]
        public void FullDateFormatTest()
        {
            var datePickerPage = new DatePickerPage(driver);

            datePickerPage.NavigateTo();
            datePickerPage.GoToSelectDatePage();
            datePickerPage.SelectDesiredDate();
            datePickerPage.VerifyFullDateFormat();

            Assert.AreEqual(datePickerPage.DatePickerField.GetAttribute("value"), "Thursday, 1 March, 2018");
        }

        [Test]
        public void TextDateFormatTest()
        {
            var datePickerPage = new DatePickerPage(driver);

            datePickerPage.NavigateTo();
            datePickerPage.GoToSelectDatePage();
            datePickerPage.SelectDesiredDate();
            datePickerPage.VerifyTextDateFormat();

            Assert.AreEqual(datePickerPage.DatePickerField.GetAttribute("value"), "day 1 of March in the year 2018");
        }
    }
}
