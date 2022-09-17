//Slade Knepp

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knepp_Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByInvoiceIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoicesTableAdapter.FillByInvoiceID(this.mMABooksDataSet.Invoices, ((int)(System.Convert.ChangeType(invoiceIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter an Interger!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": "
                    + ex.Message, ex.GetType().ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.InvoiceLineItems' table. You can move, or remove it, as needed.
            this.invoiceLineItemsTableAdapter.Fill(this.mMABooksDataSet.InvoiceLineItems);

        }

        private void invoiceLineItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.invoicesTableAdapter.FillByInvoiceID(this.mMABooksDataSet.Invoices, ((int)(System.Convert.ChangeType(invoiceIDToolStripTextBox.Text, typeof(int)))));
            }
            //edit the catch statements
            catch (FormatException)
            {
                MessageBox.Show("You must enter an Interger!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": "
                    + ex.Message, ex.GetType().ToString());
            }
        }

        private void fillByInvoiceIDToolStripButton1_Click(object sender, EventArgs e)
        {
        }
    }
}
