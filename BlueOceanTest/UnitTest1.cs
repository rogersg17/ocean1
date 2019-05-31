﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using BlueOceanLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace BlueOceanTest
{
    [TestClass]  

    public class UnitTest1
    {
        //IWebDriver driver;

        //[TestInitialize]
        //public void SetUpWebDriver()
        //{          
        //        //driver = new FirefoxDriver(@"C:\SeleniumDriver");            
        //}

        [TestMethod]
        public void GetAllBooks_VerfiyCount()
        {
           var mockLibrary = new Library();
           var numberOfBooks = mockLibrary.GetAllBooks().Count;

            numberOfBooks.Should().Be(3);

        }
        [TestMethod]
        public void VerifyTitle()
        {
            var mockLibrary = new Library();
            var numberOfBooks = mockLibrary.GetAllBooks();

            numberOfBooks[0].id = 1;
            numberOfBooks[1].id = 2;
            numberOfBooks[2].id = 3;

        }

        [TestMethod]
        public void VerifyGoogleTitle()
        {
            //IWebDriver driver;
            //driver = new FirefoxDriver(@"C:\SeleniumDriver\chromedriver_win32");
            //driver.Navigate().GoToUrl("http://www.google.com");
            //string title = driver.Title;
            //title.Should().Be("Google");
            //driver.Quit();

            IWebDriver driver;
            driver = new ChromeDriver(@"C:\SeleniumDriver\chromedriver_win32");
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Quit();

        }
    }
}
