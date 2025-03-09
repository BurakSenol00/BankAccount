namespace BankAccount
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOwner.Text))
            {
                return;
            }
            if (nupIntrentRate.Value > 0)
            {

                bankAccounts.Add(new SavingAccount(txtOwner.Text, nupIntrentRate.Value));
            }
            else
            {
                bankAccounts.Add(new BankAccount(txtOwner.Text));
            }

            RefreshGrid();
        }
        private void RefreshGrid()
        {
            bankAccountsGrid.DataSource = null;
            bankAccountsGrid.DataSource = bankAccounts;
            txtOwner.Text = string.Empty;
            nupIntrentRate.Value = 0;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (bankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = bankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(nupAmount.Value);
                RefreshGrid();
                nupAmount.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            if (bankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = bankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Withrow(nupAmount.Value);
                RefreshGrid();
                nupAmount.Value = 0;
                MessageBox.Show(message);
            }

        }
    }

}
