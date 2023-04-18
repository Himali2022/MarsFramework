using MarsFramework.Global;
using NUnit.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    public class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        public IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        public IWebElement LoginBtn { get; set; }

        #endregion

        public void LoginSteps()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //launch Mars page
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));

            //Click on Sign In button
            SignIntab.Click();

            //Enter Email
            Email.Click();
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.Click();
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Click on Login button to Sign In
            LoginBtn.Click();
        }
             
    }
}