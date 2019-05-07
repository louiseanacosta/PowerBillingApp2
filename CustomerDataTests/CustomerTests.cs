/**
 * Program: Power Bill Calculator
 * Course Module: CPRG 200 OOSD
 * Purpose: This includes Test Methods for Calculate Charge of Customer Class
 * Author: : Louise Acosta
 * Date: March 8, 2019
 **/
 
 using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        
        [TestMethod()]
        // residential usage is positive
        public void ResidentialPositiveUsage()
        {
            //arrange
            double usage = 100;
            double offPeakUsage = 0;
            double expectedCharge = 11.20;
            double actualCharge;

            Customer cust = new Customer('R'); // reference
            cust.CalculateCharge(usage, offPeakUsage);

            //act
            actualCharge = cust.ChargeAmount;

            // assert
            Assert.AreEqual(actualCharge,expectedCharge);

        }

        [TestMethod()]
        // residential usage is negative
        public void ResidentialNegativeUsage()
        {
            //arrange
            double usage = -100;
            double offPeakUsage = 0;
            double expectedCharge = 0;
            double actualCharge;

            Customer cust = new Customer('R'); // reference
            cust.CalculateCharge(usage, offPeakUsage);

            //act
            actualCharge = cust.ChargeAmount;

            // assert
            Assert.AreEqual(actualCharge, expectedCharge);

        }


        [TestMethod()]
        // commercial usage is below base (1000)
        public void CommercialBelowBase()
        {
            //arrange
            double usage = 100;
            double offPeakUsage = 0;
            double expectedCharge = 60;
            double actualCharge;
            Customer cust = new Customer('C'); // reference
            cust.CalculateCharge(usage, offPeakUsage);

            //act
            actualCharge = cust.ChargeAmount;

            // assert
            Assert.AreEqual(actualCharge, expectedCharge);
        }

        [TestMethod()]
        // commercial usage is above base (1000)
        public void CommercialAboveBase()
        {
            //arrange
            double usage = 2000;
            double offPeakUsage = 0;
            double expectedCharge = 105;
            double actualCharge;
            Customer cust = new Customer('C'); // reference
            cust.CalculateCharge(usage, offPeakUsage);

            //act
            actualCharge = cust.ChargeAmount;

            // assert
            Assert.AreEqual(actualCharge, expectedCharge);
        }

        [TestMethod()]
        // both peak and off peak usage below base
        public void IndustrialBelowBase() 
        {
            //arrange
            double usage = 100;
            double offPeakUsage = 500;
            double expectedCharge = 116;
            double actualCharge;
            Customer cust = new Customer('I'); // reference
            cust.CalculateCharge(usage, offPeakUsage);

            //act
            actualCharge = cust.ChargeAmount;

            // assert
            Assert.AreEqual(actualCharge, expectedCharge);
        }

        [TestMethod()]
        // both peak and off peak usage above base
        public void IndustrialAboveBase()
        {
            //arrange
            double usage = 2000;
            double offPeakUsage = 2750;
            double expectedCharge = 230;
            double actualCharge;
            Customer cust = new Customer('I'); // reference
            cust.CalculateCharge(usage, offPeakUsage);

            //act
            actualCharge = cust.ChargeAmount;

            // assert
            Assert.AreEqual(actualCharge, expectedCharge);
        }
    }
}