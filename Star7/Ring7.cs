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
    public partial class Ring7 : Form
    {
        static string constr = "Data source=LAPTOP-HP6LE0S6\\SQLEXPRESS;Initial Catalog=NRSFSNdb; Integrated Security=True;";
        SqlConnection con = new SqlConnection(constr); //connect database
        SqlCommand cmd = new SqlCommand(); //defining the command

        string ms = " ms";
        double pingIntrandom;
        string pingStringResult;
        Graphics surface;
        Random pingIntR = new Random();
        Pen penpcAB = new Pen(Color.Black, 2);
        Pen penpcAG = new Pen(Color.Black, 2);
        Pen penpcBC = new Pen(Color.Black, 2);
        Pen penpcCD = new Pen(Color.Black, 2);
        Pen penpcDE = new Pen(Color.Black, 2);
        Pen penpcEF = new Pen(Color.Black, 2);
        Pen penpcFG = new Pen(Color.Black, 2);
        Pen penpcBF = new Pen(Color.Black, 2);
        Pen penpcCE = new Pen(Color.Black, 2);
        public Ring7()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            surface = CreateGraphics();
            //AAAAAAAAAAAA
            //AhoriG 
            //Pen penpcAhoriG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAG, 580, 200, 900, 200);

            //AvertB
            //Pen penpcAvertB = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAB, 547, 200, 547, 400);
            //AAAAAAAAAA

            //BBBBBBBBBBB
            //BvertC
            //Pen penpcBvertc = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcBC, 547, 380, 547, 580);

            //CCCCCCCCCCCCCC
            //CdiagdownD
            //Pen penpcCdiagdownD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcCD, 580, 550, 700, 650);
            //CCCCCCCCCCCCCCCCCCC

            //DDDDDDDDDDDDDDDDD
            //DdiagupE
            //Pen penpcDdiagupE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcDE, 750, 650, 870, 550);
            //DDDDDDDDDDDDDDDDDDD

            //EEEEEEEEEEEEEEE
            //EvertF
            //Pen penpcEvertF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcEF, 910, 380, 910, 550);
            //EEEEEEEEEEEEEEEE

            //FFFFFFFFFFFFFF
            //FvertG
            //Pen penpcFvertG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcFG, 910, 200, 910, 400);
            //FFFFFFFFFFFFFF

            //GGGGGGGGGGGGGGGGGGGGGGGGGG
            //AhoriG 
            //Pen penpcAhoriG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAG, 580, 200, 900, 200);
            //GGGGGGGGGGGGGGGGGGGGGGGGGG

            //extraaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            surface.DrawLine(penpcBF, 580, 380, 900, 380);
            //ChoriE
            surface.DrawLine(penpcCE, 580, 550, 900, 550);
            //extraaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa

        }

        private void PBpcA_Click(object sender, EventArgs e)
        {
            //AAAAAAAAAAAA
            //AhoriG
            Graphics surface = CreateGraphics();
            penpcAG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcAG, 580, 200, 900, 200);

            //AvertB
            penpcAB = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcAB, 547, 200, 547, 400);
            //AAAAAAAAAA

            LBstatusOnline.Items.Remove("A-G");
            LBstatusOnline.Items.Remove("A-B");

            if (!LBstatusOffline.Items.Contains("A-G"))
            {
                LBstatusOffline.Items.Add("A-G");
            }
            if (!LBstatusOffline.Items.Contains("A-B"))
            {
                LBstatusOffline.Items.Add("A-B");
            }

            if (LblpingpcA.Text !="0 ms")
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

            if (PBpcF.Visible == false)
            {
                LblpingpcG.Text = "0 ms";
            }
        }

        private void LblpcA_Click(object sender, EventArgs e)
        {
            //AAAAAAAAAAAA
            //AhoriG
            Graphics surface = CreateGraphics();
            penpcAG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcAG, 580, 200, 900, 200);

            //AvertB
            penpcAB = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcAB, 547, 200, 547, 400);
            //AAAAAAAAAA

            LBstatusOnline.Items.Remove("A-G");
            LBstatusOnline.Items.Remove("A-B");

            if (!LBstatusOffline.Items.Contains("A-G"))
            {
                LBstatusOffline.Items.Add("A-G");
            }
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

            if (PBpcF.Visible == false)
            {
                LblpingpcG.Text = "0 ms";
            }
        }
        private void PBpcB_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="4")
            {
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                //BBBBBBBBBBBBBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
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

                if (PBpcE.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="5")
            {
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                //BBBBBBBBBBBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
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

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                if (PBpcE.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //AvertB
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 547, 200, 547, 400);
                //BBBBBBBBB

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

                if (PBpcG.Visible == false)
                {
                    LblpingpcA.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text=="7")
            {
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //AvertB
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 547, 200, 547, 400);
                //BBBBBBBBB

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

                if (PBpcG.Visible == false)
                {
                    LblpingpcA.Text = "0 ms";
                }

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
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                //BBBBBBBBBBBBBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
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

                if (PBpcE.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                //BBBBBBBBBBBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
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

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;

                if (PBpcE.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //AvertB
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 547, 200, 547, 400);
                //BBBBBBBBB

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

                if (PBpcG.Visible == false)
                {
                    LblpingpcA.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                //BBBBBBBBBBB
                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);

                //AvertB
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 547, 200, 547, 400);
                //BBBBBBBBB

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

                if (PBpcG.Visible == false)
                {
                    LblpingpcA.Text = "0 ms";
                }

                if (PBpcD.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }
            }
        }

        private void PBpcC_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="3")
            {
                //CCCCCCCCCCCCCC
                //CdiagdownD
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);

                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text=="4")
            {
                //CCCCCCCCCCCCCC
                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
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

                if (PBpcF.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                //CCCCCCCCCCCCCC
                //CdiagdownD
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
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

                if (PBpcF.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //CCCCCCCCCCCCCC
                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
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

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text =="7")
            {
                //CCCCCCCCCCCCCC
                //CdiagdownD
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
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
            if (HideDevice.Text == "3")
            {
                //CCCCCCCCCCCCCC
                //CdiagdownD
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);

                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text == "4")
            {
                //CCCCCCCCCCCCCC
                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
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

                if (PBpcF.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                //CCCCCCCCCCCCCC
                //CdiagdownD
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
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

                if (PBpcF.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }

                if (PBpcE.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //CCCCCCCCCCCCCC
                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
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

                if (PBpcF.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                //CCCCCCCCCCCCCC
                //CdiagdownD
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);

                //BvertC
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
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
            if (HideDevice.Text=="3")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);

                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //DDDDDDDDDDDDDDDDDDD


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

                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);

                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //DDDDDDDDDDDDDDDDDDD


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

            if (HideDevice.Text == "7")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);

                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //DDDDDDDDDDDDDDDDDDD

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
            if (HideDevice.Text == "3")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);

                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //DDDDDDDDDDDDDDDDDDD


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

                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);

                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //DDDDDDDDDDDDDDDDDDD


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

            if (HideDevice.Text == "7")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);

                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //DDDDDDDDDDDDDDDDDDD

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
                //EEEEEEEEEEEEEEE
                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //CCCCCCCCCCCCCCCCCCC

                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "4")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
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

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcB.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                //EEEEEEEEEEEEEEEE

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

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }

                if (PBpcB.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
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

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcG.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                //EEEEEEEEEEEEEEEE

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
                //EEEEEEEEEEEEEEE
                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //CCCCCCCCCCCCCCCCCCC

                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "4")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
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

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcB.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                //EEEEEEEEEEEEEEEE

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

                if (PBpcC.Visible == false)
                {
                    LblpingpcD.Text = "0 ms";
                }

                if (PBpcB.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //ChoriE
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
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

                if (PBpcB.Visible == false)
                {
                    LblpingpcC.Text = "0 ms";
                }

                if (PBpcG.Visible == false)
                {
                    LblpingpcF.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);

                //DdiagupE
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                //EEEEEEEEEEEEEEEE

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
            if (HideDevice.Text=="4")
            {
                //FFFFFFFFFFFFFF
                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("B-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
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

                if (PBpcC.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                //FFFFFFFFFFFFFF
                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                //BBBBBBBBBBBBBBBBBB

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("B-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
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

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 910, 200, 910, 400);

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

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

                if (PBpcC.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }

                if (PBpcA.Visible == false)
                {
                    LblpingpcG.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 910, 200, 910, 400);

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

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

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }

                if (PBpcA.Visible == false)
                {
                    LblpingpcG.Text = "0 ms";
                }
            }
        }

        private void LblpcF_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "4")
            {
                //FFFFFFFFFFFFFF
                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("B-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }

                if (LblpingpcB.Text != "0 ms")
                {
                    LblpingpcB.Text = Fctping();
                }
                if (LblpingpcC.Text != "0 ms")
                {
                    LblpingpcC.Text = Fctping();
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

                if (PBpcC.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "5")
            {
                //FFFFFFFFFFFFFF
                //BhoriF
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                //BBBBBBBBBBBBBBBBBB

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("B-F");

                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
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

                if (PBpcC.Visible == false)
                {
                    LblpingpcB.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "6")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 910, 200, 910, 400);

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

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

                if (PBpcC.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }

                if (PBpcA.Visible == false)
                {
                    LblpingpcG.Text = "0 ms";
                }
            }

            if (HideDevice.Text == "7")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 910, 200, 910, 400);

                //EvertF
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                //FFFFFFFFFFFFFF

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

                if (PBpcD.Visible == false)
                {
                    LblpingpcE.Text = "0 ms";
                }

                if (PBpcA.Visible == false)
                {
                    LblpingpcG.Text = "0 ms";
                }
            }
        }

        private void PBpcG_Click(object sender, EventArgs e)
        {
            //GGGGGGGGGGGGGGGGGGGGGGGGGG
            //FvertG
            penpcFG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcFG, 910, 200, 910, 400);
            //AhoriG 
            penpcAG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcAG, 580, 200, 900, 200);
            //GGGGGGGGGGGGGGGGGGGGGGGGGG

            LBstatusOnline.Items.Remove("A-G");
            LBstatusOnline.Items.Remove("F-G");

            if (!LBstatusOffline.Items.Contains("A-G"))
            {
                LBstatusOffline.Items.Add("A-G");
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

            PBpcG.Visible = false;
            LblpcG.Visible = false;
            LblpingpcG.Visible = false;

            if (PBpcE.Visible == false)
            {
                LblpingpcF.Text = "0 ms";
            }

            if (PBpcB.Visible == false)
            {
                LblpingpcA.Text = "0 ms";
            }
        }

        private void LblpcG_Click(object sender, EventArgs e)
        {
            //GGGGGGGGGGGGGGGGGGGGGGGGGG
            //FvertG
            penpcFG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcFG, 910, 200, 910, 400);
            //AhoriG 
            penpcAG = new Pen(Color.LemonChiffon, 2);
            surface.DrawLine(penpcAG, 580, 200, 900, 200);
            //GGGGGGGGGGGGGGGGGGGGGGGGGG

            LBstatusOnline.Items.Remove("A-G");
            LBstatusOnline.Items.Remove("F-G");

            if (!LBstatusOffline.Items.Contains("A-G"))
            {
                LBstatusOffline.Items.Add("A-G");
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

            PBpcG.Visible = false;
            LblpcG.Visible = false;
            LblpingpcG.Visible = false;

            if (PBpcE.Visible == false)
            {
                LblpingpcF.Text = "0 ms";
            }

            if (PBpcB.Visible == false)
            {
                LblpingpcA.Text = "0 ms";
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

            HideDevice.Text = MethodPassDevice;

            if (HideDevice.Text == "3")
            {
                //Only C,D,E

                //AAAAAAAAAAAAAAAAAAAAAAA
                //A-B
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 580, 200, 900, 200);
                //A-G
                penpcAG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAG, 580, 200, 900, 200);
                LblpingpcA.Visible = false;
                PBpcA.Visible = false;
                LblpcA.Visible = false;
                //AAAAAAAAAAAAAAAAAAAAAAA

                //BBBBBBBBBBBBBBBBBBBBBBB
                //B-C
                penpcBC = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBC, 547, 380, 547, 580);
                //B-F
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                LblpingpcB.Visible = false;
                PBpcB.Visible = false;
                LblpcB.Visible = false;
                //BBBBBBBBBBBBBBBBBBBBBBB

                //FFFFFFFFFFFFFFFFFFFFFFF
                //F-B DONE
                //F-G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 910, 200, 910, 400);
                //E-F
                penpcEF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEF, 910, 380, 910, 550);
                LblpingpcF.Visible = false;
                PBpcF.Visible = false;
                LblpcF.Visible = false;
                //FFFFFFFFFFFFFFFFFFFFFFF

                //GGGGGGGGGGGGGGGGGGGGGGG
                //F-G DONE
                LblpingpcG.Visible = false;
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                //GGGGGGGGGGGGGGGGGGGGGGG

                //add
                //C-E
                penpcCE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Add("C-D");
                LBstatusOnline.Items.Add("D-E");
                LBstatusOnline.Items.Add("C-E");

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
                //Only B,C,E,F
                //AAAAAAAAAAAAAAAAAAAAAAA
                //A-B
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 580, 200, 900, 200);
                //A-G
                penpcAG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAG, 580, 200, 900, 200);
                LblpingpcA.Visible = false;
                PBpcA.Visible = false;
                LblpcA.Visible = false;
                //AAAAAAAAAAAAAAAAAAAAAAA

                //DDDDDDDDDDDDDDDDDDDDDDD
                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //D-E
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                LblpingpcD.Visible = false;
                PBpcD.Visible = false;
                LblpcD.Visible = false;
                //DDDDDDDDDDDDDDDDDDDDDDD

                //GGGGGGGGGGGGGGGGGGGGGGG
                //F-A DONE
                //F-G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 910, 200, 910, 400);
                LblpingpcG.Visible = false;
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                //GGGGGGGGGGGGGGGGGGGGGGG

                //add
                //B-F
                penpcBF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);
                //C-E
                penpcCE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Add("B-C");
                LBstatusOnline.Items.Add("B-F");
                LBstatusOnline.Items.Add("C-E");
                LBstatusOnline.Items.Add("E-F");

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
                //Only B,C,D,E,F
                //AAAAAAAAAAAAAAAAAAAAAAA
                //A-B
                penpcAB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAB, 580, 200, 900, 200);
                //A-G
                penpcAG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAG, 580, 200, 900, 200);
                LblpingpcA.Visible = false;
                PBpcA.Visible = false;
                LblpcA.Visible = false;
                //AAAAAAAAAAAAAAAAAAAAAAA

                //GGGGGGGGGGGGGGGGGGGGGGG
                //G-A DONE
                //F-G
                penpcFG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFG, 910, 200, 910, 400);
                LblpingpcG.Visible = false;
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                //GGGGGGGGGGGGGGGGGGGGGGG

                //add
                //B-F
                penpcBF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);

                //hide
                //C-E
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Add("B-C");
                LBstatusOnline.Items.Add("B-F");
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
                //Only A,B,C,E,F,G
                //DDDDDDDDDDDDDDDDDDDDDDD
                //C-D
                penpcCD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCD, 580, 550, 700, 650);
                //D-E
                penpcDE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDE, 750, 650, 870, 550);
                LblpingpcD.Visible = false;
                PBpcD.Visible = false;
                LblpcD.Visible = false;
                //DDDDDDDDDDDDDDDDDDDDDDD

                //add
                //C-E
                penpcCE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);

                //hide
                //B-F
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Add("A-B");
                LBstatusOnline.Items.Add("A-G");
                LBstatusOnline.Items.Add("B-C");
                LBstatusOnline.Items.Add("C-E");
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

            if (HideDevice.Text == "7")
            {
                //Only A,B,C,D,E,F,G
                //hide
                //C-E
                penpcCE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCE, 580, 550, 900, 550);
                //B-F
                penpcBF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBF, 580, 380, 900, 380);

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Add("A-B");
                LBstatusOnline.Items.Add("A-G");
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
            var strSql = "SELECT userName, userPassword, userDeviceNum, userTypeTopology, userEmail ";//
            strSql += "from tbluserinfo";
            var cmdlogin = new SqlCommand(strSql, con);
            var reader = cmdlogin.ExecuteReader();
            con.Open();
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
            Ring7 main = new Ring7();
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

        private void LBstatusOnline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
