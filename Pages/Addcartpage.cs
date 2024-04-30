using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo.Pages
{
    public class Addcartpage
    {
        public IWebDriver driver;
        By item1 = By.CssSelector("#add-to-cart-sauce-labs-backpack");
        By item2 = By.CssSelector("#add-to-cart-sauce-labs-onesie");
        By item3 = By.XPath("//button[@id='add-to-cart-sauce-labs-fleece-jacket']");
        By removefromcart = By.CssSelector("#remove-sauce-labs-backpack");
        By carticon = By.ClassName("shopping_cart_link");
        By cntnshopping = By.CssSelector("#continue-shopping");
        By item4 = By.LinkText("Sauce Labs Bike Light");
        By additem4 = By.Id("add-to-cart-sauce-labs-bike-light");
        By back = By.Id("back-to-products");
        By checkoutbutton = By.CssSelector("#checkout");
        By firstname = By.Id("first-name");
        By lastname = By.Id("last-name");
        By zip = By.Id("postal-code");
        By continuebtn = By.XPath("//*[@id=\"continue\"]");
        By finishbutton = By.CssSelector("#finish");
        public Addcartpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void allactions()
        {
            driver.FindElement(item1).Click();
            driver.FindElement(item2).Click();
            driver.FindElement(item3).Click();
            driver.FindElement(removefromcart).Click();
            driver.FindElement(carticon).Click();
            driver.FindElement(cntnshopping).Click();
            driver.FindElement(item4).Click();
            driver.FindElement(additem4).Click();
            driver.FindElement(back).Click();
            driver.FindElement(carticon).Click();
            driver.FindElement(checkoutbutton).Click();

        }
        public void clickbutton()
        {
            driver.FindElement(continuebtn).Click();
            
        }
        public void assert() 
        {

            IWebElement errormessage = driver.FindElement(By.XPath("//*[@id=\"checkout_info_container\"]/div/form/div[1]/div[4]"));
            Assert.IsTrue(errormessage.Displayed);
            //Assert.AreEqual("First Name is required",errormessage.Text);
            Assert.That(errormessage.Text, Is.EqualTo("Error: First Name is required"));
        }

        public void inputactions()
        {
            IWebElement firstnamefield = driver.FindElement(firstname);
            firstnamefield.SendKeys("Afreen");
            Assert.AreEqual("Afreen", firstnamefield.GetAttribute("value"));
            IWebElement lastnamefield = driver.FindElement(lastname);
            lastnamefield.SendKeys("md");
            Assert.AreEqual("md", lastnamefield.GetAttribute("value"));
            driver.FindElement(zip).SendKeys("507321");
            //driver.FindElement(finishbutton).Click();
            //IWebElement textmsg = driver.FindElement(By.XPath("//*[@id=\"checkout_complete_container\"]/h2"));
            //Assert.That(textmsg.Text, Is.EqualTo("Thank you for your order!"));
        }
        public void finish() 
        {
            driver.FindElement(finishbutton).Click();
            IWebElement textmsg = driver.FindElement(By.XPath("//*[@id=\"checkout_complete_container\"]/h2"));
            Assert.That(textmsg.Text, Is.EqualTo("Thank you for your order!"));

        }




    }

}



