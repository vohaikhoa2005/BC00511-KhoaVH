namespace newform2
{
    partial class AddInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            kjhkh = new Label();
            customerCodeInput = new TextBox();
            customerNameInput = new TextBox();
            numberOfPeopleInput = new TextBox();
            lastMonthNumberInput = new TextBox();
            thisMonthNumberInput = new TextBox();
            customerTypeCombobox = new ComboBox();
            currentMonthCombobox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comsumptionLabel = new Label();
            priceLabel = new Label();
            subtotalLabel = new Label();
            envFeeLabel = new Label();
            VATLabel = new Label();
            totalLabel = new Label();
            calculateButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Code";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 36);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = " Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 36);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 1;
            label3.Text = "Type Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 129);
            label5.Name = "label5";
            label5.Size = new Size(189, 15);
            label5.TabIndex = 1;
            label5.Text = "Last month’s water meter readings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 129);
            label6.Name = "label6";
            label6.Size = new Size(189, 15);
            label6.TabIndex = 1;
            label6.Text = "This month’s water meter readings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 129);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 1;
            label4.Text = "Number of people";
            label4.Click += label4_Click;
            // 
            // kjhkh
            // 
            kjhkh.AutoSize = true;
            kjhkh.Location = new Point(16, 210);
            kjhkh.Name = "kjhkh";
            kjhkh.Size = new Size(93, 15);
            kjhkh.TabIndex = 2;
            kjhkh.Text = "Current Mounth";
            kjhkh.Click += kjhkh_Click;
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(16, 69);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(193, 23);
            customerCodeInput.TabIndex = 3;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(252, 69);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(193, 23);
            customerNameInput.TabIndex = 3;
            customerNameInput.TextChanged += textBox2_TextChanged;
            // 
            // numberOfPeopleInput
            // 
            numberOfPeopleInput.Location = new Point(16, 164);
            numberOfPeopleInput.Name = "numberOfPeopleInput";
            numberOfPeopleInput.Size = new Size(193, 23);
            numberOfPeopleInput.TabIndex = 3;
            // 
            // lastMonthNumberInput
            // 
            lastMonthNumberInput.Location = new Point(252, 164);
            lastMonthNumberInput.Name = "lastMonthNumberInput";
            lastMonthNumberInput.Size = new Size(193, 23);
            lastMonthNumberInput.TabIndex = 3;
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(521, 164);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(193, 23);
            thisMonthNumberInput.TabIndex = 3;
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.DropDownWidth = 300;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(521, 69);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(193, 23);
            customerTypeCombobox.TabIndex = 4;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(16, 248);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(193, 23);
            currentMonthCombobox.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 210);
            label7.Name = "label7";
            label7.Size = new Size(142, 15);
            label7.TabIndex = 5;
            label7.Text = "Amount of consumption:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(252, 337);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 5;
            label8.Text = "VAT(10%)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(252, 383);
            label9.Name = "label9";
            label9.Size = new Size(77, 32);
            label9.TabIndex = 5;
            label9.Text = "Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(252, 237);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 5;
            label10.Text = "Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(252, 267);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 5;
            label11.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(252, 301);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 5;
            label12.Text = "Environment Fees";
            // 
            // comsumptionLabel
            // 
            comsumptionLabel.Location = new Point(400, 210);
            comsumptionLabel.Name = "comsumptionLabel";
            comsumptionLabel.Size = new Size(71, 15);
            comsumptionLabel.TabIndex = 5;
            comsumptionLabel.Text = "0";
            comsumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(294, 237);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(177, 15);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Location = new Point(307, 267);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(164, 15);
            subtotalLabel.TabIndex = 5;
            subtotalLabel.Text = "0";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envFeeLabel
            // 
            envFeeLabel.Location = new Point(359, 301);
            envFeeLabel.Name = "envFeeLabel";
            envFeeLabel.Size = new Size(112, 15);
            envFeeLabel.TabIndex = 5;
            envFeeLabel.Text = "0";
            envFeeLabel.TextAlign = ContentAlignment.MiddleRight;
            envFeeLabel.Click += label16_Click;
            // 
            // VATLabel
            // 
            VATLabel.Location = new Point(314, 337);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(157, 15);
            VATLabel.TabIndex = 5;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            VATLabel.Click += label16_Click;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            totalLabel.Location = new Point(325, 383);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(146, 32);
            totalLabel.TabIndex = 5;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            totalLabel.Click += label16_Click;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.IndianRed;
            calculateButton.Location = new Point(521, 210);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(222, 65);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            calculateButton.MouseHover += calculateButton_MouseHover;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.AppWorkspace;
            saveButton.Location = new Point(554, 282);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(156, 53);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // AddInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(saveButton);
            Controls.Add(calculateButton);
            Controls.Add(totalLabel);
            Controls.Add(VATLabel);
            Controls.Add(envFeeLabel);
            Controls.Add(label12);
            Controls.Add(subtotalLabel);
            Controls.Add(label11);
            Controls.Add(priceLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comsumptionLabel);
            Controls.Add(label7);
            Controls.Add(currentMonthCombobox);
            Controls.Add(customerTypeCombobox);
            Controls.Add(customerNameInput);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(lastMonthNumberInput);
            Controls.Add(numberOfPeopleInput);
            Controls.Add(customerCodeInput);
            Controls.Add(kjhkh);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoice";
            Size = new Size(832, 455);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label kjhkh;
        private TextBox customerCodeInput;
        private TextBox customerNameInput;
        private TextBox numberOfPeopleInput;
        private TextBox lastMonthNumberInput;
        private TextBox thisMonthNumberInput;
        private ComboBox customerTypeCombobox;
        private ComboBox currentMonthCombobox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label comsumptionLabel;
        private Label priceLabel;
        private Label subtotalLabel;
        private Label envFeeLabel;
        private Label VATLabel;
        private Label totalLabel;
        private Button calculateButton;
        private Button saveButton;
    }
}
