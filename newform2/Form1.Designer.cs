namespace newform2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addInvoiceToolStripMenuItem = new ToolStripMenuItem();
            manageInvoicesToolStripMenuItem = new ToolStripMenuItem();
            manageInvoices = new ManageInvoices();
            addInvoice = new AddInvoice();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addInvoiceToolStripMenuItem, manageInvoicesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(812, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addInvoiceToolStripMenuItem
            // 
            addInvoiceToolStripMenuItem.Name = "addInvoiceToolStripMenuItem";
            addInvoiceToolStripMenuItem.Size = new Size(82, 20);
            addInvoiceToolStripMenuItem.Text = "Add Invoice";
            addInvoiceToolStripMenuItem.Click += addInvoiceToolStripMenuItem_Click;
            // 
            // manageInvoicesToolStripMenuItem
            // 
            manageInvoicesToolStripMenuItem.Name = "manageInvoicesToolStripMenuItem";
            manageInvoicesToolStripMenuItem.Size = new Size(108, 20);
            manageInvoicesToolStripMenuItem.Text = "Manage Invoices";
            manageInvoicesToolStripMenuItem.Click += manageInvoicesToolStripMenuItem_Click;
            // 
            // manageInvoices
            // 
            manageInvoices.InvoiceManager = null;
            manageInvoices.Location = new Point(0, 43);
            manageInvoices.Name = "manageInvoices";
            manageInvoices.Size = new Size(788, 411);
            manageInvoices.TabIndex = 1;
            // 
            // addInvoice
            // 
            addInvoice.InvoiceManager = null;
            addInvoice.Location = new Point(0, 27);
            addInvoice.Name = "addInvoice";
            addInvoice.Size = new Size(788, 431);
            addInvoice.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 450);
            Controls.Add(addInvoice);
            Controls.Add(manageInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Water Bill";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addInvoiceToolStripMenuItem;
        private ToolStripMenuItem manageInvoicesToolStripMenuItem;
        private ManageInvoices manageInvoices;
        private AddInvoice addInvoice;
    }
}
