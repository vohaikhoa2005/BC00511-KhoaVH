namespace newform2
{
    public partial class Form1 : Form
    {
        public Invoice invoiceManager;

        public Form1()
        {
            InitializeComponent();
            invoiceManager = new Invoice();

            addInvoice.InvoiceManager = invoiceManager;
            manageInvoices.InvoiceManager = invoiceManager;

            addInvoice.Show();
            manageInvoices.Hide();
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Show();
            addInvoice.Hide();
            manageInvoices.RefreshInvoiceList();
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Hide();
            addInvoice.Show();
        }
    }
}
