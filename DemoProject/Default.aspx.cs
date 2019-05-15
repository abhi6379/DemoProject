using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(getResult().ToString());
            DateTime dbDate = Convert.ToDateTime("05/15/2019 05:16:00.000").ToLocalTime();


            //DateTime timeUtc = new DateTime(dbDate.Year, dbDate.Month, dbDate.Day, dbDate.Hour, dbDate.Minute, dbDate.Second, dbDate.Millisecond);
            Response.Write(ConvertTimeZones(dbDate, "India Standard Time",DateTimeKind.Utc).ToString());
        }

        public int getResult()
        {
            int i = 1;
            try
            {
                return i;
            }
            catch (Exception ex)
            {

                return i + 1;
            }
            finally
            {
                i = i + 2;
            }

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            lbl_stringReverse.Text = ReversebyWord(txt_val.Text.ToString());
        }

        private string ReversebyWord(string range)
        {

            string val = range;
            if (val == string.Empty && val == null)
            {
                return "Please Enter a value...";
            }
            else
            {
                string[] splitedVal = val.Split(' ');
                val = null;
                for (int i = 0; i < splitedVal.Length; i++)
                {
                    for (int j = splitedVal[i].Length; j > 0; j--)
                    {
                        val += splitedVal[i][j - 1];
                    }
                    val += " ";
                }
            }

            return val;
        }

        private DateTime ConvertTimeZones(DateTime timeUtc, string zoneFormat,DateTimeKind kind)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(zoneFormat);
            DateTime requiredTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.SpecifyKind(timeUtc,kind), timeZone);
            return requiredTime;
        }

    }
}