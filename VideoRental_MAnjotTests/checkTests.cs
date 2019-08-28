using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRental_MAnjot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_MAnjot.Tests
{
    [TestClass()]
    public class checkTests
    {
        [TestMethod()]
        public void srchCustomerIDTest()
        {
            try
            {
                check obj = new check();
                obj.generateRent("25/08/2019", 3);
            }
            catch (Exception ex)
            {

                Assert.Fail();
            }
        }
    }
}