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
    public class Form1Tests
    {
        [TestMethod()]
        public void InsertTest()
        {
            try
            {
                Form1 obj = new Form1();
                obj.Insert("test");
            }
            catch (Exception ex)
            {

                Assert.Fail();
            }
        }

        [TestMethod()]
        public void DeleteTest()
        {
            try
            {
                Form1 obj = new Form1();
                obj.Delete("test");
            }
            catch (Exception ex)
            {

                Assert.Fail();
            }
        }
    }
}