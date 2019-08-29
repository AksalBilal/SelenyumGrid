using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
     /*   [Test]
        public void test()
        {
            * edge driverin local üzerinde çalýþmasý
             IWebDriver driver;
            EdgeOptions options = new EdgeOptions();
            options.AddAdditionalCapability("webdriver.edge.driver", "C:\\Users\\bilal\\Downloads\\Compressed\\edgedriver_win64");
            driver = new EdgeDriver(options);
            driver.Navigate().GoToUrl("https://www.google.com");
        }*/
        [Test]
        public void RemoteChromeTesti()
        {
            IWebDriver driver;// Driverýn tanýmlanmasý
            var capabilities = new ChromeOptions().ToCapabilities();// Node da çalýþacak Browser (Chrome-Option / Chrome-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri kök drivere baðlýyorum
            driver.Navigate().GoToUrl("https://www.google.com");//driveri test etmek için url yönlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmasý
        }
        [Test]
        public void RemoteEdgeTesti()
        {
            IWebDriver driver;// Driverýn tanýmlanmasý
            var capabilities = new EdgeOptions().ToCapabilities();// Node da çalýþacak Browser (Edge-Option / Edge-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri kök drivere baglama
            driver.Navigate().GoToUrl("https://www.google.com"); //driveri test etmek için url yönlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmasý
        }
        [Test]
        public void RemoteFirefoxTesti()
        {
            IWebDriver driver;// Driverýn tanýmlanmasý
            var capabilities = new FirefoxOptions().ToCapabilities();// Node da çalýþacak Browser (Firefox-Option / Firefox-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri kök drivere baglama
            driver.Navigate().GoToUrl("https://www.google.com");//driveri test etmek için url yönlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmasý
        }
        [Test]
        public void RemoteIETesti()
        {
            IWebDriver driver;// Driverýn tanýmlanmasý
            var capabilities = new InternetExplorerOptions().ToCapabilities();// Node da çalýþacak Browser (Internet-Option / Internet-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri kök drivere baglama
            driver.Navigate().GoToUrl("https://www.google.com");//driveri test etmek için url yönlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmasý
        }

    }
}