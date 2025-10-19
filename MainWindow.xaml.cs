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
                Loan newLoan = new Loan();
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

            TxtLoanDuration.Text = "";
            TxtLoanDuration.IsReadOnly = false;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}