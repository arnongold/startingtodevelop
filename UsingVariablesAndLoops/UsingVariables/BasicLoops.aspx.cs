using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingVariables
{
    public partial class BasicLoops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Response.Write("Hello <br />");
            //}

            //List<string> stuffToWrite = new List<string>();
            //stuffToWrite.Add("This is the first line !");
            //stuffToWrite.Add("This is the second line !");
            //stuffToWrite.Add("This is the third line !");

            //foreach (var line in stuffToWrite)
            //{
            //    Response.Write(line);
            //    Response.Write("<br />");
            //}

            //int powerOf2 = 0;
            //int numberToCheck = 1024;

            //while (numberToCheck > 1)
            //{
            //    powerOf2 = powerOf2 + 1;
            //    numberToCheck = numberToCheck / 2;
            //}
            //Response.Write(string.Format("The number is the {0}th power of 2", powerOf2));

            int powerOf2 = 0;
            int numberToCheck = 1024;

            do
            {
                powerOf2 = powerOf2 + 1;
                numberToCheck = numberToCheck / 2;
            } while (numberToCheck > 1);

            Response.Write(string.Format("The number is the {0}th power of 2", powerOf2));
        }
    }
}