using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QaAutomationExam2018.Pages.DatePickerPage
{
    public partial class DatePickerPage
    {
        public IWebElement DatePickerTab => Driver.FindElement(By.XPath("//*[@id=\"menu-item-146\"]/a"));

        public IWebElement FormatDateTab => Driver.FindElement(By.Id("ui-id-4"));

        public IWebElement DatePickerField => Driver.FindElement(By.Id("datepicker4"));

        public IWebElement SelectMarchFirst =>
            Driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/table/tbody/tr[1]/td[4]/a"));

        public IWebElement DateFormatOptionsField => Driver.FindElement(By.Id("format"));

        public SelectElement DateFormatSelect => new SelectElement(DateFormatOptionsField);
    }
}
