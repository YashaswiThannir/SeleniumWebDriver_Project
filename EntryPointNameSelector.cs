using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPointNameSelector
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            GreenMessage("Yes, I can see the element, it's right there");
        }
        else
        {
            RedMessage("Well, something went wrong. I couldn't see the element");
        }

        driver.Quit();
   }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

