using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjTranslator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String[] p = new string[] { "mesa", "cadeira", "lua" };
            String[] i = new string[] { "table", "chair", "moon" };

            String dig = TextBox1.Text;
            int pos = 0;

            for (int count=0;count<p.Length;count++)
            {
                if (dig.Equals(p[count]))
                {
                    pos = count;
                    break;
                }
            }
            Label1.Text = i[pos];

        }
    }
}