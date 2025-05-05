using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace _29042025_Onboarding_2.Pages
{
   public class LoginPage
    {
    // Function that allow users to login to Turnup portal
    public void LoginActions(IWebDriver driver)
        {
            // Launch LocalHost5003
            driver.Navigate().GoToUrl("http://localhost:5003/Home");

            // Maximize the browser window
            driver.Manage().Window.Maximize();

            // Identity signin clickbutton and click
            IWebElement signinClickButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinClickButton.Click();

            // Identity email Textbox and enter valid username 
            IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailTextbox.SendKeys("raphaeltwwong@hotmail.com");

            // Identify password Textbox and enter valid password 
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Fsdp8000121");

            // Identify login button and click on it 
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(3000);

        }

    
    }
}
