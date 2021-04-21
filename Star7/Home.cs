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
    public partial class Home : Form
    {
        static string constr = "Data source=LAPTOP-HP6LE0S6\\SQLEXPRESS;Initial Catalog=NRSFSNdb; Integrated Security=True;";
        SqlConnection con = new SqlConnection(constr); //connect database
        SqlCommand cmd = new SqlCommand(); //defining the command

        public Home()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            con.Open();
            if (cboxtype.Text == "Bus")
            {
                cmd.CommandText = "update tbluserinfo set userDeviceNum='" + cboxnoDevice.Text + "', userTypeTopology='" + cboxtype.Text + "' where userName='" + lblUsername.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                Bus7 main = new Bus7();
                main.MethodReceiveName = MethodPassName;
                main.MethodReceiveDevice = MethodPassDevice;
                main.MethodReceiveTopology = MethodPassTopology;
                main.Show();
                this.Hide();
                this.Dispose(false);
            }

            if (cboxtype.Text == "Ring")
            {
                cmd.CommandText = "update tbluserinfo set userDeviceNum='" + cboxnoDevice.Text + "', userTypeTopology='" + cboxtype.Text + "' where userName='" + lblUsername.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                Ring7 main = new Ring7();
                main.MethodReceiveName = MethodPassName;
                main.MethodReceiveDevice = MethodPassDevice;
                main.MethodReceiveTopology = MethodPassTopology;
                main.Show();
                this.Hide();
                this.Dispose(false);
            }

            if (cboxtype.Text == "Mesh")
            {
                cmd.CommandText = "update tbluserinfo set userDeviceNum='" + cboxnoDevice.Text + "', userTypeTopology='" + cboxtype.Text + "' where userName='" + lblUsername.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                Star7 main = new Star7();
                main.MethodReceiveName = MethodPassName;
                main.MethodReceiveDevice = MethodPassDevice;
                main.MethodReceiveTopology = MethodPassTopology;
                main.Show();
                this.Hide();
                this.Dispose(false);
            }
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyAccount main = new MyAccount();
            main.MethodReceiveName = MethodPassName;
            main.MethodReceiveDevice = MethodPassDevice;
            main.MethodReceiveTopology = MethodPassTopology;
            main.MethodReceivePassword = MethodPassPassword;
            main.MethodReceiveEmail = MethodPassEmail;
            main.Show();
            this.Hide();
            this.Dispose(false);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Landing main = new Landing();
            main.Show();
            this.Hide();
            this.Dispose(false);
        }

        private void cboxnoDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxnoDevice.Text == "2")
            {
                cboxtype.Text = "";
                cboxtype.Items.Remove("Bus");
                cboxtype.Items.Remove("Ring");
                cboxtype.Items.Remove("Mesh");
                cboxtype.Items.Add("Bus");
            }

            if (cboxnoDevice.Text == "3")
            {
                cboxtype.Text = "";
                cboxtype.Items.Remove("Bus");
                cboxtype.Items.Remove("Ring");
                cboxtype.Items.Remove("Mesh");
                cboxtype.Items.Add("Bus");
                cboxtype.Items.Add("Ring");
            }

            if (cboxnoDevice.Text == "4")
            {
                cboxtype.Text = "";
                cboxtype.Items.Remove("Bus");
                cboxtype.Items.Remove("Ring");
                cboxtype.Items.Remove("Mesh");
                cboxtype.Items.Add("Bus");
                cboxtype.Items.Add("Ring");
                cboxtype.Items.Add("Mesh");
            }

            if (cboxnoDevice.Text == "5")
            {
                cboxtype.Text = "";
                cboxtype.Items.Remove("Bus");
                cboxtype.Items.Remove("Ring");
                cboxtype.Items.Remove("Mesh");
                cboxtype.Items.Add("Bus");
                cboxtype.Items.Add("Ring");
                cboxtype.Items.Add("Mesh");
            }

            if (cboxnoDevice.Text == "6")
            {
                cboxtype.Text = "";
                cboxtype.Items.Remove("Bus");
                cboxtype.Items.Remove("Ring");
                cboxtype.Items.Remove("Mesh");
                cboxtype.Items.Add("Bus");
                cboxtype.Items.Add("Ring");
                cboxtype.Items.Add("Mesh");
            }

            if (cboxnoDevice.Text == "7")
            {
                cboxtype.Text = "";
                cboxtype.Items.Remove("Bus");
                cboxtype.Items.Remove("Ring");
                cboxtype.Items.Remove("Mesh");
                cboxtype.Items.Add("Bus");
                cboxtype.Items.Add("Ring");
                cboxtype.Items.Add("Mesh");
            }
        }

        public string MethodReceiveName
        {
            set { lblUsername.Text = value; }
        }

        public string MethodReceivePassword
        {
            set { HidePassword.Text = value; }
        }

        public string MethodReceiveDevice
        {
            set { cboxnoDevice.Text = value; }
        }

        public string MethodReceiveTopology
        {
            set { cboxtype.Text = value; }
        }

        public string MethodReceiveEmail
        {
            set { HideEmail.Text = value; }
        }


        public string MethodPassName
        {
            get { return lblUsername.Text; }
        }

        public string MethodPassDevice
        {
            get { return cboxnoDevice.Text; }
        }

        public string MethodPassTopology
        {
            get { return cboxtype.Text; }
        }

        public string MethodPassPassword
        {
            get { return HidePassword.Text; }
        }

        public string MethodPassEmail
        {
            get { return HideEmail.Text; }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cmd.Connection = con; //select a database to select table
            con.Open();
            cmd.CommandType = CommandType.Text; //to define it is a string
            cmd.CommandTimeout = 15;
            ControlExtension.Draggable(button1, true);
            con.Close();
            groupBox1.SendToBack();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            main.MethodReceiveName = MethodPassName;
            main.MethodReceiveDevice = MethodPassDevice;
            main.MethodReceiveTopology = MethodPassTopology;
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimNew main = new SimNew();
            main.MethodReceiveName = MethodPassName;
            main.MethodReceiveDevice = MethodPassDevice;
            main.MethodReceiveTopology = MethodPassTopology;
            main.Show();
            this.Hide();
            this.Dispose(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
