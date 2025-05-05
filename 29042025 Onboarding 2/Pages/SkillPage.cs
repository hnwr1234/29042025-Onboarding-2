using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace _29042025_Onboarding_2.Pages
{
    public class SkillPage
    {

        // Function that AddLangauges in my Profile Page
        public void AddSkillActions (IWebDriver driver)
        {

            //Part 2 
            //Navigate and Identify Skills Tab and click on it 
            IWebElement SkillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillsTab.Click();
            Thread.Sleep(500);

            // Add Skill 1: Python - Beginner
            IWebElement AddNewButtonSkill1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButtonSkill1.Click();
            Thread.Sleep(500);

            IWebElement AddSkillsTextBox1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkillsTextBox1.Click();
            Thread.Sleep(500);
            AddSkillsTextBox1.SendKeys("Python");

            IWebElement SkillsLevelDropDown1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillsLevelDropDown1.Click();

            IWebElement BeginnerOption1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            BeginnerOption1.Click();
            Thread.Sleep(500);

            IWebElement AddButtonClick1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButtonClick1.Click();


            // Add Skill 2: Java - Beginner
            IWebElement AddNewButtonSkill2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButtonSkill2.Click();
            Thread.Sleep(500);

            IWebElement AddSkillsTextBox2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkillsTextBox2.Click();
            Thread.Sleep(500);
            AddSkillsTextBox2.SendKeys("Java");

            IWebElement SkillsLevelDropDown2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillsLevelDropDown2.Click();

            IWebElement BeginnerOption2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            BeginnerOption2.Click();
            Thread.Sleep(500);

            IWebElement AddButtonClick2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButtonClick2.Click();



            // Add Skill 3: Javascript - Beginner
            IWebElement AddNewButtonSkill3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButtonSkill3.Click();
            Thread.Sleep(500);

            IWebElement AddSkillsTextBox3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkillsTextBox3.Click();
            Thread.Sleep(500);
            AddSkillsTextBox3.SendKeys("Javascript");

            IWebElement SkillsLevelDropDown3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillsLevelDropDown3.Click();

            IWebElement BeginnerOption3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            BeginnerOption3.Click();
            Thread.Sleep(500);

            IWebElement AddButtonClick3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButtonClick3.Click();


            // Add Skill 4: HTML - Beginner

            IWebElement AddNewButtonSkill4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButtonSkill4.Click();
            Thread.Sleep(500);

            IWebElement AddSkillsTextBox4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkillsTextBox4.Click();
            Thread.Sleep(500);
            AddSkillsTextBox4.SendKeys("HTML");

            IWebElement SkillsLevelDropDown4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillsLevelDropDown4.Click();

            IWebElement BeginnerOption4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            BeginnerOption4.Click();
            Thread.Sleep(500);

            IWebElement AddButtonClick4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButtonClick4.Click();

            // Add Skill 5: CSS - Beginner

            IWebElement AddNewButtonSkill5 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButtonSkill5.Click();
            Thread.Sleep(500);

            IWebElement AddSkillsTextBox5 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkillsTextBox5.Click();
            Thread.Sleep(500);
            AddSkillsTextBox5.SendKeys("CSS");

            IWebElement SkillsLevelDropDown5 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillsLevelDropDown5.Click();

            IWebElement BeginnerOption5 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            BeginnerOption5.Click();
            Thread.Sleep(500);

            IWebElement AddButtonClick5 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButtonClick5.Click();


            //Check if the Last Skill has been create successfully 
            IWebElement GoToLastSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[5]/tr/td[1]"));

            if (GoToLastSkills.Text == "CSS")
            {
                Console.WriteLine("All languages and skills has been create successfully!Test is passed!!");
            }
            else
            {
                Console.WriteLine("All languages and skills has been create successfully!Test is failed.");
            }





        }


        }
    }
