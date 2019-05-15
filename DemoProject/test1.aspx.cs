using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoProject
{
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = -1, j = 0, count = 0; i < 99; i++)
            {
                if (count == 0)
                {
                    j = i + 3;
                    Response.Write(j.ToString() + "<br/>");
                    count++;
                }
                else
                {
                    j = j - 1;
                    Response.Write(j.ToString() + "<br/>");
                    count = 0;
                }
            }
        }
    }
}