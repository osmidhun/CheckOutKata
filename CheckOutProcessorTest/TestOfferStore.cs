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
        public void Test_Add_OfferDataToStoreReturnsApplicableOffer()
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

    }
}

