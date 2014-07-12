using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using BusinessProcessor;

namespace CheckOutProcessorTest
{
    [TestFixture]
    public class TestCheckOutProcessor
    {
  

        [Test]
        public void Test_CheckOut_Method_Returns_Total_Of_SKU()
        {
            var classUnderTest = new CheckOutProcessor();
            var total = classUnderTest.CheckOut("A", 50);
          Assert.AreEqual(total,50);
        }
    }
}

