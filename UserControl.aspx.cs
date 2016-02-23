using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class UserControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["IdNum"] == null)
        {
            Response.Redirect("UserLog.aspx");
        }
        else
        {
            Label2.Text = Session["IdNum"].ToString();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        NpgsqlConnection cnDB = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
        cnDB.Open();
        string first = f_name.Text;
        string last = l_name.Text;
        string id = id_num.Text;
        string pass2 = user_pass.Text;
        string contact = contact_num.Text;
        string schlemail = dlsu_email.Text;
        string schlyear = school_yr.Text;
        string schlterm = term_drop.Text;
        string schlroom = room_drop.Text;

        string SQL_dtrupdate = string.Format("update roomrequest_user2 set firstname='" + first + "' WHERE IdNum='" + id + "' ");
        NpgsqlCommand command_dtr = new NpgsqlCommand(SQL_dtrupdate, cnDB);
        command_dtr.ExecuteNonQuery();
        cnDB.Close();
    }
}