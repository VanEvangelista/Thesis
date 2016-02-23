using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Dummy2 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        
                  
           
                //using (NpgsqlConnection cnDB = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=tubthumping;Database=thesis;"))
            {
                NpgsqlConnection cnDB = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                //cnDB.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();
                cnDB.Open();
                //NpgsqlCommand cmd = new NpgsqlCommand();
                //cmd.Connection = cnDB;                         
                //cmd.CommandText = "Insert into RoomRequest_user(@FirstName,@LastName,@IdNum,@Password,@SchoolYear,@Term,@DLSUEmail,@ContactNum,@RoomRequest,@UserId)";
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add(new NpgsqlParameter("@FirstName", f_name.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@LastName", l_name.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@IdNum", id_num.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@Password", user_pass.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@ContactNum", contact_num.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@Email", dlsu_email.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@SchoolYear", school_yr.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@Term", term_drop.Text));
                //cmd.Parameters.Add(new NpgsqlParameter("@RoomRequest", room_drop.Text));

                //cmd.ExecuteNonQuery();
                //cmd.Dispose();
                
                    string first = f_name.Text;
                    string last = l_name.Text;
                    string id = id_num.Text;
                    string pass2 = user_pass.Text;
                    string contact = contact_num.Text;
                    string schlemail = dlsu_email.Text;
                    string schlyear = school_yr.Text;
                    string schlterm = term_drop.Text;
                    string schlroom = room_drop.Text;
                
                string SQL_dtr = string.Format("insert into roomrequest_user2 (FirstName, LastName, IdNum, Pass, ContactNum, DLSUEmail, SchoolYear, Term, RoomRequest) " +
                    "values ('" + first + "', '" + last + "', '" + id + "', '" + pass2 + "', '" + contact + "', '" + schlemail + "', '" + schlyear + "', '" + schlterm + "', '" + schlroom + "')"

                    //string first = f_name.Text;
                    //string last = l_name.Text;
                    //string id = id_num.Text;
                    //string pass = user_pass.Text;
                    //string contact = contact_num.Text;
                    //string schlemail = dlsu_email.Text;
                    //string schlyear = school_yr.Text;
                    //string schlterm = term_drop.Text;
                    //string schlroom = room_drop.Text;
                                    
                    );
                NpgsqlCommand command_dtr = new NpgsqlCommand(SQL_dtr, cnDB);
                command_dtr.ExecuteNonQuery();

                cnDB.Close();
                //f_name.Text = "";
                //l_name.Text = "";
                //id_num.Text = "";
                //user_pass.Text = "";
                //contact_num.Text = "";
                //dlsu_email.Text = "";
                //school_yr.Text = "";
                //term_drop.Text = "";
                //room_drop.Text = "";
            }
       
    }

}

