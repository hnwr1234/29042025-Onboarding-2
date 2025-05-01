using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System.Threading;

public class Program
{
    private static void Main(string[] args)
    {
        // Set Chrome options to open in Incognito mode
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--incognito");

        // Open Chrome Browser in Incognito mode
        IWebDriver driver = new ChromeDriver(options);

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


        //Part 2 
        //Navigate and Identify Skills Tab and click on it 
        IWebElement SkillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        SkillsTab.Click();
        Thread.Sleep (500);

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

        if(GoToLastSkills.Text == "CSS")
        {
            Console.WriteLine("All languages and skills has been create successfully!Test is passed!!");
        }
        else
        {
            Console.WriteLine("All languages and skills has been create successfully!Test is failed.");
        }
    }
}








