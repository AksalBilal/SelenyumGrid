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
            * edge driverin local �zerinde �al��mas�
             IWebDriver driver;
            EdgeOptions options = new EdgeOptions();
            options.AddAdditionalCapability("webdriver.edge.driver", "C:\\Users\\bilal\\Downloads\\Compressed\\edgedriver_win64");
            driver = new EdgeDriver(options);
            driver.Navigate().GoToUrl("https://www.google.com");
        }*/
        [Test]
        public void RemoteChromeTesti()
        {
            IWebDriver driver;// Driver�n tan�mlanmas�
            var capabilities = new ChromeOptions().ToCapabilities();// Node da �al��acak Browser (Chrome-Option / Chrome-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri k�k drivere ba�l�yorum
            driver.Navigate().GoToUrl("https://www.google.com");//driveri test etmek i�in url y�nlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmas�
        }
        [Test]
        public void RemoteEdgeTesti()
        {
            IWebDriver driver;// Driver�n tan�mlanmas�
            var capabilities = new EdgeOptions().ToCapabilities();// Node da �al��acak Browser (Edge-Option / Edge-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri k�k drivere baglama
            driver.Navigate().GoToUrl("https://www.google.com"); //driveri test etmek i�in url y�nlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmas�
        }
        [Test]
        public void RemoteFirefoxTesti()
        {
            IWebDriver driver;// Driver�n tan�mlanmas�
            var capabilities = new FirefoxOptions().ToCapabilities();// Node da �al��acak Browser (Firefox-Option / Firefox-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri k�k drivere baglama
            driver.Navigate().GoToUrl("https://www.google.com");//driveri test etmek i�in url y�nlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmas�
        }
        [Test]
        public void RemoteIETesti()
        {
            IWebDriver driver;// Driver�n tan�mlanmas�
            var capabilities = new InternetExplorerOptions().ToCapabilities();// Node da �al��acak Browser (Internet-Option / Internet-Profile)
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);//driveri k�k drivere baglama
            driver.Navigate().GoToUrl("https://www.google.com");//driveri test etmek i�in url y�nlendirmesi yapma
            driver.Close();//test sonunda driverin kapanmas�
        }

    }
}