/**
 * Program: Power Bill Calculator
 * Course Module: CPRG 200 OOSD
 * Purpose: This validates user input
 * Author: : Louise Acosta
 * Date: March 8, 2019
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Louise_PowerBill
{
    public static class Validator // static validation methods
    {
        /// <summary>
        /// Checks if content of text box is non-empty
        /// </summary>
        /// <param name="tb">Text box to check</param>
        /// <param name="name">Name to use in error message</param>
        /// <returns>Is it valid</returns>

        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; 
            if(tb.Text == "") // no input
            {
                result = false;
                MessageBox.Show("Please enter a value for " + name, "Input error");
                tb.Focus();
            }
            return result;
        }

        
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double val; 
            if (!Double.TryParse(tb.Text, out val)) // not a double
            {
                result = false;
                MessageBox.Show("Invalid input. " + name + " should be a number", "Input Error");
                tb.SelectAll(); // highlight content of the box for replacing
                tb.Focus();
            }
            else if (val < 0) // negative
            {
                result = false;
                MessageBox.Show("Invalid input. " + name + " should be 0 or greater.", "Input Error");
                tb.SelectAll(); // highlight content of the box for replacing
                tb.Focus();
            }
            return result;
        }

        public static bool IsInteger(TextBox tb, string name)
        {
            bool result = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val)) // not an integer
            {
                result = false;
                MessageBox.Show("Invalid input. " + name + " should be a number", "Input Error");
                tb.SelectAll(); // highlight content of the box for replacing
                tb.Focus();
            }
            return result;
        }

    } // end class
} // end namespace
