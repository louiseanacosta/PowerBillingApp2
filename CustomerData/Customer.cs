/**
 * Program: Power Bill Calculator
 * Course Module: CPRG 200 OOSD
 * Purpose: This includes Customer Class for Power Bill Calculation Application
 * Author: : Louise Acosta
 * Date: March 8, 2019
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        // RESIDENTIAL CHARGES
        const double RES_RATE = 0.052; // rate per kwh 
        const double RES_FLAT = 6; // flat rate

        // COMMERCIAL CHARGES
        const double COM_RATE = 0.045; // rate per kwh in excess of 1000 
        const double COM_FLAT = 60; // flat rate

        // INDUSTRIAL CHARGES
        // peak hours
        const double PEAK_RATE = 0.065; // rate per kwh in excess of 1000 
        const double PEAK_FLAT = 76; // flat rate

        // off-peak hours
        const double OFFPEAK_RATE = 0.028;  // rate per kwh in excess of 1000 
        const double OFFPEAK_FLAT = 40;     // flat rate

        const double EXCESS_BASE = 1000; // kwh usage above this amount will be charged based on variable rate for commercial and industrial

        // private data
        private int accountNumber;
        private string name;
        private char type;
        private double chargeAmount;

        public Customer(char Type)
        {
            this.AccountNumber = 0;
            this.Name = "";
            this.Type = Type;
            this.ChargeAmount = 0;
        }

        public Customer(int AccountNumber, string Name, char Type)
        {
            this.AccountNumber = AccountNumber;
            this.Name = Name;
            this.Type = Type;
            this.ChargeAmount = 0;
        }
        //public properties
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }
        public char Type
        {
            get { return type; }
            set { type = value; }
        }
        public double ChargeAmount
        {
            get { return chargeAmount; }
            set { chargeAmount = value; }
        }

       
        // public methods
        public void CalculateCharge(double usage, double offPeakUsage)
        {
            if(usage >= 0)
            {
                if(this.type.Equals('R'))
                {
                    ChargeAmount = CalculateResidentialBill(usage);
                }
                else if(this.type.Equals('C'))
                {
                    ChargeAmount = CalculateCommercialBill(usage);
                }
                else if(this.type.Equals('I'))
                {
                    ChargeAmount = CalculateIndustrialBill(usage,offPeakUsage);
                }
            }
        }
        public override string ToString() 
        {
            // accountNumber,name,type,chargeAmount
            return AccountNumber + "," + Name + "," + Type + "," + ChargeAmount;

        }
        private double CalculateResidentialBill(double usage)
        {
            // obtain usage
            return (RES_RATE * usage) + RES_FLAT;
        }

        private double CalculateCommercialBill(double usage)
        {
            // obtain usage
            if (usage > EXCESS_BASE) // usage > 1000
            {
                return (COM_RATE * (usage - EXCESS_BASE)) + COM_FLAT;
            }
            else // usage <= 1000
            {
                return COM_FLAT;
            }
        }
        private double CalculateIndustrialBill(double peakUsage, double offPeakUsage)
        {
            // obtain usage
            double peakCharge = 0;
            double offPeakCharge = 0;

            if (peakUsage > EXCESS_BASE) // peak hour usage > 1000
            {
                peakCharge = (PEAK_RATE * (peakUsage - EXCESS_BASE)) + PEAK_FLAT;
            }
            else // peak hour usage <= 1000
            {
                peakCharge = PEAK_FLAT;
            }
            if (offPeakUsage > EXCESS_BASE) // off peak usage > 1000
            {
                offPeakCharge = (OFFPEAK_RATE * (offPeakUsage - EXCESS_BASE)) + OFFPEAK_FLAT;
            }
            else // off peak usage <=100
            {
                offPeakCharge = OFFPEAK_FLAT;
            }
            return peakCharge + offPeakCharge; // peak + off peak charges

        }

    }
}
