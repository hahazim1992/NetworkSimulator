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
    public partial class MyAccount : Form
    {
        static string constr = "Data source=LAPTOP-HP6LE0S6\\SQLEXPRESS;Initial Catalog=NRSFSNdb; Integrated Security=True;";
        SqlConnection con = new SqlConnection(constr); //connect database
        SqlCommand cmd = new SqlCommand(); //defining the command

        public MyAccount()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TBOldPassword.Text == HidePassword.Text)
            {
                if(TBNewPassword.Text == TBConfNewPassword.Text && TBConfNewPassword.Text !="")
                {
                    con.Open();
                    cmd.CommandText = "update tbluserinfo set userPassword='" + TBConfNewPassword.Text + "' where userName='" + txtUser.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DialogResult d;
                    d = MessageBox.Show("Changes saved!", "Update credentials", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        Home main = new Home();
                        main.MethodReceiveName = MethodPassName;
                        main.MethodReceiveDevice = MethodPassDevice;
                        main.MethodReceiveTopology = MethodPassTopology;
                        main.MethodReceivePassword = MethodPassPassword;
                        main.MethodReceiveEmail = MethodPassEmail;
                        main.Show();
                        this.Hide();
                        this.Dispose(false);
                    }
                }
                else
                {
                    DialogResult f;
                    f = MessageBox.Show("new password does not match!", "Update credentials", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult g;
                g = MessageBox.Show("old password does not match!", "Update credentials", MessageBoxButtons.OK);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            var strSql = "SELECT userName, userPassword, userDeviceNum, userTypeTopology, userEmail ";//
            strSql += "from tbluserinfo";
            var cmdlogin = new SqlCommand(strSql, con);
            var reader = cmdlogin.ExecuteReader();
            while (reader.Read())
            {
                if (reader["userName"].ToString() == txtUser.Text)
                {
                    Home main = new Home();
                    main.MethodReceiveName = reader[0].ToString();
                    main.MethodReceiveDevice = reader[2].ToString();
                    main.MethodReceiveTopology = reader[3].ToString();
                    main.MethodReceivePassword = reader[1].ToString();
                    main.MethodReceiveEmail = reader[4].ToString();
                    main.Show();
                    this.Hide();
                    this.Dispose(false);
                    break;
                }
            }
            con.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Landing main = new Landing();
            main.Show();
            this.Hide();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            cmd.Connection = con; //select a database to select table
            con.Open();
            cmd.CommandType = CommandType.Text; //to define it is a string
            cmd.CommandTimeout = 15;
            con.Close();
        }

        public string MethodReceiveName
        {
            set { txtUser.Text = value; }
        }

        public string MethodReceivePassword
        {
            set { HidePassword.Text = value; }
        }

        public string MethodReceiveEmail
        {
            set { txtEmail.Text = value; }
        }

        public string MethodReceiveDevice
        {
            set { HideDevice.Text = value; }
        }

        public string MethodReceiveTopology
        {
            set { HideTopology.Text = value; }
        }


        public string MethodPassName
        {
            get { return txtUser.Text; }
        }

        public string MethodPassPassword
        {
            get { return TBConfNewPassword.Text; }
        }

        public string MethodPassEmail
        {
            get { return txtEmail.Text; }
        }

        public string MethodPassDevice
        {
            get { return HideDevice.Text; }
        }

        public string MethodPassTopology
        {
            get { return HideTopology.Text; }
        }


    }
}
