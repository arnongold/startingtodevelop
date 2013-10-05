using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingVariables
{
    public partial class BasicVariables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Basic decleration:
            int wholeNumber;
            double fraction;
            string anyText;
            bool trueOrFalse;

            //value assignment
            wholeNumber = 5;
            fraction = 12.34;
            anyText = "This is some text";
            trueOrFalse = true;

            //Decleration with assignment
            int number = 5;
            string newString = Convert.ToString(number);

            string numberAsString = "123";
            int justNumber = Convert.ToInt32(numberAsString);

            
            Console.WriteLine(wholeNumber);
            Console.WriteLine(fraction);
            Console.WriteLine(anyText);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(number);
        }
    }
}