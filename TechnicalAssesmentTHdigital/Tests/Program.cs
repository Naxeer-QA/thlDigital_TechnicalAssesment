using NUnit.Framework;
using TechnicalAssesmentTHdigital.Global;
using TechnicalAssesmentTHdigital.WebPages.HomePage.Features;

namespace TechnicalAssesmentTHdigital
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        [Test]
        public void SuccessfulSearch()
        {
            Base bs = new Global.Base();
            bs.Initialize();
            Booking bk = new Booking();
            bk.SearchSuccess();
            bs.Terminate();
        }
        
        [Test]//Created this test to play the calendar
        public void ChooseDates()
        {
            Base bs = new Global.Base();
            bs.Initialize();
            Booking bk = new Booking();
            bk.selectDates();
            bs.Terminate();
        }

        [Test]//It will fail because some actions under this method is commented
        public void Validate()
        {
            Base bs = new Global.Base();
            bs.Initialize();
            Booking bk = new Booking();
            bk.ErrorMessages(); // some actions under this method is commented
            bs.Terminate();
        }

    }
}
