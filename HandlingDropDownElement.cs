using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class HandlingDropDownElement
{
    static IWebDriver driver = new ChromeDriver();

    static IWebElement dropDownMenu;

    static IWebElement elementFromDropDown;
    static void Main()
    {
        string url = "https://testing.todorvachev.com/special-elements/drop-down-menu-test/";

        string dropDownElement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine(dropDownMenu.GetAttribute("value")); //gives current selected item value

        elementFromDropDown = driver.FindElement(By.CssSelector(dropDownElement));

        Console.WriteLine("The third element in the drop down list is " + elementFromDropDown.GetAttribute("value"));

        elementFromDropDown.Click();

        Console.WriteLine(elementFromDropDown.GetAttribute("value"));

        Thread.Sleep(3000);

        //to check all the values in the dropdown a for loop can be used.

        for(int i = 1; i <= 4; i++)
        {
            dropDownElement = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+ i +")";

            elementFromDropDown = driver.FindElement(By.CssSelector(dropDownElement));

            Console.WriteLine("The " + i + " element in the drop down list is " + elementFromDropDown.GetAttribute("value"));
        }

        driver.Quit();

    }
}
 
