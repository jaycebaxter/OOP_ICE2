using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassExercise2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Declaring new loan object
                Loan newLoan = new Loan();

                // Checking that LoanNumber is a whole number, as it will likely be an ID
                if (int.TryParse(TxtLoanNumberInput.Text, out int loanNumber))
                {
                    newLoan.SetLoanNumber(loanNumber);
                }
                else
                {
                    MessageBox.Show("Loan number must be a whole number");
                    return;
                }

                // Customer name and address do not require validation
                newLoan.SetCustomerName(TxtCustomerNameInput.Text);
                newLoan.SetCustomerAddress(TxtCustomerAddressInput.Text);

                // Checking that LoanAmount is a double
                if (double.TryParse(TxtLoanAmountInput.Text, out double loanAmount))
                {
                    newLoan.SetLoanAmount(loanAmount);
                }

                else
                {
                    MessageBox.Show("Loan amount must be a number");
                    return;
                }

                // Checking that InterestRate is a double
                if (double.TryParse(TxtInterestRateInput.Text, out double interestRate))
                {
                    newLoan.SetInterestRate(interestRate);
                }

                else
                {
                    MessageBox.Show("Interest rate must be a number");
                    return;
                }

                // Checking that LoanDuration is an int
                if (int.TryParse(TxtLoanDurationInput.Text, out int loanDuration))
                {
                    newLoan.SetLoanDuration(loanDuration);
                }

                else
                {
                    MessageBox.Show("Loan duration must be a number");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtLoanNumberInput.Text = "";
            TxtLoanNumberInput.IsReadOnly = false;

            TxtCustomerNameInput.Text = "";
            TxtCustomerNameInput.IsReadOnly = false;

            TxtCustomerAddressInput.Text = "";
            TxtCustomerAddressInput.IsReadOnly = false;

            TxtLoanAmountInput.Text = "";
            TxtLoanAmountInput.IsReadOnly = false;

            TxtInterestRateInput.Text = "";
            TxtInterestRateInput.IsReadOnly = false;

            TxtLoanDurationInput.Text = "";
            TxtLoanDurationInput.IsReadOnly = false;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}