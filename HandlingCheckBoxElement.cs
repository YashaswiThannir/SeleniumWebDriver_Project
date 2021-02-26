using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class HandlingCheckBoxElement
{
    static IWebDriver driver = new ChromeDriver();

    static IWebElement checkBox;
    static void Main() 
    {
        int option = 1;

        string url = "https://testing.todorvachev.com/special-elements/check-button-test-3/";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option +")"));

        if (checkBox.GetAttribute("checked") == "true") 
        {
            Console.WriteLine("It's checked");
        }
        else
        {
            Console.WriteLine("It's unchecked and now selecting it");
            checkBox.Click();
        }

        Console.WriteLine(checkBox.GetAttribute("value"));

        Thread.Sleep(3000);

        driver.Quit();
    }
}
  
