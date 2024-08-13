﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace newform2
{
    public partial class AddInvoice : UserControl
    {
        public Invoice InvoiceManager { get; set; }
        public AddInvoice()
        {
            InitializeComponent();
            customerTypeCombobox.SelectedItem = "Household customer";
            string currentMonth = DateTime.Now.Month.ToString();
            currentMonthCombobox.SelectedItem = currentMonth;
            numberOfPeopleInput.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kjhkh_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string messages = "";
            bool isValid = true;
            if (customerCodeInput.Text == "")
            {
                isValid = false;
                messages += "Please enter customer code!\n";
            }
            if (customerTypeCombobox.SelectedItem.ToString() == "Household customer")
            {
                if (Convert.ToInt32(numberOfPeopleInput.Text) <= 0)
                {
                    isValid = false;
                    messages += "Please enter valid number of people!\n";
                }

                if (!numberOfPeopleInput.Text.All(char.IsDigit))
                {
                    isValid = false;
                    messages += "Please enter valid number of people!\n";
                }
            }
            if (lastMonthNumberInput.Text == "" || !lastMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter valid last mounth number!\n";
            }
            if (thisMonthNumberInput.Text == "" || !thisMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter valid this mounth number!\n";
            }
            if ((isValid == false))
            {
                MessageBox.Show(messages);
                return;
            }


            string customerCode = customerCodeInput.Text;
            string customerName = customerNameInput.Text;
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            int numberOfPeople = Convert.ToInt32(numberOfPeopleInput.Text);
            int lastMonthNumber = Convert.ToInt32(lastMonthNumberInput.Text);
            int thisMonthNumber = Convert.ToInt32(thisMonthNumberInput.Text);
            int currentMonth = Convert.ToInt32(currentMonthCombobox.SelectedItem);

            int consumption = thisMonthNumber - lastMonthNumber;
            double price = 0;
            double VAT = 0;
            double envFee = 0;
            if (customerType == "Household customer")
            {
                decimal consumptionPerPeople = consumption / numberOfPeople;
                if (consumptionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                if (consumptionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                if (consumptionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 866.9;
                }
                if (consumptionPerPeople > 30)
                {
                    price = 15929;
                    envFee = 1592.9;
                }
            }
            if (customerType == "Administrative agency, public services")
            {
                price = 9955;
                envFee = 995.5;
            }
            if (customerType == "Production units")
            {
                price = 11615;
                envFee = 1161.5;
            }
            if (customerType == "Business services")
            {
                price = 22068;
                envFee = 2206.8;
            }

            double subTotal = price * consumption;
            double VATFee = (subTotal + envFee) * 0.1;
            double total = subTotal + envFee + VATFee;
            comsumptionLabel.Text = consumption.ToString();
            priceLabel.Text = price.ToString();
            subtotalLabel.Text = Math.Round(subTotal, 2).ToString();
            envFeeLabel.Text = envFee.ToString();
            VATLabel.Text = Math.Round(VATFee, 2).ToString();
            totalLabel.Text = Math.Round(total, 2).ToString();

            InvoiceManager.AddInvoice(customerCode, customerName, customerType,
            numberOfPeople, lastMonthNumber, thisMonthNumber, currentMonth,
            subTotal, envFee, VATFee, total);

        }

        private void customerTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            if (customerType == "Household customer")
                numberOfPeopleInput.Enabled = true;
            else
                numberOfPeopleInput.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
