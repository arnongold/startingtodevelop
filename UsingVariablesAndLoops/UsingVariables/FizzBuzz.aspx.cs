using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingVariables
{
    public partial class FizzBuzz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Response.Write("<h2>");
                if (i % 15 == 0)
                {
                    Response.Write("FizzBuzz !");
                }
                else if (i % 3 == 0)
                {
                    Response.Write("Fizz !");
                }
                else if (i % 5 == 0)
                {
                    Response.Write("Buzz !");
                }
                else 
                {
                    Response.Write(i);
                }
                Response.Write("</h2>");
            }
        }
    }
}