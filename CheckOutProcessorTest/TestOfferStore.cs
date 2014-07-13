using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CheckOutProcessor;
using NUnit.Framework;

namespace CheckOutProcessorTest
{
    [TestFixture]
    public class TestOfferStore
    {


        [Test]
        public void Test_Add_OfferData_To_Store_Returns_Applicable_Offer()
        {
            var classUnderTest = new CheckOutProcessor.OfferStore();
            classUnderTest.Add(new OfferData
                {
                    SkuId = "A",
                    OfferEligibiltyCount = 3,
                    OfferAmount = 20
                });
            Assert.AreEqual(20,classUnderTest.GetOfferAmount("A",3));
        }

        [Test]
        public void Test_OfferStore_Not_Apply_If_EligiblityCountNotPassed()
        {
            var classUnderTest = new CheckOutProcessor.OfferStore();
            classUnderTest.Add(new OfferData
            {
                SkuId = "A",
                OfferEligibiltyCount = 3,
                OfferAmount = 20
            });
            Assert.AreEqual(0, classUnderTest.GetOfferAmount("A", 2));
        }


        [Test]
        public void Test_Add_OfferData_To_Store_Returns_Applicable_Offer_If_MuliplesOf_Eligible_Count_Passed()
        {
            var classUnderTest = new CheckOutProcessor.OfferStore();
            classUnderTest.Add(new OfferData
            {
                SkuId = "A",
                OfferEligibiltyCount = 3,
                OfferAmount = 20
            });
            Assert.AreEqual(40, classUnderTest.GetOfferAmount("A", 6));
        }

    }
}

