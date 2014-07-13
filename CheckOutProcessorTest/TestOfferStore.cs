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


        [TestCase ("A" ,3,3, 20,20) ]
        [TestCase ("A" ,3,2, 20,0) ]
        [TestCase ("A" ,3,6, 20,40) ]
        public void Test_Add_OfferData_To_Store_Returns_Applicable_Offer(string skuId,int eligibileCount,int acualCount,decimal offer,decimal expectedOffer)
        {
            var classUnderTest = new CheckOutProcessor.OfferStore();
            classUnderTest.Add(new OfferData
                {
                    SkuId = skuId,
                    OfferEligibiltyCount = eligibileCount,
                    OfferAmount = offer
                });
            Assert.AreEqual(expectedOffer,classUnderTest.GetOfferAmount(skuId,acualCount));
        }

     

    }
}

