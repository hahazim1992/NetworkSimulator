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
    public partial class Bus7 : Form
    {

        static string constr = "Data source=LAPTOP-HP6LE0S6\\SQLEXPRESS;Initial Catalog=NRSFSNdb; Integrated Security=True;";
        SqlConnection con = new SqlConnection(constr); //connect database
        SqlCommand cmd = new SqlCommand(); //defining the command

        string ms = " ms";
        double pingIntrandom;
        string pingStringResult;
        Graphics surface;
        Random pingIntR = new Random();
        Pen penpcAB = new Pen(ColorTranslator.FromHtml("#000000"), 2);
        Pen penpcBC = new Pen(ColorTranslator.FromHtml("#000000"), 2);
        Pen penpcCD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
        Pen penpcDE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
        Pen penpcEF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
        Pen penpcFG = new Pen(ColorTranslator.FromHtml("#000000"), 2);

        public Bus7()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            surface = CreateGraphics();
            //penpcAB = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAB, 300, 400, 400, 400);
            //penpcBC = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcBC, 450, 400, 550, 400);
            //penpcCD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcCD, 600, 400, 700, 400);
            //penpcDE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcDE, 750, 400, 850, 400);
            //penpcEF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcEF, 900, 400, 1000, 400);
            //penpcFG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcFG, 1050, 400, 1150, 400);
        }

        private void PBpcA_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="6")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);

                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="7")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);

                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }
        }

        private void LblpcA_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "6")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);

                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);

                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }
        }
        private void PBpcB_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="4")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="5")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="6")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
                LblpingpcA.Text = "0 ms";

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="7")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
                LblpingpcA.Text = "0 ms";

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }
        }

        private void LblpcB_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "4")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
                LblpingpcA.Text = "0 ms";

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
                LblpingpcA.Text = "0 ms";

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }
        }

        private void PBpcC_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="2")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
                LblpingpcD.Text = "0 ms";
            }

            if (HideDevice.Text=="3")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if(HideDevice.Text=="4")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
                LblpingpcB.Text = "0 ms";

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="5")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
                LblpingpcB.Text = "0 ms";

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="6")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;

                if (PBpcA.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="7")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;

                if (PBpcA.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }
        }

        private void LblpcC_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "2")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
                LblpingpcD.Text = "0 ms";
            }

            if (HideDevice.Text == "3")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "4")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
                LblpingpcB.Text = "0 ms";

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
                LblpingpcB.Text = "0 ms";

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;

                if (PBpcA.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;

                if (PBpcA.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }
        }

        private void PBpcD_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="2")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
                LblpingpcC.Text = "0 ms";
            }

            if (HideDevice.Text=="3")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
                LblpingpcE.Text = "0 ms";
                LblpingpcC.Text = "0 ms";
            }

            if (HideDevice.Text=="4")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
                LblpingpcE.Text = "0 ms";

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if(HideDevice.Text=="5")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="6")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="7")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }
        }

        private void LblpcD_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "2")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);

                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
                LblpingpcC.Text = "0 ms";
            }

            if (HideDevice.Text == "3")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
                LblpingpcE.Text = "0 ms";
                LblpingpcC.Text = "0 ms";
            }

            if (HideDevice.Text == "4")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
                LblpingpcE.Text = "0 ms";

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 600, 400, 700, 400);
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }
        }

        private void PBpcE_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="3")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="4")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="5")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
                LblpingpcF.Text = "0 ms";

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="6")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
                LblpingpcF.Text = "0 ms";

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="7")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }

                if (PBpcG.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }
        }

        private void LblpcE_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "3")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "4")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);

                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
                LblpingpcF.Text = "0 ms";

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
                LblpingpcF.Text = "0 ms";

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }

                if (PBpcG.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }
        }

        private void PBpcF_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="5")
            {
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="6")
            {
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="7")
            {
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 1050, 400, 1150, 400);

                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
                LblpingpcG.Text = "0 ms";

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }
        }

        private void LblpcF_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "5")
            {
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);

                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 1050, 400, 1150, 400);

                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                if (LblpingpcA.Text != "0 ms")
                {
                    LblpingpcA.Text = Fctping();
                }
                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
                }
                if (LblpingpcD.Text != "0 ms")
                {
                    LblpingpcD.Text = Fctping();
                }
                if (LblpingpcE.Text != "0 ms")
                {
                    LblpingpcE.Text = Fctping();
                }
                if (LblpingpcF.Text != "0 ms")
                {
                    LblpingpcF.Text = Fctping();
                }
                if (LblpingpcG.Text != "0 ms")
                {
                    LblpingpcG.Text = Fctping();
                }

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
                LblpingpcG.Text = "0 ms";

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }
        }

        private void PBpcG_Click(object sender, EventArgs e)
        {
            penpcFG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcFG, 1050, 400, 1150, 400);

            LBstatusOnline.Items.Remove("F-G");


            if (!LBstatusOffline.Items.Contains("F-G"))
            {
                LBstatusOffline.Items.Add("F-G");
            }

            if (LblpingpcA.Text != "0 ms")
            {
                LblpingpcA.Text = Fctping();
            }
            if (LblpingpcB.Text != "0 ms")
            {
                LblpingpcB.Text = Fctping();
            }
            if (LblpingpcC.Text != "0 ms")
            {
                LblpingpcC.Text = Fctping();
            }
            if (LblpingpcD.Text != "0 ms")
            {
                LblpingpcD.Text = Fctping();
            }
            if (LblpingpcE.Text != "0 ms")
            {
                LblpingpcE.Text = Fctping();
            }
            if (LblpingpcF.Text != "0 ms")
            {
                LblpingpcF.Text = Fctping();
            }
            if (LblpingpcG.Text != "0 ms")
            {
                LblpingpcG.Text = Fctping();
            }

            //LblpingpcA.Text = Fctping();
            //LblpingpcB.Text = Fctping();
            //LblpingpcC.Text = Fctping();
            //LblpingpcD.Text = Fctping();
            //LblpingpcE.Text = Fctping();
            //LblpingpcF.Text = Fctping();
            //LblpingpcG.Text = Fctping();

            PBpcG.Visible = false;
            LblpcG.Visible = false;
            LblpingpcG.Visible = false;

            if (PBpcE.Visible == false)
            {
                LblpingpcF.Text = "0 ms";
            }
        }

        private void LblpcG_Click(object sender, EventArgs e)
        {
            penpcFG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcFG, 1050, 400, 1150, 400);

            LBstatusOnline.Items.Remove("F-G");


            if (!LBstatusOffline.Items.Contains("F-G"))
            {
                LBstatusOffline.Items.Add("F-G");
            }

            if (LblpingpcA.Text != "0 ms")
            {
                LblpingpcA.Text = Fctping();
            }
            if (LblpingpcB.Text != "0 ms")
            {
                LblpingpcB.Text = Fctping();
            }
            if (LblpingpcC.Text != "0 ms")
            {
                LblpingpcC.Text = Fctping();
            }
            if (LblpingpcD.Text != "0 ms")
            {
                LblpingpcD.Text = Fctping();
            }
            if (LblpingpcE.Text != "0 ms")
            {
                LblpingpcE.Text = Fctping();
            }
            if (LblpingpcF.Text != "0 ms")
            {
                LblpingpcF.Text = Fctping();
            }
            if (LblpingpcG.Text != "0 ms")
            {
                LblpingpcG.Text = Fctping();
            }

            //LblpingpcA.Text = Fctping();
            //LblpingpcB.Text = Fctping();
            //LblpingpcC.Text = Fctping();
            //LblpingpcD.Text = Fctping();
            //LblpingpcE.Text = Fctping();
            //LblpingpcF.Text = Fctping();
            //LblpingpcG.Text = Fctping();

            PBpcG.Visible = false;
            LblpcG.Visible = false;
            LblpingpcG.Visible = false;

            if (PBpcE.Visible == false)
            {
                LblpingpcF.Text = "0 ms";
            }
        }

        private string Fctping()
        {
            if (LBstatusOnline.Items.Count <= 7)
            {
                pingIntrandom = pingIntR.Next(25, 28);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 6)
            {
                pingIntrandom = pingIntR.Next(21, 24);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 5)
            {
                pingIntrandom = pingIntR.Next(17, 20);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 4)
            {
                pingIntrandom = pingIntR.Next(13, 16);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 3)
            {
                pingIntrandom = pingIntR.Next(9, 12);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count == 2)
            {
                pingIntrandom = pingIntR.Next(5, 8);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count == 1)
            {
                pingIntrandom = pingIntR.Next(1, 4);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count == 0)
            {
                pingIntrandom = pingIntR.Next(0, 0);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }
            return pingStringResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd.Connection = con; //select a database to select table
            con.Open();
            cmd.CommandType = CommandType.Text; //to define it is a string
            cmd.CommandTimeout = 15;
            surface = CreateGraphics();

            if (HideDevice.Text == "2")
            {
                //only have C,D
                //A
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                //B
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                //E
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 400, 850, 400);
                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;

                //F
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);
                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;

                //G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 1050, 400, 1150, 400);
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Add("C-D");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();
            }

            if (HideDevice.Text == "3")
            {
                //only have C,D,E
                //A
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                //B
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 450, 400, 550, 400);
                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                //F
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);
                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;

                //G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 1050, 400, 1150, 400);
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Add("C-D");
                LBstatusOnline.Items.Add("D-E");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();
            }

            if (HideDevice.Text == "4")
            {
                //only have B,C,D,E
                //A
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                //F
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 900, 400, 1000, 400);
                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;

                //G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 1050, 400, 1150, 400);
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Add("B-C");
                LBstatusOnline.Items.Add("C-D");
                LBstatusOnline.Items.Add("D-E");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();
            }

            if (HideDevice.Text == "5")
            {
                //only have B,C,D,E,F
                //A
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 300, 400, 400, 400);
                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;

                //G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 1050, 400, 1150, 400);
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Add("B-C");
                LBstatusOnline.Items.Add("C-D");
                LBstatusOnline.Items.Add("D-E");
                LBstatusOnline.Items.Add("E-F");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();
            }

            if (HideDevice.Text == "6")
            {
                //only have A,B,C,D,E,F

                //G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 1050, 400, 1150, 400);
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Add("A-B");
                LBstatusOnline.Items.Add("B-C");
                LBstatusOnline.Items.Add("C-D");
                LBstatusOnline.Items.Add("D-E");
                LBstatusOnline.Items.Add("E-F");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();
            }

            if (HideDevice.Text == "7")
            {
                //only have A,B,C,D,E,F,G

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Add("A-B");
                LBstatusOnline.Items.Add("B-C");
                LBstatusOnline.Items.Add("C-D");
                LBstatusOnline.Items.Add("D-E");
                LBstatusOnline.Items.Add("E-F");
                LBstatusOnline.Items.Add("F-G");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();
            }

            con.Close();

        }

        private void btnMyAcc_Click(object sender, EventArgs e)
        {
            con.Open();
            var strSql = "SELECT userName, userPassword, userDeviceNum, userTypeTopology, userEmail ";//
            strSql += "from tbluserinfo";
            var cmdlogin = new SqlCommand(strSql, con);
            var reader = cmdlogin.ExecuteReader();
            while (reader.Read())
            {
                if (reader["userName"].ToString() == lblUsername.Text)
                {
                    MyAccount main = new MyAccount();
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

        private void btnMyTop_Click(object sender, EventArgs e)
        {
            con.Open();
            var strSql = "SELECT userName, userPassword, userDeviceNum, userTypeTopology, userEmail ";//
            strSql += "from tbluserinfo";
            var cmdlogin = new SqlCommand(strSql, con);
            var reader = cmdlogin.ExecuteReader();
            while (reader.Read())
            {
                if (reader["userName"].ToString() == lblUsername.Text)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Landing main = new Landing();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bus7 main = new Bus7();
            main.MethodReceiveName = MethodPassName;
            main.MethodReceiveDevice = MethodPassDevice;
            main.MethodReceiveTopology = MethodPassTopology;
            main.Show();
            this.Dispose(false);
        }

        public string MethodReceiveName
        {
            set { lblUsername.Text = value; }
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
            get { return lblUsername.Text; }
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
