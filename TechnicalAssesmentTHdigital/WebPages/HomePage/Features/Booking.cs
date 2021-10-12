using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace TechnicalAssesmentTHdigital.WebPages.HomePage.Features
{
    class Booking
    {
        //Constructor created to initialize below web element objects
        public Booking()
        {
            PageFactory.InitElements(Global.Base.driver, this);
        }
        #region Booking locators
        //Click to expand destinations
        [FindsBy(How = How.XPath, Using = "//select[@id = 'form_country__main']/option[text() = 'Choose your destination']")]
        public IWebElement chooseDestField { get; set; }

        //Select the country from the dropdown
        [FindsBy(How = How.XPath, Using = "//select[@id = 'form_country__main']/option[3]/../../ul[@class = 'options open']/li[text()='New Zealand']")]
        public IWebElement selectCountry { get; set; }

        //Click to open calendar for pick up
        [FindsBy(How = How.XPath, Using = "//form[@id = 'form_main']/div[2]/div/button[@class = '[ formControl form_datePicker_pickUp ]']")]
        public IWebElement pickUpDate { get; set; }

        //Click to open calendar for drop off
        [FindsBy(How = How.XPath, Using = "//form[@id = 'form_main']/div[3]/div/button[@class = '[ formControl form_datePicker_dropOff ]']")]
        public IWebElement dropOffDate { get; set; }

        //Click to select the calendar
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//table[@class = 'ui-datepicker-calendar']")]
        public IWebElement selectCalendar { get; set; }

        //Click to expand Pick up locations
        [FindsBy(How = How.XPath, Using = "//select[@id = 'form_location_pickUp__main']/../div[text()='Pick Up Location']")]
        public IWebElement pickUpLocation { get; set; }

        //Click to select Pick up locations
        [FindsBy(How = How.XPath, Using = ".//ul[(@class = 'options open')]/../../../.././div[5]//select[@id = 'form_location_pickUp__main']")]
        public IWebElement pickUpLocationDropdown { get; set; }

        //Click to expand drop off locations
        [FindsBy(How = How.XPath, Using = "//select[@id = 'form_location_dropOff__main']/../div[text()='Drop Off Location']")]
        public IWebElement dropOffLocation { get; set; }

        //Click to select drop off locations
        [FindsBy(How = How.XPath, Using = ".//ul[(@class = 'options open')]/../../../.././div[6]//select[@id = 'form_location_dropOff__main']")]
        public IWebElement dropOffLocationDropdown { get; set; }

        //Click to expand Passengers
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup uneven passengers ][ fromMars ]']")]
        public IWebElement Passengers { get; set; }

        //Click to expand Adults dropdown
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup odd adults ][ uptoMars ]']")]
        public IWebElement clickAdults { get; set; }

        //Click to select Adult dropdown
        [FindsBy(How = How.XPath, Using = ".//ul[(@class = 'options open')]/../../../.././div[8]//select[@id = 'form_adults__main']")]
        public IWebElement adultDropDown { get; set; }

        //Click to expand Child dropdown
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup even children ][ uptoMars ]']")]
        public IWebElement clickChild { get; set; }

        //Click to select child dropdown
        [FindsBy(How = How.XPath, Using = ".//ul[(@class = 'options overflowing open')]/../../../.././div[9]//select[@id = 'form_children__main']")]
        public IWebElement childDropDown { get; set; }

        //Click to expand Driver Licence dropdown
        [FindsBy(How = How.XPath, Using = "//div[@id = 'form_licence__main_chosen']")]
        public IWebElement driversLicence { get; set; }

        //Click to type in chosen search field from Driver Licence dropdown
        [FindsBy(How = How.XPath, Using = "//div[@id = 'form_licence__main_chosen']//input[@type = 'text']")]
        public IWebElement chooseOption { get; set; }

        //Click to type in Promo Code
        [FindsBy(How = How.XPath, Using = "//form[@id = 'form_main']//div[11]//input[@id = 'form_promo__main']")]
        public IWebElement enterPromoCode { get; set; }

        //Click Search button
        [FindsBy(How = How.XPath, Using = "//form[@id = 'form_main']//button[@class = '[ btnPrimary ][ submit ]']")]
        public IWebElement searchBtn { get; set; }
        #endregion

        #region Calendar locators for pickup

        //Click to select the calendar
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//table[@class = 'ui-datepicker-calendar']")]
        public IWebElement calendarPicker { get; set; }

        //Click to move to next month
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//a[@title = 'Next']")]
        public IWebElement forwardBtn { get; set; }

        //Click to move to previous month
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//a[@title = 'Prev']")]
        public IWebElement backBtn { get; set; }

        //Check the Month
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//div[@class = 'ui-datepicker-title']/span[@class = 'ui-datepicker-month']")]
        public IWebElement datePickerMonth { get; set; }

        //Check the Year
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//div[@class = 'ui-datepicker-title']/span[@class = 'ui-datepicker-year']")]
        public IWebElement datePickerYear { get; set; }

        //Check the element Month&Year
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//div[@class = 'ui-datepicker-title']")]
        public IWebElement ele_Month_Year { get; set; }

        #endregion

        #region Calendar locators for drop off

        //Click to select the calendar
        [FindsBy(How = How.XPath, Using = "//form[@id = 'form_main']/div[4]//table[@class = 'ui-datepicker-calendar']")]
        public IWebElement calendarPicker_dropOff { get; set; }

        //Click to move to next month
        [FindsBy(How = How.XPath, Using = "//div[@id = 'datepicker__main']//a[@title = 'Next']")]
        public IWebElement forwardBtn_dropOff { get; set; }

        #endregion

        #region Perform successful search
        public void SearchSuccess()
        {
            chooseDestField.Click();
            selectCountry.Click();
            selectDates();
            SelectPickUp_DropOffLoc();
            SelectPassengers();
            EnterLicenceDetails();
            searchBtn.Click();
            System.Threading.Thread.Sleep(5000);
        }
        #endregion

        #region Choose dates from calendar
        public void selectDates()
        {
            //chooseDestField.Click();
            //selectCountry.Click();
            Global.SyncHelpers sh = new Global.SyncHelpers();
            Global.Base bs = new Global.Base();
            bs.PageScrollDown();
            sh.waitUntilClickable(Global.Base.driver, pickUpDate);
            pickUpDate.Click();
            WebDriverWait wait = new WebDriverWait(Global.Base.driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(
                "//div[@id = 'datepicker__main']//table[@class = 'ui-datepicker-calendar']")));
            sh.waitUntilClickable(Global.Base.driver, forwardBtn);
            forwardBtn.Click();
            //backBtn.Click();
            IWebElement DataWidget = Global.Base.driver.FindElement(By.XPath(
                "//div[@id = 'datepicker__main']//table[@class = 'ui-datepicker-calendar']"));
            IList<IWebElement> rows = DataWidget.FindElements(By.TagName("tr"));
            IList<IWebElement> columns = DataWidget.FindElements(By.TagName("td"));
            for(int i = 0; i < columns.Count; i++)
            {
                if (columns[i].Text.Equals("20"))
                {
                    columns[i].FindElement(By.LinkText("20")).Click();
                    break;
                }
            }
            Thread.Sleep(2000);
            sh.waitUntilClickable(Global.Base.driver, forwardBtn);
            forwardBtn.Click();
            try
            {
                IWebElement selectDropOff = Global.Base.driver.FindElement(By.XPath(
                    "//form[@id = 'form_main']/div[4]//table[@class = 'ui-datepicker-calendar']//td/a[text()='29']"));
                selectDropOff.Click();
                /*
                IWebElement DataWidgets = Global.Base.driver.FindElement(By.XPath(
                "//form[@id = 'form_main']/div[4]//table[@class = 'ui-datepicker-calendar']"));
                sh.stalenessOf(Global.Base.driver, DataWidgets);
                IList<IWebElement> rowss = DataWidget.FindElements(By.TagName("tr"));
                IList<IWebElement> columnss = DataWidget.FindElements(By.TagName("td"));

                for (int i = 0; i < columns.Count; i++)
                {
                    if (columns[i].Text.Equals("15"))
                    {
                        System.Threading.Thread.Sleep(5000);
                        columns[i].FindElement(By.LinkText("15")).Click();
                        break;
                    }
                }*/
            }
            catch (StaleElementReferenceException sere)
            {
                Console.WriteLine("Stale element exception occurred");
            }
            
        }
        #endregion
        public void SelectPickUp_DropOffLoc()
        {
            pickUpLocation.Click();
            SelectElement se = new SelectElement(pickUpLocationDropdown);
            se.SelectByIndex(1);
            dropOffLocation.Click();
            SelectElement select = new SelectElement(dropOffLocationDropdown);
            select.SelectByIndex(3);
        }

        public void SelectPassengers()
        {
            Passengers.Click();
            clickChild.Click();
            SelectElement se = new SelectElement(childDropDown);
            se.SelectByValue("3");
            clickAdults.Click();
            SelectElement select = new SelectElement(adultDropDown);
            select.SelectByValue("3");
        }

        public void EnterLicenceDetails()
        {
            driversLicence.Click();
            chooseOption.SendKeys("New Zealand");
            chooseOption.SendKeys(Keys.Down);
            chooseOption.SendKeys(Keys.Return);
            enterPromoCode.SendKeys("12345");
        }

        #region Web Element Locators from Modal Underlay

        //Click to Perfrom booking from Modal Underlay
        [FindsBy(How = How.XPath, Using = "//div[@id = 'nav']//button[@class = '[ btnPrimary ][ navToggle navToggleBooking ]']")]
        public IWebElement BookBtn { get; set; }

        //Click to expand destinations from Modal Underlay
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ bookingComponent countrySelectionWrapper bc-id_alt ]']//div[text()='Choose your destination']")]
        public IWebElement chooseDest_Modal { get; set; }

        //Select the country from the dropdown
        //[FindsBy(How = How.XPath, Using = ".//ul[@class = 'options open']/../../../../../div[@class = '[ bookingComponent countrySelectionWrapper bc-id_alt ]']")]
        [FindsBy(How = How.XPath, Using = "//select[@id = 'form_country__alt']/option[3]/../../ul[@class = 'options open']/li[text()='Australia']")]
        public IWebElement selectCountry_Modal { get; set; }

        //Click to perform search
        [FindsBy(How = How.XPath, Using = "//form[@id = 'form_alt']//button[@class = '[ btnPrimary ][ submit ] ']")]

        public IWebElement searchBtn_Modal { get; set; }

        //Xpath for pick up error message
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup odd pickCal ] invalid']//span[@class = '[ invalidNote ]']")]

        public IWebElement ErrorMsg_pickUp_Modal { get; set; }

        //Xpath for drop off error message
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup even dropCal disabled ] invalid']//span[@class = '[ invalidNote ]']")]

        public IWebElement ErrorMsg_dropOff_Modal { get; set; }

        //Xpath for Location pick up error message
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup odd pickLoc ] invalid']//span[@class = '[ invalidNote ]']")]

        public IWebElement ErrorMsg_LocationPickup_Modal { get; set; }

        //Xpath for Location drop off error message
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup even dropLoc ] invalid']//span[@class = '[ invalidNote ]']")]

        public IWebElement ErrorMsg_LocationDropOff_Modal { get; set; }

        //Xpath for driver licence error message
        [FindsBy(How = How.XPath, Using = "//div[@class = '[ formGroup odd licence ] invalid']//span[@class = '[ invalidNote ]']")]

        public IWebElement ErrorMsg_DriverLicence_Modal { get; set; }
        #endregion

        public void ErrorMessages()
        {
            //BookBtn.Click();
            //chooseDest_Modal.Click();
            //selectCountry_Modal.Click();
            //searchBtn_Modal.Click();
            ValidatePickUpErrorCopy();
            ValidateDropOffErrorCopy();
            ValidatePickUpLocationErrorCopy();
            ValidateDropOffLocationErrorCopy();
            ValidateDLErrorCopy();
        }
        #region Methods for Error copies validation
        public void ValidatePickUpErrorCopy()
        {
            String ActualpickUpErrorMsg = ErrorMsg_pickUp_Modal.Text;
            String ExpectedErrorMsg = "Pick Up Date is required*";
            Assert.AreEqual(ExpectedErrorMsg, ActualpickUpErrorMsg);
            Console.WriteLine("Error message is :" + ActualpickUpErrorMsg);
        }
        public void ValidateDropOffErrorCopy()
        {
            String ActualdropOffErrorMsg = ErrorMsg_dropOff_Modal.Text;
            String expectedErrorMsg = "Drop Off Date is required*";
            Assert.AreEqual(expectedErrorMsg, ActualdropOffErrorMsg);
            Console.WriteLine("Error message is :" + ActualdropOffErrorMsg);
        }
        public void ValidatePickUpLocationErrorCopy()
        {
            String ActualpickUpLocationErrorMsg = ErrorMsg_LocationPickup_Modal.Text;
            String expectederrorMsg = "Pick Up Location is required*";
            Assert.AreEqual(expectederrorMsg, ActualpickUpLocationErrorMsg);
            Console.WriteLine("Error message is :" + ActualpickUpLocationErrorMsg);
        }

        public void ValidateDropOffLocationErrorCopy()
        {
            String ActualdropoffLocationErrorMsg = ErrorMsg_LocationDropOff_Modal.Text;
            String expectederrormsg = "Drop Off Location is required*";
            Assert.AreEqual(expectederrormsg, ActualdropoffLocationErrorMsg);
            Console.WriteLine("Error message is :" + ActualdropoffLocationErrorMsg);
        }
        public void ValidateDLErrorCopy()
        {
            String ActualDLErrorMsg = ErrorMsg_DriverLicence_Modal.Text;
            String expectedDLerrorMsg = "Drivers Licence is required*";
            Assert.AreEqual(expectedDLerrorMsg, ActualDLErrorMsg);
            Console.WriteLine("Error message is :" + ActualDLErrorMsg);
        }
        #endregion
    }

}
