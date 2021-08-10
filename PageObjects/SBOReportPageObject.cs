using Affordit_Automation.Utils;
using OpenQA.Selenium;

namespace Affordit_Automation.PageObjects
{
    public class SBOReoprtPageObjects : DriverHelper
    {
        public readonly PropertyReader _propertyReader = PropertyReader.Instance;
        public By NextbtnforLoantypepage => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[1]/app-credit-record/div/div[2]/div/a[2]");
        public By MORTGAGEIcon => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[1]/div/div/div[1]/div[2]/div[1]");
        public By LoanRequestForMORTGAGE => ByLocator("html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/form/div[2]/div[1]/ng-select/div/div/div[2]/input");
        public By LoanSubtastRequest => ByLocator("/html/body/ng-dropdown-panel/div/div[2]/div[2]");
        public By PurchasePrice => ByLocator("//input[@name='purchasePrice']");
        public By DPInterest => ByLocator("//input[@name='downPaymentPercent']");
        public By MonthsForReserves => ByLocator("//input[@name='numberOfMonthsForReserves']");
        public By nextbtnforpersonal => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[2]/app-loan-type/div/div[2]/div/a[2]");
        public By Bofirstname => ByLocator("//input[@name='borrowerFirstName']");
        public By BoLastName => ByLocator("//input[@name='borrowerLastName']");
        public By securitynumber => ByLocator("//input[@name='borrowerSsn']");
        public By nextbntBoOtherInformation => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/a[2]/i");
        public By addresslineone => ByLocator("//input[@name='borrowerPresentAddressLine1']");
        public By addresslinetwo => ByLocator("//input[@name='borrowerPresentAddressLine2']");
        public By borrowerCity => ByLocator("//input[@name='borrowerPresentAddressCity']");
        public By zipcode => ByLocator("//input[@name='borrowerPresentAddressZipCode']");
        public By nextbtnforemployerpage => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[3]/a[2]/i");
        public By employernamebo => ByLocator("//input[@name='borrowerNameOfEmployer']");
        public By Phonenobo => ByLocator("//input[@name='borrowerCurrentEmployerPhoneNumber']");
        public By title => ByLocator("//input[@name='borrowerCurrentEmployerTitle' or @id='mat-input-21']");
        public By nextbtnborroweremp => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i");
        public By EmpAddress1 => ByLocator("//input[@name='borrowerCurrentEmployerAddressLine1']");
        public By EmpAddress2 => ByLocator("//input[@name='borrowerCurrentEmployerAddressLine2']");
        public By nextbtnIncomeAssets => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[4]/app-employment/div/div[2]/div/a[2]/i");
        public By nextbtnLiabilites => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[5]/app-financial-and-asset/div/div[2]/div/a[2]/i");
        public By LiabilityDropBtn => ByLocator("//ng-select[@data-placeholder='Liability']");
        public By liabilityBtn => ByLocator("//button[text()=' Add Liability ']");
        public By LiabitityOption => ByLocator("//div//span[text()='Motorcycle']");
        public By LiabityBalanceAmt => ByLocator("//input[@data-placeholder='Balance Amount']");
        public By dropdownIcon => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[3]/div[4]/div/a/i");
        public By OrigalLoanAmt => ByLocator("//input[@data-placeholder='Original Loan Amount']");
        public By Paymentamt => ByLocator("//input[@data-placeholder='Payment Amount']");
        public By monthlyTerms => ByLocator("//input[@data-placeholder='Terms']");
        public By interestrate => ByLocator("(//input[@data-placeholder='Interest Rate'])[2]");
        public By specialinterest => ByLocator("/html/body/modal-container/div/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[2]/div/mat-checkbox/label/span[1]");
        public By year => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/form/div[1]/div[1]/app-liability/div/mat-card/div[4]/div[5]/div[2]/div[1]/ng-select/div");
        public By make => ByLocator("//div//span[text()='Alta Motors']");
        public By model => ByLocator("//div//span[text()='Redshift MX']");
        public By nextforsbo => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[6]/app-liabilities/div/div[2]/a[2]");
        public By sinterestrate => ByLocator("(//input[@data-placeholder='Interest Rate'])[3]");
        public By PersonalIcon => ByLocator("//label[text()='PERSONAL']");
        public By PersoalLoan => ByLocator("//input[@name='loanAmount']");
        public By nextbtnCobopersonal => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[5]/a[2]/i");
        public By CoBofirstname => ByLocator("//input[@name='coBorrowerFirstName']");
        public By CoBoLastName => ByLocator("//input[@name='coBorrowerLastName']");
        public By Cosecuritynumber => ByLocator("//input[@name='coBorrowerSsn']");
        public By CoBoOtherInfo => ByLocator("/html/body/modal-container/div[2]/div/app-create-new-application-modal/div/mat-horizontal-stepper/div[2]/div[3]/app-personal-information/div/div[2]/form/div[5]/a[2]/i");
        public By coaddresslineone => ByLocator("//input[@name='coBorrowerPresentAddressLine1']");
        public By coaddresslinetwo => ByLocator("//input[@name='coBorrowerPresentAddressLine2']");
        public By coborrowerCity => ByLocator("//input[@name='coBorrowerPresentAddressCity']");
        public By cozipcode => ByLocator("//input[@name='coBorrowerPresentAddressZipCode']");
        public SBOReoprtPageObjects(IWebDriver driver) : base(driver)
        { }
        public void nextbtnforloantype()
        {
            Click(NextbtnforLoantypepage);
        }
        public void ClickMortgageIcon()
        {
            Click(MORTGAGEIcon);
        }
        public void ClickOnTypeOfLoanRequest()
        {
            Click(LoanRequestForMORTGAGE);
        }
        public void SelectLoanSubTypeMortgage()
        {
            Click(LoanSubtastRequest);
        }
        public void EnterAmountinPurchasePrice()
        {
            SendKeys(PurchasePrice, "16000", true);
        }
        public void DownPaymentInterest()
        {
            SendKeys(DPInterest, "10", true);
        }
        public void MonthForReserve()
        {
            SendKeys(MonthsForReserves, "3", true);
        }
        public void NextbtnforPersonalPage()
        {
            Click(nextbtnforpersonal);
        }
        public void BorrowerFirstName()
        {
            SendKeys(Bofirstname, "Alexandra", true);
        }
        public void BorrowerLastName()
        {
            SendKeys(BoLastName, "Haynes", true);
        }
        public void SecurityNumber(string snumber)
        {
            SendKeys(securitynumber, snumber, true);
        }
        public void CoBorrowerFirstName()
        {
            SendKeys(CoBofirstname, "Ajay", true);
        }
        public void CoBorrowerLastName()
        {
            SendKeys(CoBoLastName, "Bhatt", true);
        }
        public void CoSecurityNumber(string snumber)
        {
            SendKeys(Cosecuritynumber, snumber, true);
        }
        public void NextbtnforBorrowerOtherPersonalInformation()
        {
            Click(nextbntBoOtherInformation);
        }
        public void AddressLineOne()
        {
            SendKeys(addresslineone, "173 Walnutwood Drive", true);
        }
        public void AddressLinetwo()
        {
            SendKeys(addresslinetwo, "Ms. Alexandra Haynes 123 Main Street Unit 12 Chicago, IL 12345", true);
        }
        public void CityBorrower()
        {
            SendKeys(borrowerCity, "California", true);
        }
        public void ZipCode()
        {
            SendKeys(zipcode, "93030", true);
        }
        public void CoAddressLineOne()
        {
            SendKeys(coaddresslineone, "173 Walnutwood Drive", true);
        }
        public void CoAddressLinetwo()
        {
            SendKeys(coaddresslinetwo, "Ms. Alexandra Haynes 123 Main Street Unit 12 Chicago, IL 12345", true);
        }
        public void CityCoBorrower()
        {
            SendKeys(coborrowerCity, "California", true);
        }
        public void CoZipCode()
        {
            SendKeys(cozipcode, "93030", true);
        }
        public void NextbtnforEmployeerInformation()
        {
            Click(nextbtnforemployerpage);
        }
        public void EmployerName()
        {
            SendKeys(employernamebo, "Jay Prakash", true);
        }
        public void EmployerPhoneNo()
        {
            SendKeys(Phonenobo, "9250240861", true);
        }
        public void EmployeerTitle()
        {
            SendKeys(title, "Mr.", true);
        }
        public void NextbntforEmployeerAddressPage()
        {
            Click(nextbtnborroweremp);
        }
        public void EnterEmployeerAddress1()
        {
            SendKeys(EmpAddress1, "HN 51 New Colony Jagnnathpur,Dhurwa Ranchi", true);
        }
        public void EnterEmployeerAddress2()
        {
            SendKeys(EmpAddress2, "HN 51 New Colony Jagnnathpur,Near Jagnnathpur Temple", true);
        }
        public void ClickOnNextbtnforIncomeAssetsPage()
        {
            Click(nextbtnIncomeAssets);
        }
        public void ClickOnNextbtnForLiabilites()
        {
            Click(nextbtnLiabilites);
        }
        public void ClickOnLiabilityButton()
        {
            Click(liabilityBtn);
        }
        public void ClickOnLiblityDropdown()
        {
            Click(LiabilityDropBtn);
        }
        public void SelectLiability()
        {
            Click(LiabitityOption);
        }
        public void EnterBalanceAmtforLiability()
        {
            SendKeys(LiabityBalanceAmt, "2000", true);
        }
        public void ClickOnDropdownIcon()
        {
            Click(dropdownIcon);
        }
        public void EnterOrignalLoanAmount()
        {
            SendKeys(OrigalLoanAmt, "5000", true);
        }
        public void EnterPaymentAmount()
        {
            SendKeys(Paymentamt, "200", true);
        }
        public void EnterTermLiability()
        {
            SendKeys(monthlyTerms, "3", true);
        }
        public void EnterInterestRate()
        {
            SendKeys(interestrate, "3.5", true);
        }
        public void SpecialInterestRate()
        {
            Click(specialinterest);
        }
        public void SpecailInterestRateField()
        {
            SendKeys(sinterestrate, "2.5", true);
        }
        public void EnterYear()
        {
            Click(year);
            SendKeys(year, "2018", true);
            Click(year);
        }
        public void EnterMakeYear()
        {
            SendKeys(make, "Alta Motors", true);
        }
        public void SelectModel()
        {
            SendKeys(model, "Redshift MX", true);
        }
        public void NextlinkforSBO()
        {
            Click(nextforsbo);
        }
        public void PersonalLoanIcon()
        {
            Click(PersonalIcon);
        }
        public void PersonalLoanAmount()
        {
            SendKeys(PersoalLoan, "75000", true);
        }
        public void NextbtnlinkCoborrowerPersonal()
        {
            Click(nextbtnCobopersonal);
        }
        public void nextbtnlinkCoboOtherInfo()
        {
            Click(CoBoOtherInfo);
        }
    }
}
