using Affordit_Automation.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Affordit_Automation.PageObjects
{
    [Binding]
    public class EmployerObjects : DriverHelper
    {

        public EmployerObjects(IWebDriver driver) : base(driver) { }


    }
}
