using QaAutomationExam2018.Pages;
using OpenQA.Selenium;

namespace QaAutomationExam2018.Pages.DatePickerPage
{
    public partial class DatePickerPage : BasePage
    {
        public DatePickerPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        public void GoToSelectDatePage()
        {
            DatePickerTab.Click();
            FormatDateTab.Click();
        }

        public void SelectDesiredDate()
        {
            DatePickerField.Click();
            for (int i = 0; i <= 5; i++)
            {
                Driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/div/a[1]/span")).Click();
            }
            SelectMarchFirst.Click();
        }
        
        public void VerifyDefaultDateFormat()
        {
            
            DateFormatSelect.SelectByText("Default – mm/dd/yy");
        }

        public void VerifyISO8601DateFormat()
        {
            DateFormatSelect.SelectByText("ISO 8601 – yy-mm-dd");
        }

        public void VerifyShortDateFormat()
        {
            DateFormatSelect.SelectByText("Short – d M, y");
        }

        public void VerifyMediumDateFormat()
        {
            DateFormatSelect.SelectByText("Medium – d MM, y");
        }

        public void VerifyFullDateFormat()
        {
            DateFormatSelect.SelectByText("Full – DD, d MM, yy");
        }

        public void VerifyTextDateFormat()
        {
            DateFormatSelect.SelectByText("With text – ‘day’ d ‘of’ MM ‘in the year’ yy");
        }
    }
}
