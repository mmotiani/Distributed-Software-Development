using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class time : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Int32 hour = DateTime.Now.Hour;        //will take current hour from the system
        Int32 minute = DateTime.Now.Minute;
        Int32 seconds = DateTime.Now.Second;
        string str=""; 
        if (hour>=0&&hour<6)
        {
            str =  "GOOD NIGHT !!";
            label_msg.Text = str;   //will display this message when time in between 12:00 a.m. to 6:00 a.m
        }
        else if (hour >= 6 && hour < 12)
        {
            str = "GOOD MORNING !!";
            label_msg.Text = str;   //will display this message when time in between 6:00 a.m. to 12:00 p.m

        }
        else  if (hour >= 12 && hour < 18)
        {
            str = "GOOD AFTERNOON !!";
            label_msg.Text = str;    //will display this message when time in between 12:00 p.m. to 6:00 p.m

        }
        else
        {
            str = "GOOD EVENING !!";
            label_msg.Text = str;     //will display this message when time in between 6:00 p.m. to 12:00 a.m

        }
    }
}