using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using java.lang;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace SeleniumAssignment
{
    public class AutomationDriver
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radio1, radio2, radio3, countries1, checkall1, checkall2, checkall3, name, element, element1, options, tab;
        public void ExerciseOne(int n)
        {
            switch (n)
            {
                case 1:
                    radio1 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(2) > input"));
                    radio1.Click();
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (radio1.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 1 Button is clicked");
                    }
                    else
                    {
                        Console.WriteLine("Radio 1 button is not clicked");
                    }
                    Console.ResetColor();
                    break;

                case 2 :radio2 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(3) > input"));
                    radio2.Click();
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (radio2.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 2 Button is clicked");
                    }
                    else
                    {
                        Console.WriteLine("Radio 2 button is not clicked");
                    }
                    Console.ResetColor();
                    break;
                
                case 3 :radio3=driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(4) > input"));
                    radio3.Click();
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (radio3.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 3 Button is clicked");
                    }
                    else
                    {
                        Console.WriteLine("Radio 3 button is not clicked");
                    }
                    Console.ResetColor();
                    break;
            }      
            
            
        }
        public void ExerciseTwo()
        {
            countries1 = driver.FindElement(By.CssSelector("#autocomplete"));
            countries1.SendKeys("United States");
            Thread.sleep(1000);
            options = driver.FindElement(By.XPath("//li[@class='ui-menu-item']"));
        }
        public void ExerciseThree()
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"dropdown-class-example\"]")));   
            dropdown.SelectByValue("option1");
            Thread.sleep(1000);
            dropdown.SelectByValue("option2");
            Thread.sleep(1000);
            dropdown.SelectByValue("option3");
            Thread.sleep(1000);
        }
        public void ExerciseFour()
        {
            //Option 1
            checkall1 = driver.FindElement(By.CssSelector("#checkBoxOption1"));
            checkall1.Click();
            Console.ForegroundColor = ConsoleColor.Green;
            if (checkall1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option 1 checkbox has been selected");
            }
            else
            {
                Console.WriteLine("Option 1 checkbox has not been selected");
            }
            Thread.sleep(1000);
            checkall1.Click();
            if (checkall1.GetAttribute("checked") == "false")
            {
                Console.WriteLine("Option 3 checkbox has not been deselected");
            }
            else
            {
                Console.WriteLine("Option 3 checkbox has been deselected");
            }
            Thread.sleep(1000);

            //Option 2
            checkall2 = driver.FindElement(By.CssSelector("#checkBoxOption2"));
            checkall2.Click();
            if (checkall2.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option 2 checkbox has been selected");
            }
            else
            {
                Console.WriteLine("Option 2 checkbox has not been selected");
            }
            Thread.sleep(1000);
            checkall2.Click();
            if (checkall2.GetAttribute("checked") == "false")
            {
                Console.WriteLine("Option 3 checkbox has not been deselected");
            }
            else
            {
                Console.WriteLine("Option 3 checkbox has been deselected");
            }
            Thread.sleep(1000);
            
            //Option 3
            checkall3 = driver.FindElement(By.CssSelector("#checkBoxOption3"));
            checkall3.Click();
            if (checkall3.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option 3 checkbox has been selected");
            }
            else
            {
                Console.WriteLine("Option 3 checkbox has not been selected");
            }
            Thread.sleep(1000);
            checkall3.Click();
            if (checkall3.GetAttribute("checked") == "false")
            {
                Console.WriteLine("Option 3 checkbox has not been deselected");
            }
            else
            {
                Console.WriteLine("Option 3 checkbox has been deselected");
            }

            Console.ResetColor();
            Thread.sleep(1000);
        }
        public void ExerciseFourPointOne()
        {
            checkall1 = driver.FindElement(By.CssSelector("#checkBoxOption1"));
            checkall1.Click();
            checkall2 = driver.FindElement(By.CssSelector("#checkBoxOption2"));
            checkall2.Click();
            checkall3 = driver.FindElement(By.CssSelector("#checkBoxOption3"));
            checkall3.Click();
            Console.ForegroundColor= ConsoleColor.Green;
            if ((checkall1.GetAttribute("checked") == "true") && (checkall2.GetAttribute("checked") == "true") && (checkall3.GetAttribute("checked") == "true"))
            {
                Console.WriteLine("All the Checkbox have been selected");
            }
            else
            {
                Console.WriteLine("All the Checkbox have not been selected");
            }
            Console.ResetColor();
        }
        public void ExerciseFourPointTwo()
        {
            checkall1 = driver.FindElement(By.CssSelector("#checkBoxOption1"));
            checkall1.Click();
            checkall2 = driver.FindElement(By.CssSelector("#checkBoxOption2"));
            checkall2.Click();
            checkall3 = driver.FindElement(By.CssSelector("#checkBoxOption3"));
            checkall3.Click();
            Console.ForegroundColor = ConsoleColor.Green;
            if ((checkall1.GetAttribute("checked") == "false") && (checkall2.GetAttribute("checked") == "false") && (checkall3.GetAttribute("checked") == "false"))
            {
                Console.WriteLine("All the Checkbox have not been deselected");
            }
            else
            {
                Console.WriteLine("All the Checkbox have been deselected");
            }
            Console.ResetColor();

        }
        public void ExerciseFive()
        {
            driver.FindElement(By.Id("openwindow")).Click();
            Thread.sleep(3500);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        public void ExerciseSix()
        {
            driver.FindElement(By.CssSelector("#opentab")).Click();
            Thread.sleep(3500);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void ExerciseSeven()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            driver.FindElement(By.CssSelector("#name")).SendKeys("Rumaiz");
            Thread.sleep(1000);
            driver.FindElement(By.CssSelector("#alertbtn")).Click();
            Thread.sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Switch to Alert is working");
            Console.ResetColor();

        }
        public void ExerciseEight()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(System.String.Format("window.scrollTo({0}, {1})", 400, 627));
            Thread.sleep(1000);
        }
        public void ExerciseNine()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(System.String.Format("window.scrollTo({0}, {1})", 400, 1000));
            Thread.sleep(1000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Actions action = new Actions(driver);
            element = driver.FindElement(By.XPath("//*[@id=\"mousehover\"]")) ;
            element1 = driver.FindElement(By.XPath("/html/body/div[4]/div/fieldset/div/div/a[1]"));   
            action.MoveToElement(element).Perform();
            action.MoveToElement(element1).Perform();
            element1.Click();
            Console.WriteLine("Mouse Hover is Working");
            Console.ResetColor();
            
        }
        static void Main(string[] args)
        {
            Console.Clear();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.qaclickacademy.com/practice.php");
            AutomationDriver o = new AutomationDriver();
            Console.Clear();

            //Exercise One
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise One");
            Console.ResetColor();
            o.ExerciseOne(1);
            Thread.sleep(1000);
            o.ExerciseOne(2);
            Thread.sleep(1000);
            o.ExerciseOne(3);
            Console.WriteLine("");

            //Exercise Two
            Thread.sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Exercise Two");
            Console.ResetColor();
            o.ExerciseTwo();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise Three
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Exercise Three");
            Console.ResetColor();
            o.ExerciseThree();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise Four
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise Four");
            Console.ResetColor();
            o.ExerciseFour();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise FourPointOne
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise FourPointOne");
            Console.ResetColor();
            o.ExerciseFourPointOne();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise FourPointTwo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise FourPointTwo");
            Console.ResetColor();
            o.ExerciseFourPointTwo();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise Five
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Exercise Five");
            Console.ResetColor();
            o.ExerciseFive();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise Six
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Exercise Six");
            Console.ResetColor();
            o.ExerciseSix();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise Seven
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise Seven");
            Console.ResetColor();
            o.ExerciseSeven();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise Eight
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Exercise Eight");
            Console.ResetColor();
            o.ExerciseEight();
            Thread.sleep(1000);
            Console.WriteLine("");

            //Exercise Nine
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise Nine");
            Console.ResetColor();
            o.ExerciseNine();
            Thread.sleep(1000);
            Console.WriteLine("");
            driver.Quit();

        }

    }
}
