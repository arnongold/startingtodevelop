using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingVariables
{
    public partial class UsingResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string FirstString = "The sun";
            string SecondString = "The Earth";

            //Swap content of two strings
            string tempString;
            tempString = FirstString;
            FirstString = SecondString;
            SecondString = tempString;

            string output = string.Format("<h1>{0} is smaller then {1}</h1>", FirstString, SecondString);

            Response.Write(output);

        }
    }
}