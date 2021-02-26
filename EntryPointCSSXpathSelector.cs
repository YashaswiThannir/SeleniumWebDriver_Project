using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPointCSSXpathSelectors
{
    static void Main() 
    {
        string url = "https://testing.todorvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > figure > img";
        //string xPath = "//*[@id=\"post - 108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement;
        //IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try 
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            if (cssPathElement.Displayed)
            {
                GreenMessage("I can see the css element");
            }
        }

        catch (NoSuchElementException)
        {
            RedMessage("Could not locate css element");
        }

        //if (cssPathElement.Displayed) 
        //{
        //    GreenMessage("Yes, found the css element");
        //}
        //else 
        //{
        //    RedMessage("No, css element not found");
        //}

        //if (xPathElement.Displayed)
        //{
        //    GreenMessage("Yes, found the xpath element");
        //}
        //else
        //{
        //    RedMessage("No, xpath element not found");
        //}
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

