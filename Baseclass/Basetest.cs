using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Saucedemo.Baseclass
{
    public class Basetest
   { 
    public IWebDriver driver;
    public ExtentReports extent;
    public ExtentTest test ;

     [OneTimeSetUp]
    public void Setup()
    {
        // Initialize WebDriver
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.saucedemo.com/";

        // Initialize ExtentReports
        extent = new ExtentReports();
        var htmlReporter = new ExtentHtmlReporter(@"D:\myworks\Saucedemo\Saucedemo\Extentreport\report.html");
        extent.AttachReporter(htmlReporter);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }
       
    [TearDown]
    public void TearDown()
    {
        // Close the WebDriver
        driver.Quit();
        
    }
        [OneTimeTearDown]
        public void onetimeteardown()
        {

            extent.Flush();
        }


    }
}
