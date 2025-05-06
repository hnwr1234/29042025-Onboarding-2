using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using _29042025_Onboarding_2.Pages;
using _29042025_Onboarding_2.Utilities; 

namespace _29042025_Onboarding_2.Tests
{
    [TestFixture]
    public class LanguageSkill_Test : CommonDriver
    {
       
        [SetUp]
        public void SetUpSteps()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");

            driver = new ChromeDriver(options);  // Initialize the driver

            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);
        }

        [Test] // Add 4 Languages 
        public void AddLanguages_Test()
        {
            LanguagePage LanguagePageObj = new LanguagePage();
            LanguagePageObj.AddLangaugesActions(driver);
        }

        [Test]  // Add 5 Skills Delete 5 Skills Delete 4 Languages 
        public void AddSkills_Test()
        {
            SkillPage SkillPageObj = new SkillPage();
            SkillPageObj.AddSkillActions(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit(); // Cleanly close browser
        }
    }
}

