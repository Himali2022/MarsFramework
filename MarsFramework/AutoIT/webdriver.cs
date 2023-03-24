using OpenQA.Selenium.Chrome;
using System;

namespace MarsFramework.Auti_IT
{
    internal class webdriver
    {
        public static implicit operator webdriver(ChromeDriver v)
        {
            throw new NotImplementedException();
        }
    }
}