using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postal_Code_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        
        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void nextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }
        private void performChanged()
        {
            //Do the values of text boxes and check boxes even exist.
            if (!valuesExist())
                return;


            //Determine Volume of package
            int volume = 0
            if (!tryGetVolume(out volume))
                return;


            //Which radio button is checked?
            double postageMultipler = getPostageMultiplier();


            //Determin cost
            double cost = volume * postageMultiplier();


            //Display cost[
            resultLabel.Text = String.Format("Your parcel will cost {o:C} to ship.", cost)
                
                }

        private bool valuesExist()
        {
            if (!airRadioButton.Checked
                 && !groundRadioButton.Checked
                 && !nextRadioButton.Checked)
                return false;

            if (widthTextBox.Text.Trim().L == 0
                || heightTextBox.Text == 0)
        }

        private bool tryGetVolume(out int volume)
        {

        }

        private double getPostageMultiplier()
        {

        }

    }
}