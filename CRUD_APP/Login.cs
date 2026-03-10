using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GET USERNAME AND PASSWORD FROM TEXTBOXES
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            //CHECK IF USERNAME OR PASSWORD IS EMPTY
            if (username == "" || password == "")
            {
                MessageBox.Show("Plsease enter username and password");
                return;
                //stop the prograg   
            }
            //CREATE DATABASE CONNECTION
            DBConnect db = new DBConnect();

            try
            {
              //open database
              db.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                //CREATE MYSQL Query 
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                //EXECUTE QUERY AND GET RESULT NUMBER 
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();//Release command resources 


                if (count == 1)
                {
                    MessageBox.Show("Login SUccesfull!");
                    //OPEN DASHBOARD
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

             

               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }

        }
    }
}
