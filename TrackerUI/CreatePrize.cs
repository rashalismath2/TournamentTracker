using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        private string outputString;
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void CreatePrize_Load(object sender, EventArgs e)
        {
          clearField();
          
        }

  
        /// <summary>
        /// Creating a prize record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show(outputString,"Warning Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                outputString = "";
                clearField();

            }
            else {
                foreach (IDataconnection connections in GlobalConfig.Connections) {
                    connections.CreatePrize(new PrizeModel {
                        PlaceName = placeNameText.Text,
                        PrizeAmount=decimal.Parse(placeAmountText.Text),
                        PrizePrecentage=int.Parse(placePrecentageText.Text),
                       PlaceNUmber=int.Parse(placeNumberText.Text)
                    });
                }
                MessageBox.Show("Prize Created","Success Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
      
        }

        /// <summary>
        /// Uses to validate input fields values
        /// </summary>
        /// <returns>If all the checks are passed returns true</returns>
        private bool ValidateFields()
        {

            bool output = true;

            //check place number for integer and greater than 0
            int placeNumberValue = 0;
            bool placeNumber = int.TryParse(placeNumberText.Text, out placeNumberValue);

            if (placeNumberValue < 1 || !placeNumber)
            {
                outputString = outputString + "* Please add valid number to place number field \n";       
                output = false;
            }

            //check place name field is empty 
            if (string.IsNullOrEmpty(placeNameText.Text)) {
                outputString = outputString + "* Please add valid string to place name field \n";
                output = false;
            }

            //check prize amount and precentage fields
            //either amount or precentage should be entered

            decimal placeAmountValue = 0;
            int prizePrecentageValue = 0;

            bool placeAmount = decimal.TryParse(placeAmountText.Text,out placeAmountValue);
            bool prizePrecentage = int.TryParse(placePrecentageText.Text,out prizePrecentageValue);

            if (!placeAmount || !prizePrecentage) {
                outputString = outputString + "* Enter Valid values for either amount or precentage fields \n";
                output = false;
            }

            if (placeAmountValue>=0 && prizePrecentageValue>=0)
            {
                outputString = outputString + "* Enter Either place amount or precentage \n";
                output = false;
            }


            return output;
        }

        private void clearField() {
            placeAmountText.Text = "0";
            placePrecentageText.Text = "0";
            placeNumberText.Text = "";
            placeNameText.Text = "";
        }

    }
}
