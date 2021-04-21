using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Star7
{
    public partial class Register : Form
    {
        static string constr = "Data source=LAPTOP-HP6LE0S6\\SQLEXPRESS;Initial Catalog=NRSFSNdb; Integrated Security=True;";
        SqlConnection con = new SqlConnection(constr); //connect database
        SqlCommand cmd = new SqlCommand(); //defining the command

        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            if (userName=="" || email=="" || password =="")
            {
                MessageBox.Show("Username, Email and Password cannot be empty!", "Error!");
            }
            else
            {
                try
                {
                    con.Open();
                    string strSql = "Insert into tbluserinfo ([userName], [userEmail], [userPassword], [T1N1toN2], [T1N1toN4], [T1N1toN5], [T1N2toN4], [T1N3toN4], [T1N4toN7], [T1N5toN7], [T1N6toN7], [T1N7toN8]) ";
                    strSql += "Values('" + userName + "','" + email + "','" + password + "', 0, 0, 0, 0, 0, 0, 0, 0, 0)";
                    cmd.CommandText = strSql;
                    cmd.ExecuteNonQuery();

                    Home main = new Home();
                    main.MethodReceiveName = MethodPassName;
                    main.MethodReceivePassword = MethodPassPassword;
                    main.MethodReceiveEmail = MethodPassEmail;
                    main.Show();
                    this.Hide();
                    this.Dispose(false);
                }
                catch
                {
                    MessageBox.Show("Username Taken!", "Error!");
                    Register main = new Register();
                    main.Show();
                    this.Hide();
                    this.Dispose(false);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Landing main = new Landing();
            main.Show();
            this.Hide();
            this.Dispose(false);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cmd.Connection = con; //select a database to select table
            con.Open();
            cmd.CommandType = CommandType.Text; //to define it is a string
            cmd.CommandTimeout = 15;
            con.Close();
        }

        public string MethodPassName
        {
            get { return txtUser.Text; }
        }

        public string MethodPassPassword
        {
            get { return txtPass.Text; }
        }

        public string MethodPassEmail
        {
            get { return txtEmail.Text; }
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }
    }
}
