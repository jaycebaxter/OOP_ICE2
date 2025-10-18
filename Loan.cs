using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise2
{
    internal class Loan
    {
        private int loanNumber;
        private string customerName;
        private string customerAddress;
        private double loanAmount;
        private double interestRate;
        private int loanDuration;

        public void setLoanNumber(int loanNumber)
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
    }
}
