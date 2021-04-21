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
    public partial class Landing : Form
    {
        public string Gname;
        public string Gpassword;
        public string Gdevice;
        public string Gtopology;
        public string Gemail;

        static string constr = "Data source=LAPTOP-HP6LE0S6\\SQLEXPRESS;Initial Catalog=NRSFSNdb; Integrated Security=True;";
        SqlConnection con = new SqlConnection(constr); //connect database
        SqlCommand cmd = new SqlCommand(); //defining the command

        public Landing()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Home main = new Home();
                main.MethodReceiveName = MethodPassName;
                main.MethodReceiveDevice = MethodPassDevice;
                main.MethodReceiveTopology = MethodPassTopology;
                main.MethodReceivePassword = MethodPassPassword;
                main.MethodReceiveEmail = MethodPassEmail;
                main.Show();
                this.Hide();
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Wrong login and password", "Error", MessageBoxButtons.OK);
                if (d == DialogResult.OK)
                {
                    Landing main = new Landing();
                    main.Show();
                    this.Hide();
                    this.Dispose(false);
                }
            }
        }

        private void btnReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register main = new Register();
            main.Show();
            this.Hide();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            cmd.Connection = con; //select a database to select table
            con.Open();
            cmd.CommandType = CommandType.Text; //to define it is a string
            cmd.CommandTimeout = 15;
            con.Close();
        }

        private bool check()
        {
            con.Open();
            bool test = false;
            var strSql = "SELECT userName, userPassword, userDeviceNum, userTypeTopology, userEmail ";
            strSql += "from tbluserinfo";
            var cmdlogin = new SqlCommand(strSql, con);
            var reader = cmdlogin.ExecuteReader();
            while (reader.Read())
            {
                if (reader["userName"].ToString() == txtUser.Text && reader["userPassword"].ToString() == txtPass.Text)
                {
                    test = true;
                    Gname = reader[0].ToString();
                    Gpassword = reader[1].ToString();
                    Gdevice = reader[2].ToString();
                    Gtopology = reader[3].ToString();
                    Gemail = reader[4].ToString();
                    break;
                }
            }
            con.Close();
            return test;

        }

        public string MethodPassName
        {
            get { return Gname; }
        }

        public string MethodPassPassword
        {
            get { return Gpassword; }
        }

        public string MethodPassDevice
        {
            get { return Gdevice; }
        }

        public string MethodPassTopology
        {
            get { return Gtopology; }
        }

        public string MethodPassEmail
        {
            get { return Gemail; }
        }
    }
}
