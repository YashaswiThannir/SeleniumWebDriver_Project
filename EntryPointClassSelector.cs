
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPointClassSelector
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/selectors/class-name/";
        string className = "testClass";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.ClassName(className));

        if (element.Displayed)
        {
            GreenMessage("Yes, the element is displayed");
        }
        else
        {
            RedMessage("No, the element is not displayed");
        }

        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
