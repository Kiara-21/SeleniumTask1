using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumPractice
{
    public class SeleniumTask
    {
        public static void Main()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://pastebin.com/");

            IWebElement textBox = driver.FindElement(By.XPath("//*[@id=\"postform-text\"]"));
            textBox.SendKeys("Hello from WebDriver");

            IWebElement textTitle = driver.FindElement(By.XPath("//*[@id=\"postform-name\"]"));
            textTitle.SendKeys("helloweb");

            IWebElement sendButton = driver.FindElement(By.XPath("//*[@id=\"w0\"]/div[5]/div[1]/div[10]/button"));
            sendButton.Click();

            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
