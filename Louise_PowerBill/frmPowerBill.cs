/**
 * Program: Power Bill Calculator
 * Course Module: CPRG 200 OOSD
 * Purpose: This calculates total bill for each type of customer (Residential, Industrial 
 *  and Commercial based on power usage in kWh)
 * Author: : Louise Acosta
 * Date: March 8, 2019
 **/

using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Louise_PowerBill
{
    public partial class frmPowerBill : Form
    {

        const string PATH = "customers.txt"; // TXT file located in bin/Debug folder
        static List<Customer> Customers;

        public frmPowerBill()
        {
            InitializeComponent();
        }

        // form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            radResidential.Checked = true; // default set to select residential
            txtAcctNo.Select(); // focus on usage input
            GetCustomers(); // get customers from file
            foreach (Customer customer in Customers)
            {
                lstCustomers.Items.Add(customer); // add customer to list
            }
                txtCount.Text = Customers.Count.ToString(); // display count
                txtResidential.Text = TotalResidentialCharges().ToString("c"); // display total charges for residential customers
                txtCommercial.Text = TotalCommercialCharges().ToString("c"); // display total charges for residential customers
                txtIndustrial.Text = TotalIndustrialCharges().ToString("c"); // display total charges for residential customers
                txtOverall.Text = OverallTotal().ToString("c"); // display overall total 
        }

        // calculate sum of charges for residential customers
        private double TotalResidentialCharges()
        {
            double sum = 0;
            foreach (Customer customer in Customers)
            {
                if (customer.Type == 'R')
                {
                    sum += customer.ChargeAmount;
                }
            }
            return Math.Round(sum,2);
        }

        // calculate sum of charges for commercial customers
        private double TotalCommercialCharges()
        {
            double sum = 0;
            foreach (Customer customer in Customers)
            {
                if (customer.Type == 'C')
                {
                    sum += customer.ChargeAmount;
                }
            }
            return Math.Round(sum,2);
        }

        // calculate sum of charges for industrial customers
        private double TotalIndustrialCharges()
        {
            double sum = 0;
            foreach (Customer customer in Customers)
            {
                if (customer.Type == 'I')
                {
                    sum += customer.ChargeAmount;
                }
            }
            return Math.Round(sum,2);
        }

        // calculate sum of charges for all customers
        private double OverallTotal()
        {
            double sum = 0;
            foreach (Customer customer in Customers)
            {

                sum += customer.ChargeAmount;

            }
            return Math.Round(sum,2);
        }

        // residential is selected
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            DefaultView(); // set to default view - hide industrial panel
        }

        // commercial is selected
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            DefaultView(); // set to default view - hide industrial panel
        }

        // industrial is selected
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            IndustrialView(); // set to industrial view - show industrial panel
        }

        // Calculate total bill based on kwh usage
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /**
             * Residentials = $0.052 per kWh usage + $6 flat rate
             * Commercial = $0.045 per kWh usage in excess of 1000kwh + $60 flat rate
             * Industrial - rate depends if usage occured during peak hours or off peak hours
             *        (peak hours) = $0.065 per kWh usage in excess of 1000kwh + $76 flat rate
             *        (off peak hours) = $0.028 per kWh usage in excess of 1000kWh + $40 flat rate
             **/

            // local declarations
            double usage; // input: kwh usage
            double offPeakUsage; // input: kwh usage for off peak hours
            txtBill.Text = "0.00"; // output: total bill

            char type; // input: customer type
            bool validInput = false;
            if (radResidential.Checked) { type = 'R';  } // if residential button selected, output type R
            else if(radCommercial.Checked) { type = 'C'; } // if residential button selected, output type C
            else if(radIndustrial.Checked) { type = 'I'; } // if residential button selected, output type I
            else { type = ' '; }


            // check input
            if (radResidential.Checked) // residential is selected
            {
                if (IsValidData()) //input is valid
                {
                    validInput = true;
                }
                    
            }

            else if (radCommercial.Checked) // commercial is selected
            {
                if (IsValidData()) // input is valid
                {
                    validInput = true;
                }
            }

            else if (radIndustrial.Checked) // industrial is selected
            {
                if (IndustrialIsValidData()) //input is valid             
                {
                    validInput = true;
                }
            }

            if (validInput)
            {   // new customer
                Customer customer = new Customer(Convert.ToInt16(txtAcctNo.Text), txtCustName.Text, type);

                if (radResidential.Checked || radCommercial.Checked)
                {
                    usage = Convert.ToDouble(txtUsage.Text);
                    offPeakUsage = 0;
                }
                else
                {
                    usage = Convert.ToDouble(txtPeakUsage.Text);
                    offPeakUsage = Convert.ToDouble(txtOffPeakUsage.Text);
                }
                customer.CalculateCharge(usage, offPeakUsage); 
                Customers.Add(customer); 
                lstCustomers.Items.Add(customer); 
                txtCount.Text = Customers.Count.ToString(); // display count
                txtResidential.Text = TotalResidentialCharges().ToString("c"); // display total charges for residential customers
                txtCommercial.Text = TotalCommercialCharges().ToString("c"); // display total charges for residential customers
                txtIndustrial.Text = TotalIndustrialCharges().ToString("c"); // display total charges for residential customers
                txtOverall.Text = OverallTotal().ToString("c"); // display overall total 

            // display results
            txtBill.Text = customer.ChargeAmount.ToString("c");
            }

        }


        // reset to initial state
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcctNo.Text = "";
            txtCustName.Text = "";
            txtUsage.Text = "";
            txtBill.Text = "";
            txtOffPeakUsage.Text = "";
            txtPeakUsage.Text = "";

            radResidential.Checked = true; // select Residential
            txtUsage.Select(); // focus on usage input
        }

        // terminate execution
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // close and terminate
        }


        // METHODS
        private void DefaultView()
        {
            pnlindustrial.Visible = false; // hide peak and off peak usage (for industrial) panel
            pnlUsage.Visible = true; // show kwh usage input
            txtAcctNo.Select(); // focus on usage input
            txtBill.Text = ""; // clear total bill textbox
        }

        private void IndustrialView()
        {
            pnlindustrial.Visible = true; // show peak and off peak usage panel
            pnlUsage.Visible = false; // hide usage input for residential and commercial
            txtAcctNo.Select(); // focus on usage input
            txtBill.Text = ""; // clear total bill textbox
        }

        // data validation for residential and commercial customer type
        public bool IsValidData()
        {
            return
                Validator.IsProvided(txtAcctNo, "Account Number") &&
                Validator.IsInteger(txtAcctNo, "Account Number") &&
                Validator.IsProvided(txtCustName, "Customer Name") &&
                Validator.IsNonNegativeDouble(txtAcctNo, "Account Number") &&
                Validator.IsProvided(txtUsage, "Usage") &&
                Validator.IsNonNegativeDouble(txtUsage, "Usage");
        }

        // data validation for industrial customer type
        public bool IndustrialIsValidData() 
        {
            return
                Validator.IsProvided(txtAcctNo, "Account Number") &&
                Validator.IsInteger(txtAcctNo, "Account Number") &&
                Validator.IsProvided(txtCustName, "Customer Name") &&
                Validator.IsNonNegativeDouble(txtAcctNo, "Account Number") &&
                Validator.IsProvided(txtPeakUsage, "Usage during peak hours") &&
                Validator.IsNonNegativeDouble(txtPeakUsage, "Usage during peak hours") &&
                Validator.IsProvided(txtOffPeakUsage, "Usage during off peak hours") &&
                Validator.IsNonNegativeDouble(txtOffPeakUsage, "Usage for off peak hours");
        }

        
        public static List<Customer> GetCustomers()
        {
            Customers = new List<Customer>(); // empty list
            FileStream fs = null;
            StreamReader sr = null;
            string line;
            string[] columns;
            Customer customer; 
            try
            {
                fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                // read products from the file
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine(); // read a line
                    columns = line.Split(','); // split it into fields
                    // accountNumber,name,type,chargeAmount
                    int accountNumber = Convert.ToInt16(columns[0]); // column 0 is account number
                    string name = columns[1]; // column 1 is customer name
                    char type = columns[2][0]; // column 2 is customer type
                    customer = new Customer(accountNumber, name, type); // create product object
                    customer.ChargeAmount = Convert.ToDouble(columns[3]); // column 3 is charge amount
                    Customers.Add(customer); // add to  the list
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle 
            }
            finally // close the file if open
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            return Customers;
        }

        // save customer data to the list
        public static void SaveCustomers()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(PATH, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                
                foreach (Customer customer in Customers)
                {
                    sw.WriteLine(customer.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
        }

        // just before the form closes, save customers data
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving customers: " + ex.Message,
                    ex.GetType().ToString());
            }
        }
        // END METHODS

    } // end form
} // end name space 
