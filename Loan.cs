using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise2
{
    internal class Loan
    {
        private int LoanNumber;
        private string? CustomerName;
        private string? CustomerAddress;
        private double LoanAmount;
        private double InterestRate;
        private int LoanDuration;

        // Default constructor
        public Loan(int loanNumber, string customerName,string customerAddress, double loanAmount, double interestRate, int loanDuration)
            {
                SetLoanNumber(loanNumber);
                SetCustomerName(customerName);
                SetCustomerAddress(customerAddress);
                SetLoanAmount(loanAmount);
                SetInterestRate(interestRate);
                SetLoanDuration(loanDuration);
            }
            
         /// <summary>
         /// Setter for LoanNumber
         /// </summary>
         /// <param name="loanNumber"></param>
        public void SetLoanNumber(int loanNumber)
        {
            if (loanNumber > 0)
            {
                LoanNumber = loanNumber;
            }
            else
            {
                LoanNumber = 0;
            }
        }

        /// <summary>
        /// Getter for LoanNumber
        /// </summary>
        /// <returns> LoanNumber </returns>
        public int GetLoanNumber()
        {
            return LoanNumber;
        }

        /// <summary>
        /// Setter for CustomerName
        /// </summary>
        /// <param name="customerName"></param>
        public void SetCustomerName(string customerName)
        {
            CustomerName = customerName;
        }

        /// <summary>
        /// Getter for CustomerName
        /// </summary>
        /// <returns> CustomerName </returns>
        public string GetCustomerName()
        {
            return CustomerName;
        }

        /// <summary>
        /// Setter for CustomerAddress
        /// </summary>
        /// <param name="customerAddress"></param>
        public void SetCustomerAddress(string customerAddress)
        {
            CustomerAddress = customerAddress;
        }

        /// <summary>
        /// Getter for CustomerAddress
        /// </summary>
        /// <returns> CustomerAddress </returns>
        public string GetCustomerAddress()
        {
            return CustomerAddress;
        }

        /// <summary>
        /// Setter for LoanAmount
        /// </summary>
        /// <param name="loanAmount"></param>
        public void SetLoanAmount(double loanAmount)
        {
            if (loanAmount > 0)
            {
                LoanAmount = loanAmount;
            }

            else
            {
                LoanAmount = 0;
            }

        }

        /// <summary>
        /// Getter for LoanAmount
        /// </summary>
        /// <returns> LoanAmount </returns>
        public double GetLoanAmount()
        {
            return LoanAmount;
        }

        /// <summary>
        /// Setter for InterestRate
        /// </summary>
        /// <param name="interestRate"></param>
        public void SetInterestRate(double interestRate)
        {
            if (interestRate > 0)
            {
                InterestRate = interestRate;
            }

            else
            {
                InterestRate = 0;
            }
        }

        /// <summary>
        /// Getter for InterestRate
        /// </summary>
        /// <returns> InterestRate </returns>
        public double GetInterestRate()
        {
            return InterestRate;
        }

        /// <summary>
        /// Setter for LoanDuration
        /// </summary>
        /// <param name="loanDuration"></param>
        public void SetLoanDuration(int loanDuration)
        {
            if (loanDuration > 0)
            {
                LoanDuration = loanDuration;
            }
            else
            {
                LoanDuration = 0;
            }
        }

        /// <summary>
        /// Getter for LoanDuration
        /// </summary>
        /// <returns> LoanDuration </returns>
        public int GetLoanDuration()
        {
            return LoanDuration;
        }

        // Calculating the monthly payment
        public double CalculateMonthlyPayment()
        {

        }
    }
}
