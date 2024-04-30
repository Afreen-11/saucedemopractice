using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using Saucedemo.Baseclass;
using Saucedemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Authentication;

namespace Saucedemo.Testscripts
{
    public class Tests : Basetest
    {
       

        [Test]
        public void TestLogin()
        {
            test = extent.CreateTest("Login with valid credentials");
            // Create a new LoginPage object
            var Loginpage = new Loginpage(driver);
            Loginpage.loginbutton();
            Loginpage.assertion();
            Loginpage.Screenshot();
            test.Log(Status.Info, "Must enter credentials");
            Loginpage.invalidcredentials();
            Loginpage.loginbutton();
            Thread.Sleep(2000);
            Loginpage.validcredentials();
            Loginpage.loginbutton();
            Loginpage.Screenshot();
            test.Log(Status.Info, "Login successful");
            test.Pass("Test Passed");
            var productspage = new productspage(driver);
            Thread.Sleep(2000);
            productspage.selectdropdown();
            test.Log(Status.Info, "suceessfuly selected dropdown");
            test.Pass("Test passed");
            var Addcartpage = new Addcartpage(driver);
            Addcartpage.allactions();
            Loginpage.Screenshot();
            Addcartpage.clickbutton();
            Addcartpage.assert();
            Loginpage.Screenshot();
            Addcartpage.inputactions();
            Addcartpage.clickbutton();
            Addcartpage.finish();
            test.Log(Status.Pass, "items successfully added to the cart");
            Assert.IsTrue(driver.Title.Contains( "Swag Labs"));
     

        }
        [Test]
        public void Testmethod1()
        {
            test = extent.CreateTest("Login with invalid credentials");
            var Loginpage = new Loginpage(driver);
            Loginpage.invalidcredentials();
            Loginpage.Screenshot();
            test.Log(Status.Fail, "Invalid credentials");

        }
       

    }
}


