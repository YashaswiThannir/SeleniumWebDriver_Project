using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class HandlingAlertElement
{
    static IWebDriver driver = new ChromeDriver();

    static IAlert alertElement;

    static IWebElement image;

    static void Main()
    {
        string url = "https://testing.todorvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alertElement = driver.SwitchTo().Alert();

        Console.WriteLine(alertElement.Text);

        alertElement.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        try
        {
            if(image.Displayed)
            {
                Console.WriteLine("Alert box was successfully accepted and the image is displayed.");
            }
        }
        catch (NoSuchElementException)
        {
            
            Console.WriteLine("Something went wrong!");
            
        }
       
        Thread.Sleep(3000);

        driver.Quit();
    }
}
 
