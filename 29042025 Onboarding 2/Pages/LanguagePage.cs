using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V133.Emulation;

namespace _29042025_Onboarding_2.Pages
{
    public class LanguagePage
    {

        public void AddLangaugesActions(IWebDriver driver)
        {
            //put my Addlanguagescode here

            // Navigate to Account profile page 
            driver.Navigate().GoToUrl("http://localhost:5003/Account/Profile");
            Thread.Sleep(2000);

            // Add Language 1: English - Fluent
            IWebElement AddNewButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton1.Click();
            Thread.Sleep(1000);

            IWebElement AddLanguage1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage1.SendKeys("English");
            Thread.Sleep(500);

            IWebElement LanguageLevelDropdown1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            LanguageLevelDropdown1.Click();
            Thread.Sleep(500);

            IWebElement FluentOption1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[text()='Fluent']"));
            FluentOption1.Click();
            Thread.Sleep(500);

            IWebElement ConfirmAddButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            ConfirmAddButton1.Click();
            Thread.Sleep(2000);

            // Add Language 2: Cantonese - Native/Bilingual
            IWebElement AddNewButton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton2.Click();
            Thread.Sleep(1000);

            IWebElement AddLanguage2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage2.SendKeys("Cantonese");
            Thread.Sleep(500);

            IWebElement LanguageLevelDropdown2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            LanguageLevelDropdown2.Click();
            Thread.Sleep(500);

            IWebElement NativeOption2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[text()='Native/Bilingual']"));
            NativeOption2.Click();
            Thread.Sleep(500);

            IWebElement ConfirmAddButton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            ConfirmAddButton2.Click();
            Thread.Sleep(2000);

            // Add Language 3: Mandarin - Fluent
            IWebElement AddNewButton3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton3.Click();
            Thread.Sleep(1000);

            IWebElement AddLanguage3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage3.SendKeys("Mandarin");
            Thread.Sleep(500);

            IWebElement LanguageLevelDropdown3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            LanguageLevelDropdown3.Click();
            Thread.Sleep(500);

            IWebElement FluentOption3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[text()='Fluent']"));
            FluentOption3.Click();
            Thread.Sleep(500);

            IWebElement ConfirmAddButton3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            ConfirmAddButton3.Click();
            Thread.Sleep(2000);

            // Add Language 4: Japanese - Fluent
            IWebElement AddNewButton4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton4.Click();
            Thread.Sleep(1000);

            IWebElement AddLanguage4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage4.SendKeys("Japanese");
            Thread.Sleep(500);

            IWebElement LanguageLevelDropdown4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            LanguageLevelDropdown4.Click();
            Thread.Sleep(500);

            IWebElement FluentOption4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[text()='Fluent']"));
            FluentOption4.Click();
            Thread.Sleep(500);

            IWebElement ConfirmAddButton4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            ConfirmAddButton4.Click();
            Thread.Sleep(2000);



        }



    }
}
