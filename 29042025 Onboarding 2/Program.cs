using _29042025_Onboarding_2.Pages;
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

        // NEW **   Login page object initialization and definition 
        LoginPage LoginPageObj = new LoginPage();
        LoginPageObj.LoginActions(driver);

        // NEW ** Language page object initialization and definition 
        LanguagePage LanguagePageObj = new LanguagePage();
        LanguagePageObj.AddLangaugesActions(driver);

        // NEW**  Skills page  object initialization and definition 
        SkillPage SkillPageObj = new SkillPage();
        SkillPageObj.AddSkillActions(driver);




    }
}







