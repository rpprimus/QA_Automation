using Affordit_Automation.Utils;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affordit_Automation.PageObjects
{
    public class Personal_info_Borr_CoBorrPageObject : DriverHelper
    {
        public By secnumber => ByLocator("name=borrowerSsn");
        public By secnumber2 => ByLocator("name=coBorrowerSsn");
        public By BoFirstname => ByLocator("name=borrowerFirstName");
        public By Bolastname => ByLocator("name=BorrowerLastName");
        public Personal_info_Borr_CoBorrPageObject(IWebDriver driver) : base(driver) { }

            public void BorrowerFirstname(string name)
            {
                SendKeys(BoFirstname, name, true);
            }

            public void BorrowerLastname(string name2)
            {
                SendKeys(Bolastname, name2, true);
            }
        public void EnterSecuritynumber(String sn)
        {
            SendKeys(secnumber, sn, true);
        }
        public void EnterCoSecuritynumber(String sn2)
        {
            SendKeys(secnumber2, sn2, true);
        }
    }
}
