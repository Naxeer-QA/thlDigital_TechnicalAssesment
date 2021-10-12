using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechnicalAssesmentTHdigital.WebPages.HomePage.Features;
using TechTalk.SpecFlow;

namespace TechnicalAssesmentTHdigital.StepDefinition
{
    [Binding]
    public class AutomatedScenariosSteps
    {
        IWebDriver driver;

        [Given(@"the user selects country from the destination field")]
        public void GivenTheUserSelectsCountryFromTheDestinationField()
        {
            Global.Base bs = new Global.Base();
            bs.Initialize();
            Booking bk = new Booking();
            bk.chooseDestField.Click();
            bk.selectCountry.Click();
        }
        
        [Given(@"selects pickup and dropoff dates")]
        public void GivenSelectsPickupAndDropoffDates()
        {
            Booking bk = new Booking();
            bk.selectDates();
        }
        
        [Given(@"enters pickup and dropoff lcoations")]
        public void GivenEntersPickupAndDropoffLcoations()
        {
            Booking bk = new Booking();
            bk.SelectPickUp_DropOffLoc();
        }
        
        [Given(@"the user clicks on Book button")]
        public void GivenTheUserClicksOnBookButton()
        {
            Global.Base bs = new Global.Base();
            bs.Initialize();
            Booking bk = new Booking();
            bk.BookBtn.Click();
        }
        
        [When(@"the user enters passenger details")]
        public void WhenTheUserEntersPassengerDetails()
        {
            Booking bk = new Booking();
            bk.SelectPassengers();
        }
        
        [When(@"enters Drivers licence")]
        public void WhenEntersDriversLicence()
        {
            Booking bk = new Booking();
            bk.EnterLicenceDetails();
        }
        
        [When(@"clicks on the search button")]
        public void WhenClicksOnTheSearchButton()
        {
            Booking bk = new Booking();
            bk.searchBtn.Click();
        }
        
        [When(@"the user enters detination in the input field")]
        public void WhenTheUserEntersDetinationInTheInputField()
        {
            Booking bk = new Booking();
            bk.chooseDest_Modal.Click();
            bk.selectCountry_Modal.Click();
        }
        
        [When(@"the user clicks Search button without entering any data")]
        public void WhenTheUserClicksSearchButtonWithoutEnteringAnyData()
        {
            Booking bk = new Booking();
            bk.searchBtn_Modal.Click();
        }
        
        [Then(@"the search result is shown")]
        public void ThenTheSearchResultIsShown()
        {
            Global.Base bs = new Global.Base();
            Thread.Sleep(5000);
            Assert.IsTrue(Global.Base.driver.PageSource.Contains("Search"));
            bs.Terminate();
        }
        
        [Then(@"underlay modal appears")]
        public void ThenUnderlayModalAppears()
        {
            Global.Base.driver.FindElement(By.XPath("//div[@class ='[ gutterPrimary clearfix ]']"));
        }
        
        [Then(@"the booking relevant component is shown")]
        public void ThenTheBookingRelevantComponentIsShown()
        {
            Global.Base.driver.FindElement(By.XPath("//form[@id = 'form_alt']"));
        }

        [Then(@"the error copies are shown")]
        public void ThenTheErrorCopiesAreShown()
        {
            Global.Base bs = new Global.Base();
            Booking bk = new Booking();
            bk.ErrorMessages();
            bs.Terminate();
        }
    }
}
