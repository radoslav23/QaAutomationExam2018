using OpenQA.Selenium;

namespace QaAutomationExam2018.Pages.BlogPage
{
    public partial class BlogPage
    {
        public IWebElement BlogLink => Driver.FindElement(By.XPath("//*[@id=\"menu-item-6\"]/a"));

        public IWebElement WebDriverTestsFirefoxLink => Wait.Until(x => x.FindElement(By.XPath("//*[@id=\"post-7811\"]/div[1]/a/span[1]")));

        public IWebElement QuickNavigation => Wait.Until(x => x.FindElement(By.ClassName("tve_ct_title")));

        public IWebElement TestCaseLink => Driver.FindElement(By.XPath("//*[@id=\"tve_editor\"]/div[2]/div/div/div[1]/div[1]/a"));

        public IWebElement TestCaseHeader => Driver.FindElement(By.XPath("//*[@id=\"tab-con-0\"]"));

        public IWebElement HeadlessExecutionFirefoxDriverLink => Driver.FindElement(By.XPath("//*[@id=\"tve_editor\"]/div[2]/div/div/div[1]/div[2]/a"));

        public IWebElement HeadlessExecutionFirefoxDriverHeader => Driver.FindElement(By.XPath("//*[@id=\"tab-con-1\"]"));

        public IWebElement BenchmarkAgainstOtherBrowsersLink => Driver.FindElement(By.XPath("//*[@id=\"tve_editor\"]/div[2]/div/div/div[2]/div[1]/a"));

        public IWebElement BenchmarkAgainstOtherBrowsersHeader => Driver.FindElement(By.XPath("//*[@id=\"tab-con-2\"]"));
        
        public IWebElement TestCaseCodeLink => Driver.FindElement(By.XPath("//*[@id=\"tve_editor\"]/div[2]/div/div/div[2]/div[2]/a"));

        public IWebElement TestCaseCodeHeader => Driver.FindElement(By.XPath("//*[@id=\"tab-con-3\"]"));

        public IWebElement BenchmarkExecutionTimeLink => Driver.FindElement(By.XPath("//*[@id=\"tve_editor\"]/div[2]/div/div/div[2]/div[3]/a"));

        public IWebElement BenchmarkExecutionTimeHeader => Driver.FindElement(By.XPath("//*[@id=\"tab-con-4\"]"));

        public IWebElement BenchmarkTestsLink => Driver.FindElement(By.XPath("//*[@id=\"tve_editor\"]/div[2]/div/div/div[2]/div[4]/a"));

        public IWebElement BenchmarkTestsHeader => Driver.FindElement(By.XPath("//*[@id=\"tab-con-5\"]"));

        public IWebElement BenchmarkResultsLink => Driver.FindElement(By.XPath("//*[@id=\"tve_editor\"]/div[2]/div/div/div[2]/div[5]/a"));

        public IWebElement BenchmarkResultsHeader => Driver.FindElement(By.XPath("//*[@id=\"tab-con-6\"]"));
    }
}
