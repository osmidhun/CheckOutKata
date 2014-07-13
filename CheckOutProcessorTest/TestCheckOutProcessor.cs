using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace CheckOutProcessorTest
{
    [TestFixture]
    public class TestCheckOutProcessor
    {
  

        [Test]
        public void Test_CheckOut_Method_Returns_Total_Of_SKU()
        {
            var classUnderTest = new CheckOutProcessor.CheckOutProcessor();
            var total = classUnderTest.CheckOut("A", 50);
            Assert.AreEqual(50, total);
          total = classUnderTest.CheckOut("B", 60);
          Assert.AreEqual(110, total);
          total = classUnderTest.CheckOut("C", 10);
          Assert.AreEqual(120, total);
        }

        [Test]
        public void Test_SpecialOffer_When_Tree_Times_SKU_A_CheckedOut_20_Offer()
        {
            var classUnderTest = new CheckOutProcessor.CheckOutProcessor();
            var total = classUnderTest.CheckOut("A", 50);
            Assert.AreEqual(50, total);
            total = classUnderTest.CheckOut("A", 50);
            Assert.AreEqual(100, total);
            total = classUnderTest.CheckOut("A", 50);
            Assert.AreEqual(130, total);
        }

    }
}

