using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class HandlingRadioButtonElement 
{
    static IWebDriver driver = new ChromeDriver();

    static IWebElement radioButton;
    static void Main()
    {
        string[] option = { "1", "3", "5" };
        //#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)
        //#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(3)
        //#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(5)
        string url = "https://testing.todorvachev.com/special-elements/radio-button-test/";

        driver.Navigate().GoToUrl(url);

        for(int i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + option + ")"));
            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("This radio button is checked");
            }
            else
            {
                Console.WriteLine("This radio button is unchecked");
            }
        }

        driver.Quit();
    }
}
  
