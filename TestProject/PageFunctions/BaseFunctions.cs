using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Threading;


namespace TestProject.PageFunctions
{
    public class BaseFunctions
    {        
        public static IWebDriver driver;
        public String browser { get; set; }

        public void mouseOverOnObject(By lookupBy, int maxWaitTime = 60)
        {
            IWebElement element = null;
            try
            {
                element = waitForElementVisible(lookupBy, maxWaitTime);
                if (element != null)
                {
                    new Actions(driver).MoveToElement(element).Perform();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal IWebElement waitForElementVisible(By lookupBy, int maxWaitTime = 60)
        {
            IWebElement element = null;
            try
            {
                element = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWaitTime)).Until(driver => driver.FindElement(lookupBy));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
            if (element != null)
            {
                try
                {
                    string script = String.Format(@"arguments[0].style.cssText = ""border-width: 4px; border-style: solid; border-color: {0}"";", "orange");
                    IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                    jsExecutor.ExecuteScript(script, new object[] { element });
                    jsExecutor.ExecuteScript(String.Format(@"$(arguments[0].scrollIntoView(true));"), new object[] { element });
                }
                catch { }
            }
            return element;
        }
        public void objectClick(By lookupBy, int maxWaitTime = 60)
        {
            IWebElement element = null;
            try
            {
                element = waitForElementVisible(lookupBy, maxWaitTime);
                if (element != null)
                {
                    element.Click();                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void waitForPageLoad(int maxWaitTime = 60)
        {
            try
            {
                bool objAvailable = false;
                bool visible = true;
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWaitTime));
                IJavaScriptExecutor javascript = driver as IJavaScriptExecutor;
                if (javascript == null)
                    throw new ArgumentException("Driver", "Driver not supports javascript execution");
                objAvailable = wait.Until((d) =>
                {
                    try
                    {
                        string readyState = javascript.ExecuteScript(
                            "if (document.readyState) return document.readyState;").ToString();
                        return readyState.ToLower() == "complete";
                    }

                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                });
                if (driver.FindElement(By.Id("ajaxBusyMenu")).Displayed)
                {
                    visible = wait.Until((d) =>
                    {
                        return driver.FindElement(By.Id("ajaxBusyMenu")).Displayed == false;
                    });
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
        }
        public bool checkIfObjectExists(By lookupBy, int maxWaitTime = 60)
        {
            IWebElement element = null;
            try
            {
                element = waitForElementVisible(lookupBy, maxWaitTime);
                if (element != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        
        public void LaunchApplication()
        {
            string url = ConfigurationManager.AppSettings.Get("url");
            GetDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }
        public static IWebDriver GetDriver()
        {
            string browser = ConfigurationManager.AppSettings.Get("browser");
            switch (browser.ToLower().Trim())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    Console.WriteLine("Invalid browser selection");
                    break;
            }
            driver.Manage().Window.Maximize();
            return driver;
        }
        public void QuitDriver()
        {
            try
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string retrieveElementAttributeValue(By lookupBy, string strAttributeName, int maxWaitTime = 10)
        {
            string returnValue = string.Empty;
            IWebElement element = null;
            try
            {
                element = waitForElementVisible(lookupBy, maxWaitTime);
                if (element != null)
                {
                    if (strAttributeName.ToLower().Equals("text"))
                    {
                        return element.Text;
                    }
                    else
                    {
                        returnValue = element.GetAttribute(strAttributeName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return returnValue;
        }
        public void checkStringContains(String StrText, String Token)
        {
            try
            {                
                if (!StrText.Contains(Token))
                {
                    throw new Exception(String.Format("Does not Contan {0} : {1}", StrText, Token));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }      
        public void switchToiFrame()
        {           
            try
            {
               driver.SwitchTo().Frame(0);
               Thread.Sleep(2000);              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void enterValueInTextField(By lookUpBy, string strInputValue, int maxWaitTime = 60)
        {
            IWebElement element = null;
            try
            {
                element = waitForElementVisible(lookUpBy, maxWaitTime);
                if (element != null)
                {
                    element.SendKeys(strInputValue);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
