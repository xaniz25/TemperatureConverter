using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemperatureConverter
/*A web form that converts temperature from and to each type: Celsius, Farenheit, Kelvin
 * using dropdown menus and outputs the result to a label control
 * Created by Shanice Talan. July 17, 2019. CPRG214 OOSD Spring 2019
 */
{
    public partial class Default : System.Web.UI.Page
    {   //variable for storing input, the result before rounding, and the result after rounding
        double input;
        double result;
        double rounded;

        protected void Page_Load(object sender, EventArgs e)
        {
            InputBox.Focus();
        }

        protected void BtnCalculate_Click(object sender, EventArgs e)
        //calculate the result depending on the selection of the two dropdown boxes
        {
            Double.TryParse(InputBox.Text, out input); //converts the input to a double type

            if (FromDropDown.SelectedValue == "Celsius" && ToDropDown.SelectedValue == "Farenheit")
                result = input * 9 / 5 + 32;
            else if (FromDropDown.SelectedValue == "Farenheit" && ToDropDown.SelectedValue == "Celsius")
                result = (input - 32) * 5 / 9;
            else if (FromDropDown.SelectedValue == "Celsius" && ToDropDown.SelectedValue == "Kelvin")
                result = input + 273.15;
            else if (FromDropDown.SelectedValue == "Kelvin" && ToDropDown.SelectedValue == "Celsius")
                result = input - 273.15;
            else if (FromDropDown.SelectedValue == "Farenheit" && ToDropDown.SelectedValue == "Kelvin")
                result = (input - 32) * 5 / 9 + 273.15;
            else if (FromDropDown.SelectedValue == "Kelvin" && ToDropDown.SelectedValue == "Farenheit")
                result = (input - 273.15) * 9 / 5 + 32;
            else //if converting to same type
                result = input;

            rounded = Math.Round(result,2); //round to 2 decimal points
            OutputLabel.Text = rounded.ToString(); //write the rounded result to the output label
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        //resets the form to the starting position and clears input box and output label
        {
            FromDropDown.SelectedValue = "Celsius";
            ToDropDown.SelectedValue = "Farenheit";
            OutputLabel.Text = "";
            InputBox.Text = "";
            InputBox.Focus();
        }
    }
}