namespace knepp_Assignment6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label productTotalLabel;
            System.Windows.Forms.Label salesTaxLabel;
            System.Windows.Forms.Label shippingLabel;
            System.Windows.Forms.Label invoiceTotalLabel;
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.shippingTextBox = new System.Windows.Forms.TextBox();
            this.invoiceTotalTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMABooksDataSet = new knepp_Assignment6.MMABooksDataSet();
            this.invoicesTableAdapter = new knepp_Assignment6.MMABooksDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new knepp_Assignment6.MMABooksDataSetTableAdapters.TableAdapterManager();
            this.fillByInvoiceIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.invoiceIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.invoiceIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByInvoiceIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineItemsTableAdapter = new knepp_Assignment6.MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            invoiceDateLabel = new System.Windows.Forms.Label();
            productTotalLabel = new System.Windows.Forms.Label();
            salesTaxLabel = new System.Windows.Forms.Label();
            shippingLabel = new System.Windows.Forms.Label();
            invoiceTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            this.fillByInvoiceIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(26, 43);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            invoiceDateLabel.TabIndex = 3;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // productTotalLabel
            // 
            productTotalLabel.AutoSize = true;
            productTotalLabel.Location = new System.Drawing.Point(26, 70);
            productTotalLabel.Name = "productTotalLabel";
            productTotalLabel.Size = new System.Drawing.Size(74, 13);
            productTotalLabel.TabIndex = 5;
            productTotalLabel.Text = "Product Total:";
            // 
            // salesTaxLabel
            // 
            salesTaxLabel.AutoSize = true;
            salesTaxLabel.Location = new System.Drawing.Point(26, 96);
            salesTaxLabel.Name = "salesTaxLabel";
            salesTaxLabel.Size = new System.Drawing.Size(57, 13);
            salesTaxLabel.TabIndex = 7;
            salesTaxLabel.Text = "Sales Tax:";
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Location = new System.Drawing.Point(26, 122);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new System.Drawing.Size(51, 13);
            shippingLabel.TabIndex = 9;
            shippingLabel.Text = "Shipping:";
            // 
            // invoiceTotalLabel
            // 
            invoiceTotalLabel.AutoSize = true;
            invoiceTotalLabel.Location = new System.Drawing.Point(28, 148);
            invoiceTotalLabel.Name = "invoiceTotalLabel";
            invoiceTotalLabel.Size = new System.Drawing.Size(72, 13);
            invoiceTotalLabel.TabIndex = 11;
            invoiceTotalLabel.Text = "Invoice Total:";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Enabled = false;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(106, 43);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 4;
            // 
            // productTotalTextBox
            // 
            this.productTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "ProductTotal", true));
            this.productTotalTextBox.Enabled = false;
            this.productTotalTextBox.Location = new System.Drawing.Point(106, 67);
            this.productTotalTextBox.Name = "productTotalTextBox";
            this.productTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.productTotalTextBox.TabIndex = 6;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "SalesTax", true));
            this.salesTaxTextBox.Enabled = false;
            this.salesTaxTextBox.Location = new System.Drawing.Point(106, 93);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesTaxTextBox.TabIndex = 8;
            // 
            // shippingTextBox
            // 
            this.shippingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Shipping", true));
            this.shippingTextBox.Enabled = false;
            this.shippingTextBox.Location = new System.Drawing.Point(106, 119);
            this.shippingTextBox.Name = "shippingTextBox";
            this.shippingTextBox.Size = new System.Drawing.Size(100, 20);
            this.shippingTextBox.TabIndex = 10;
            // 
            // invoiceTotalTextBox
            // 
            this.invoiceTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceTotal", true));
            this.invoiceTotalTextBox.Enabled = false;
            this.invoiceTotalTextBox.Location = new System.Drawing.Point(106, 145);
            this.invoiceTotalTextBox.Name = "invoiceTotalTextBox";
            this.invoiceTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceTotalTextBox.TabIndex = 12;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceLineItemsTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = knepp_Assignment6.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillByInvoiceIDToolStrip
            // 
            this.fillByInvoiceIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceIDToolStripLabel,
            this.invoiceIDToolStripTextBox,
            this.fillByInvoiceIDToolStripButton});
            this.fillByInvoiceIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByInvoiceIDToolStrip.Name = "fillByInvoiceIDToolStrip";
            this.fillByInvoiceIDToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByInvoiceIDToolStrip.TabIndex = 14;
            this.fillByInvoiceIDToolStrip.Text = "fillByInvoiceIDToolStrip";
            // 
            // invoiceIDToolStripLabel
            // 
            this.invoiceIDToolStripLabel.Name = "invoiceIDToolStripLabel";
            this.invoiceIDToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.invoiceIDToolStripLabel.Text = "InvoiceID:";
            // 
            // invoiceIDToolStripTextBox
            // 
            this.invoiceIDToolStripTextBox.Name = "invoiceIDToolStripTextBox";
            this.invoiceIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByInvoiceIDToolStripButton
            // 
            this.fillByInvoiceIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByInvoiceIDToolStripButton.Name = "fillByInvoiceIDToolStripButton";
            this.fillByInvoiceIDToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.fillByInvoiceIDToolStripButton.Text = "Get Invoice";
            this.fillByInvoiceIDToolStripButton.Click += new System.EventHandler(this.fillByInvoiceIDToolStripButton_Click);
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // invoiceLineItemsTableAdapter
            // 
            this.invoiceLineItemsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceLineItemsDataGridView
            // 
            this.invoiceLineItemsDataGridView.AllowUserToAddRows = false;
            this.invoiceLineItemsDataGridView.AllowUserToDeleteRows = false;
            this.invoiceLineItemsDataGridView.AllowUserToResizeColumns = false;
            this.invoiceLineItemsDataGridView.AllowUserToResizeRows = false;
            this.invoiceLineItemsDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.invoiceLineItemsDataGridView.DataSource = this.invoiceLineItemsBindingSource;
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(29, 208);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.ReadOnly = true;
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(438, 220);
            this.invoiceLineItemsDataGridView.TabIndex = 14;
            this.invoiceLineItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceLineItemsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "ItemTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(this.fillByInvoiceIDToolStrip);
            this.Controls.Add(invoiceTotalLabel);
            this.Controls.Add(this.invoiceTotalTextBox);
            this.Controls.Add(shippingLabel);
            this.Controls.Add(this.shippingTextBox);
            this.Controls.Add(salesTaxLabel);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(productTotalLabel);
            this.Controls.Add(this.productTotalTextBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            this.fillByInvoiceIDToolStrip.ResumeLayout(false);
            this.fillByInvoiceIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private MMABooksDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.TextBox productTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox shippingTextBox;
        private System.Windows.Forms.TextBox invoiceTotalTextBox;
        private System.Windows.Forms.ToolStrip fillByInvoiceIDToolStrip;
        private System.Windows.Forms.ToolStripLabel invoiceIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox invoiceIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByInvoiceIDToolStripButton;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

