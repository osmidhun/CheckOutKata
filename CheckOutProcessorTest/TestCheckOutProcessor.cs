using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CheckOutProcessor;
using NUnit.Framework;


namespace CheckOutProcessorTest
{
    [TestFixture]
    public class TestCheckOutProcessor
    {
        public CheckOutProcess ClassUnderTest { get; set; }

  
        [SetUp]
        public void SetUp()
        {
            var offerStore = new OfferStore();
            offerStore.Add(new OfferData
                {
                    SkuId = "A",
                    OfferEligibiltyCount = 3,
                    OfferAmount = 20
                     
                    
                });
            offerStore.Add(new OfferData
            {
                SkuId = "B",
                OfferEligibiltyCount = 2,
                OfferAmount = 15


            });
            ClassUnderTest = new CheckOutProcess(offerStore);
        }

        [TestCase("A",50,1,50)]
        [TestCase("A",50,2,100)]
        [TestCase("A",50,3,130)]
        [TestCase("B",30,1,30)]
        [TestCase("B",30,2,45)]
        [TestCase("C",60,1,60)]
        [TestCase("D",99,1,99)]
        public void Test_CheckOut_Method_Returns_Total_Of_SKU(string skuId,decimal price, int quantity,decimal totalExpectedPrice)
        {
            decimal total = 0;
           
            for (int i = 0; i < quantity; i++)
            {
                 total = ClassUnderTest.CheckOut(skuId, price);
            }

            Assert.AreEqual(totalExpectedPrice, total);
        }


        [Test]
        public void Test_SpecialOffer_For_SKU_A_3_For_20_Off_And_SKU_B_2_For15_Off()
        {
            var total = ClassUnderTest.CheckOut("A", 50);
            Assert.AreEqual(50, total);
            total = ClassUnderTest.CheckOut("A", 50);
            Assert.AreEqual(100, total);
            total = ClassUnderTest.CheckOut("A", 50);
            Assert.AreEqual(130, total);
            total = ClassUnderTest.CheckOut("B", 30);
            Assert.AreEqual(160, total);
            total = ClassUnderTest.CheckOut("B", 30);
            Assert.AreEqual(175, total);
           
        }
        [Test]
        public void Test_Mix_With_SpecialOffer_And_Non_Offers()
        {

            var total = ClassUnderTest.CheckOut("A", 50);
            Assert.AreEqual(50, total);
            total = ClassUnderTest.CheckOut("A", 50);
            Assert.AreEqual(100, total);
            total = ClassUnderTest.CheckOut("A", 50);
            Assert.AreEqual(130, total);
            total = ClassUnderTest.CheckOut("B", 30);
            Assert.AreEqual(160, total);
            total = ClassUnderTest.CheckOut("B", 30);
            Assert.AreEqual(175, total);
            total = ClassUnderTest.CheckOut("C", 60);
            Assert.AreEqual(235, total);
            total = ClassUnderTest.CheckOut("D", 99);
            Assert.AreEqual(334, total);
        }
    }
}

