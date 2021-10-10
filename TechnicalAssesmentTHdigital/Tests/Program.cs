using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssesmentTHdigital.Global;

namespace TechnicalAssesmentTHdigital
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        [Test]
        public void Test()
        {
            Base bs = new Global.Base();
            bs.Initialize();
            bs.Terminate();
        }

        
    }
}
