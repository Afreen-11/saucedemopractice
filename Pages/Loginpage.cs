using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo.Pages
{
    public class Loginpage
    {
        public readonly IWebDriver driver;
         By usernameField = By.Id("user-name");
        public readonly By passwordField = By.Id("password");
        public readonly By loginButton = By.Id("login-button");
       
        public Loginpage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        public void validcredentials() 
        { 
          driver.FindElement(usernameField).SendKeys("standard_user");
          driver.FindElement(passwordField).SendKeys("secret_sauce");
        }
        public void loginbutton() 
        {

            driver.FindElement(loginButton).Click();
            
        }
        public void assertion() 
        {
            IWebElement error = driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]"));
            Assert.That(error.Text, Is.EqualTo("Epic sadface: Username is required"));

        }

        public void invalidcredentials() 
        {
           IWebElement un =driver.FindElement(usernameField);
            un.SendKeys("standd_user");
            IWebElement ps=driver.FindElement(passwordField);
            ps.SendKeys("secret_sauce");
            un.Clear();
            ps.Clear();


        }
        public void Screenshot()
        {
            Random rndnumber = new Random();
            int num = rndnumber.Next(1, 20);
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            //Calling Getscreenhot method to create an image file which is provided by screenshot class
            Screenshot ss = screenshot.GetScreenshot();
            string filepath = "D:\\myworks\\Saucedemo\\Saucedemo\\Screenshots\\";
            ss.SaveAsFile(filepath + num + ".png", ScreenshotImageFormat.Png);

        }
        

    }
}
