using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsFramework.Pages
{
    internal class selectElement : SelectElement
    {
        public selectElement(IWebElement element) : base(element)
        {
        }
    }
}