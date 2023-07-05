using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.AutoIT
{
    public class AutoIT
    {
        public static void Test() 
        {
            {
                //System.setProperty("webdriver.chrome.driver", @"C:\Users\himal\Competition Task\Mars Framework\MarsFramework\chromedriver_linux64");
                //WebDriver driver = new ChromeDriver();

                //driver.get("http://localhost:5000/Home/ServiceListing");
                //driver.findElement(By.XPath("/i[@class=\"search link icon\"]"));
                Click();

                //System.Runtime.getRuntime().exec("\"D:\\File Upload.exe\"");
                Thread.Sleep(3000);
                //driver.close();
            }

        }

        private static void Click()
        {
            throw new NotImplementedException();
        }
    }
}
