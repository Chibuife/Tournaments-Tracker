﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibary;
using TrackerLibary.DataAccess;
using TrackerLibary.Modals;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModal modal = new PrizeModal(
                    placeNameValue.Text, 
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);
                foreach (IDataConnection db  in GlobalConfig.Connections)
                {
                     db.CreatePrize(modal);
                }
            }
            else
            {
                MessageBox.Show("This form has Invaild information. Please check it and try again.");
            }
            placeNumberValue.Text = "";
            placeNameValue.Text = "";
            prizeAmountValue.Text = "0";
            prizePercentageValue.Text = "0";

        }

        private bool ValidateForm()
        {
            bool output = true;

            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if(placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if(!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }
            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if(prizePercentage < 0 || prizePercentage> 100)
            {
                output = false;
            }
            return output;
        }

        private void placeNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void prizeAmountValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
