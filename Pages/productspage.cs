using OpenQA.Selenium;
//using PageFactoryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Saucedemo.Pages
{
    public class productspage
    {
        public IWebDriver driver;
        public productspage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#header_container > div.header_secondary_container > div > span > select")]
        public IWebElement dropdownbar;

        public void selectdropdown() 
        {
            SelectElement dropdown = new SelectElement(dropdownbar);
            dropdown.SelectByIndex(0);
        }
        


    }
}
