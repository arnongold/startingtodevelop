using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingVariables
{
    public partial class Conditions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checkNumber_Click(object sender, EventArgs e)
        {
            int numberToCheck = Convert.ToInt32(txtNumberToCheck.Text);

            if (numberToCheck % 3 == 0)
            {
                lblResult.Text = "Yes";
            }
            else
            {
                lblResult.Text = "No";
            }

            if (numberToCheck % 3 == 0 && numberToCheck > 10)
                Response.Write("Number is divided by 3 AND greater then 10");

            if (numberToCheck % 3 == 0 || numberToCheck % 5 == 0)
                Response.Write("number is divided by 3 OR 5");


            if (numberToCheck % 3 == 0)
            {
                lblResult.Text = "Divides by 3";
            }
            else if (numberToCheck % 5 == 0)
            {
                lblResult.Text = "Divides by 5";
            }
            else
            {
                lblResult.Text = "Does not divides by 3 or 5";
            }
        }
    }
}

