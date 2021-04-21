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
    public partial class Star7 : Form
    {
        static string constr = "Data source=LAPTOP-HP6LE0S6\\SQLEXPRESS;Initial Catalog=NRSFSNdb; Integrated Security=True;";
        SqlConnection con = new SqlConnection(constr); //connect database
        SqlCommand cmd = new SqlCommand(); //defining the command

        string ms = " ms";
        double pingIntrandom;
        string pingStringResult;
        Graphics surface;
        Random pingIntR = new Random();
        Pen penpcAhoriG = new Pen(Color.LemonChiffon, 2);
        Pen penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
        Pen penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
        Pen penpcAdiagdownD = new Pen(Color.LemonChiffon, 2);
        Pen penpcAvertB = new Pen(Color.LemonChiffon, 2);
        Pen penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
        Pen penpcBhoriF = new Pen(Color.LemonChiffon, 2);
        Pen penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
        Pen penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
        Pen penpcBvertc = new Pen(Color.LemonChiffon, 2);
        Pen penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
        Pen penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
        Pen penpcChoriE = new Pen(Color.LemonChiffon, 2);
        Pen penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
        Pen penpcDdiagupG = new Pen(Color.LemonChiffon, 2);
        Pen penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
        Pen penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
        Pen penpcEvertF = new Pen(Color.LemonChiffon, 2);
        Pen penpcFvertG = new Pen(Color.LemonChiffon, 2);
        public Star7()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            surface = CreateGraphics();
            //AAAAAAAAAAAA
            //AhoriG 
            //Pen penpcAhoriG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);

            //AdiagdownF
            //Pen penpcAdiagdownF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);

            //AdiagdownE
            //Pen penpcAdiagdownE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);

            //AdiagdownD
            //Pen penpcAdiagdownD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAdiagdownD, 585, 165, 740, 700);

            //AvertB
            //Pen penpcAvertB = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
            //AAAAAAAAAA

            //BBBBBBBBBBB
            //BdiagupG
            //Pen penpcBdiagupG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

            //BhoriF
            //Pen penpcBhoriF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

            //BdiagdownE
            //Pen penpcBdiagdownE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

            //BdiagdownD
            //Pen penpcBdiagdownD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

            //BvertC
            //Pen penpcBvertc = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcBvertc, 547, 380, 547, 580);

            //AvertB
            //Pen penpcAvertB = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
            //BBBBBBBBBBB

            //CCCCCCCCCCCCCC
            //CdiagupG
            //Pen penpcCdiagupG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

            //CdiagupF
            //Pen penpcCdiagupF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

            //ChoriE
            //Pen penpcChoriE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

            //CdiagdownD
            //Pen penpcCdiagdownD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

            //BvertC
            //Pen penpcBvertc = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
            //CCCCCCCCCCCCCCCCCCC

            //DDDDDDDDDDDDDDDDD
            //DdiagupG
            //Pen penpcDdiagupG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcDdiagupG, 700, 700, 925, 160 );

            //Ddiagupf
            //Pen penpcDdiagupF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

            //DdiagupE
            //Pen penpcDdiagupE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

            //C-D
            //Pen penpcCdiagdownD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

            //BdiagdownD
            //Pen penpcBdiagdownD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

            //AdiagdownD
            //Pen penpcAdiagdownD = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcAdiagdownD, 585, 165, 740, 700);
            //DDDDDDDDDDDDDDDDDDD

            //EEEEEEEEEEEEEEE
            //EvertF
            //Pen penpcEvertF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

            //DdiagupE
            //Pen penpcDdiagupE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

            //ChoriE
            //Pen penpcChoriE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

            //BdiagdownE
            //Pen penpcBdiagdownE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

            //AdiagdownE
            //Pen penpcAdiagdownE = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);
            //EEEEEEEEEEEEEEEE

            //FFFFFFFFFFFFFF
            //FvertG
            //Pen penpcFvertG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

            //EvertF
            //Pen penpcEvertF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

            //Ddiagupf
            //Pen penpcDdiagupF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

            //CdiagupF
            //Pen penpcCdiagupF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

            //BhoriF
            //Pen penpcBhoriF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcBhoriF, 580, 380, 900, 380)

            //AdiagdownF
            //Pen penpcAdiagdownF = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);
            //FFFFFFFFFFFFFF

            //GGGGGGGGGGGGGGGGGGGGGGGGGG
            //FvertG
            //Pen penpcFvertG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

            //DdiagupG
            //Pen penpcDdiagupG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcDdiagupG, 700, 700, 925, 160);

            //CdiagupG
            //Pen penpcCdiagupG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

            //BdiagupG
            //Pen penpcBdiagupG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

            //AhoriG 
            //Pen penpcAhoriG = new Pen(ColorTranslator.FromHtml("#000000"), 2);
            //surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);
            //GGGGGGGGGGGGGGGGGGGGGGGGGG

        }

        private void PBpcA_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="6")
            {
                //AAAAAAAAAAAA
                //AhoriG
                Graphics surface = CreateGraphics();
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //AAAAAAAAAA

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //AAAAAAAAAAAA
                //AhoriG
                Graphics surface = CreateGraphics();
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);

                //AdiagdownD
                penpcAdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownD, 585, 165, 740, 700);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //AAAAAAAAAA

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("A-D");
                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("A-D"))
                {
                    LBstatusOffline.Items.Add("A-D");
                }
                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;
            }
        }

        private void LblpcA_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "6")
            {
                //AAAAAAAAAAAA
                //AhoriG
                Graphics surface = CreateGraphics();
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //AAAAAAAAAA

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //AAAAAAAAAAAA
                //AhoriG
                Graphics surface = CreateGraphics();
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);

                //AdiagdownD
                penpcAdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownD, 585, 165, 740, 700);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //AAAAAAAAAA

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("A-D");
                LBstatusOnline.Items.Remove("A-B");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("A-D"))
                {
                    LBstatusOffline.Items.Add("A-D");
                }
                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;
            }
        }
        private void PBpcB_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="4")
            {
                //BBBBBBBBBBB
                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //BBBBBBBBBBB
                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //BBBBBBBBBBB
                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //BBBBBBBBBBB
                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }
        }

        private void LblpcB_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "4")
            {
                //BBBBBBBBBBB
                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //BBBBBBBBBBB
                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //BBBBBBBBBBB
                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //BBBBBBBBBBB
                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);

                //AvertB
                penpcAvertB = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //BBBBBBBBB

                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("B-C");

                if (!LBstatusOffline.Items.Contains("A-B"))
                {
                    LBstatusOffline.Items.Add("A-B");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcB.Visible = false;
                LblpcB.Visible = false;
                LblpingpcB.Visible = false;
            }
        }

        private void PBpcC_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="4")
            {
                //CCCCCCCCCCCCCC
                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //CCCCCCCCCCCCCC
                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //CdiagdownD
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //CCCCCCCCCCCCCC
                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //CCCCCCCCCCCCCC
                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //CdiagdownD
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }
        }

        private void LblpcC_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "4")
            {
                //CCCCCCCCCCCCCC
                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //CCCCCCCCCCCCCC
                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //CdiagdownD
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //CCCCCCCCCCCCCC
                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //CCCCCCCCCCCCCC
                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //CdiagdownD
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BvertC
                penpcBvertc = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                LBstatusOnline.Items.Remove("B-C");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("C-D");

                if (!LBstatusOffline.Items.Contains("B-C"))
                {
                    LBstatusOffline.Items.Add("B-C");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcC.Visible = false;
                LblpcC.Visible = false;
                LblpingpcC.Visible = false;
            }
        }

        private void PBpcD_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="5")
            {
                //DDDDDDDDDDDDDDDDD
                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //C-D
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //AdiagdownD
                //DDDDDDDDDDDDDDDDDDD

                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupG
                penpcDdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupG, 700, 700, 925, 160);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //C-D
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //AdiagdownD
                penpcAdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownD, 585, 165, 740, 700);
                //DDDDDDDDDDDDDDDDDDD

                LBstatusOnline.Items.Remove("A-D");
                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-G");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("A-D"))
                {
                    LBstatusOffline.Items.Add("A-D");
                }
                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-G"))
                {
                    LBstatusOffline.Items.Add("D-G");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
            }
        }

        private void LblpcD_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "5")
            {
                //DDDDDDDDDDDDDDDDD
                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //C-D
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //AdiagdownD
                //DDDDDDDDDDDDDDDDDDD

                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //DDDDDDDDDDDDDDDDD
                //DdiagupG
                penpcDdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupG, 700, 700, 925, 160);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //C-D
                penpcCdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //AdiagdownD
                penpcAdiagdownD = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownD, 585, 165, 740, 700);
                //DDDDDDDDDDDDDDDDDDD

                LBstatusOnline.Items.Remove("A-D");
                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("D-G");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("D-E");

                if (!LBstatusOffline.Items.Contains("A-D"))
                {
                    LBstatusOffline.Items.Add("A-D");
                }
                if (!LBstatusOffline.Items.Contains("B-D"))
                {
                    LBstatusOffline.Items.Add("B-D");
                }
                if (!LBstatusOffline.Items.Contains("C-D"))
                {
                    LBstatusOffline.Items.Add("C-D");
                }
                if (!LBstatusOffline.Items.Contains("D-G"))
                {
                    LBstatusOffline.Items.Add("D-G");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
            }
        }

        private void PBpcE_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="4")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }
        }

        private void LblpcE_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "4")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);
                //EEEEEEEEEEEEEEEE

                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("B-E");
                LBstatusOnline.Items.Remove("C-E");
                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("A-E"))
                {
                    LBstatusOffline.Items.Add("A-E");
                }
                if (!LBstatusOffline.Items.Contains("B-E"))
                {
                    LBstatusOffline.Items.Add("B-E");
                }
                if (!LBstatusOffline.Items.Contains("C-E"))
                {
                    LBstatusOffline.Items.Add("C-E");
                }
                if (!LBstatusOffline.Items.Contains("D-E"))
                {
                    LBstatusOffline.Items.Add("D-E");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcE.Visible = false;
                LblpcE.Visible = false;
                LblpingpcE.Visible = false;
            }
        }

        private void PBpcF_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="4")
            {
                //FFFFFFFFFFFFFF
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //FFFFFFFFFFFFFF
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }
        }

        private void LblpcF_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "4")
            {
                //FFFFFFFFFFFFFF
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }

            if (HideDevice.Text == "5")
            {
                //FFFFFFFFFFFFFF
                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("E-F");

                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }

                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //FFFFFFFFFFFFFF
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //EvertF
                penpcEvertF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("B-F");
                LBstatusOnline.Items.Remove("C-F");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("E-F");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-F"))
                {
                    LBstatusOffline.Items.Add("A-F");
                }
                if (!LBstatusOffline.Items.Contains("B-F"))
                {
                    LBstatusOffline.Items.Add("B-F");
                }
                if (!LBstatusOffline.Items.Contains("C-F"))
                {
                    LBstatusOffline.Items.Add("C-F");
                }
                if (!LBstatusOffline.Items.Contains("D-F"))
                {
                    LBstatusOffline.Items.Add("D-F");
                }
                if (!LBstatusOffline.Items.Contains("E-F"))
                {
                    LBstatusOffline.Items.Add("E-F");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcF.Visible = false;
                LblpcF.Visible = false;
                LblpingpcF.Visible = false;
            }
        }

        private void PBpcG_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text=="6")
            {
                //GGGGGGGGGGGGGGGGGGGGGGGGGG
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //AhoriG 
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);
                //GGGGGGGGGGGGGGGGGGGGGGGGGG

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //GGGGGGGGGGGGGGGGGGGGGGGGGG
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //DdiagupG
                penpcDdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupG, 700, 700, 925, 160);

                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //AhoriG 
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);
                //GGGGGGGGGGGGGGGGGGGGGGGGGG

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("D-G");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("D-G"))
                {
                    LBstatusOffline.Items.Add("D-G");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;
            }
        }

        private void LblpcG_Click(object sender, EventArgs e)
        {
            if (HideDevice.Text == "6")
            {
                //GGGGGGGGGGGGGGGGGGGGGGGGGG
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //AhoriG 
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);
                //GGGGGGGGGGGGGGGGGGGGGGGGGG

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //GGGGGGGGGGGGGGGGGGGGGGGGGG
                //FvertG
                penpcFvertG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //DdiagupG
                penpcDdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcDdiagupG, 700, 700, 925, 160);

                //CdiagupG
                penpcCdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //BdiagupG
                penpcBdiagupG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //AhoriG 
                penpcAhoriG = new Pen(Color.LemonChiffon, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);
                //GGGGGGGGGGGGGGGGGGGGGGGGGG

                LBstatusOnline.Items.Remove("A-G");
                LBstatusOnline.Items.Remove("B-G");
                LBstatusOnline.Items.Remove("C-G");
                LBstatusOnline.Items.Remove("D-G");
                LBstatusOnline.Items.Remove("F-G");

                if (!LBstatusOffline.Items.Contains("A-G"))
                {
                    LBstatusOffline.Items.Add("A-G");
                }
                if (!LBstatusOffline.Items.Contains("B-G"))
                {
                    LBstatusOffline.Items.Add("B-G");
                }
                if (!LBstatusOffline.Items.Contains("C-G"))
                {
                    LBstatusOffline.Items.Add("C-G");
                }
                if (!LBstatusOffline.Items.Contains("D-G"))
                {
                    LBstatusOffline.Items.Add("D-G");
                }
                if (!LBstatusOffline.Items.Contains("F-G"))
                {
                    LBstatusOffline.Items.Add("F-G");
                }

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;
            }
        }

        private string Fctping()
        {
            if (LBstatusOnline.Items.Count <= 19)
            {
                pingIntrandom = pingIntR.Next(85, 100);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 14)
            {
                pingIntrandom = pingIntR.Next(54, 64);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 10)
            {
                pingIntrandom = pingIntR.Next(33, 43);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 6)
            {
                pingIntrandom = pingIntR.Next(20, 25);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count <= 3)
            {
                pingIntrandom = pingIntR.Next(10, 15);
                pingStringResult = Convert.ToString(pingIntrandom) + ms;
            }

            if (LBstatusOnline.Items.Count == 1)
            {
                pingIntrandom = pingIntR.Next(1, 9);
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

            HideDevice.Text = MethodPassDevice;
            surface = CreateGraphics();

            LblpingpcA.Text = Fctping();
            LblpingpcB.Text = Fctping();
            LblpingpcC.Text = Fctping();
            LblpingpcD.Text = Fctping();
            LblpingpcE.Text = Fctping();
            LblpingpcF.Text = Fctping();
            LblpingpcG.Text = Fctping();

            if (HideDevice.Text == "4")
            {
                //only B,C,E,F

                //BBBBBBBBBBB
                //BhoriF
                penpcBhoriF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BvertC
                penpcBvertc = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //BBBBBBBBBBB

                //CCCCCCCCCCCCCC
                //CdiagupF
                penpcCdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BvertC
                penpcBvertc = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);
                //EEEEEEEEEEEEEEEE

                //FFFFFFFFFFFFFF
                //EvertF
                penpcEvertF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("A-D");
                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("A-G");

                LBstatusOnline.Items.Remove("B-D");
                LBstatusOnline.Items.Remove("B-G");


                LBstatusOnline.Items.Remove("C-D");
                LBstatusOnline.Items.Remove("C-G");


                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("D-G");

                LBstatusOnline.Items.Remove("F-G");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;
                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;
            }

            if (HideDevice.Text=="5")
            {
                //only B,C,D,E,F

                //BBBBBBBBBBB
                //BhoriF
                penpcBhoriF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BvertC
                penpcBvertc = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);
                //BBBBBBBBBBB

                //CCCCCCCCCCCCCC
                //CdiagupF
                penpcCdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //CdiagdownD
                penpcCdiagdownD = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);

                //BvertC
                penpcBvertc = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);
                //EEEEEEEEEEEEEEEE

                //FFFFFFFFFFFFFF
                //EvertF
                penpcEvertF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);
                //FFFFFFFFFFFFFF

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-B");
                LBstatusOnline.Items.Remove("A-D");
                LBstatusOnline.Items.Remove("A-E");
                LBstatusOnline.Items.Remove("A-F");
                LBstatusOnline.Items.Remove("A-G");

                LBstatusOnline.Items.Remove("B-G");

                LBstatusOnline.Items.Remove("C-G");

                LBstatusOnline.Items.Remove("D-G");

                LBstatusOnline.Items.Remove("F-G");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcA.Visible = false;
                LblpcA.Visible = false;
                LblpingpcA.Visible = false;
                PBpcG.Visible = false;
                LblpcG.Visible = false;
                LblpingpcG.Visible = false;
            }

            if (HideDevice.Text == "6")
            {
                //only A,B,C,E,F,G

                //AAAAAAAAAAAA
                //AhoriG 
                penpcAhoriG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);

                //AvertB
                penpcAvertB = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //AAAAAAAAAA

                //BBBBBBBBBBB
                //BhoriF
                penpcBhoriF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BvertC
                penpcBvertc = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //BBBBBBBBBBB

                //CCCCCCCCCCCCCC
                //CdiagupF
                penpcCdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BvertC
                penpcBvertc = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //CCCCCCCCCCCCCCCCCCC

                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //ChoriE
                penpcChoriE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);
                //EEEEEEEEEEEEEEEE

                //FFFFFFFFFFFFFF
                //EvertF
                penpcEvertF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //BhoriF
                penpcBhoriF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);
                //FFFFFFFFFFFFFF

                //GGGGGGGGGGGGGGGGGGGGGGGGGG
                //FvertG
                penpcFvertG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);

                //CdiagupG
                penpcCdiagupG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //BdiagupG
                penpcBdiagupG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);
                //GGGGGGGGGGGGGGGGGGGGGGGGGG

                LBstatusOnline.Text = "";
                LBstatusOnline.Items.Remove("A-D");

                LBstatusOnline.Items.Remove("B-D");

                LBstatusOnline.Items.Remove("C-D");

                LBstatusOnline.Items.Remove("D-E");
                LBstatusOnline.Items.Remove("D-F");
                LBstatusOnline.Items.Remove("D-G");

                LblpingpcA.Text = Fctping();
                LblpingpcB.Text = Fctping();
                LblpingpcC.Text = Fctping();
                LblpingpcD.Text = Fctping();
                LblpingpcE.Text = Fctping();
                LblpingpcF.Text = Fctping();
                LblpingpcG.Text = Fctping();

                PBpcD.Visible = false;
                LblpcD.Visible = false;
                LblpingpcD.Visible = false;
            }

            if (HideDevice.Text == "7")
            {
                //AAAAAAAAAAAA
                //AhoriG 
                penpcAhoriG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAhoriG, 580, 200, 900, 200);

                //AdiagdownF
                penpcAdiagdownF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAdiagdownF, 581, 200, 900, 410);

                //AdiagdownE
                penpcAdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAdiagdownE, 582, 200, 900, 580);

                //AdiagdownD
                penpcAdiagdownD = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAdiagdownD, 585, 165, 740, 700);

                //AvertB
                penpcAvertB = new Pen(Color.Black, 2);
                surface.DrawLine(penpcAvertB, 547, 200, 547, 400);
                //AAAAAAAAAA

                //BBBBBBBBBBB
                //BdiagupG
                penpcBdiagupG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagupG, 580, 410, 900, 180);

                //BhoriF
                penpcBhoriF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBhoriF, 580, 380, 900, 380);

                //BdiagdownE
                penpcBdiagdownE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownE, 580, 380, 900, 590);

                //BdiagdownD
                penpcBdiagdownD = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBdiagdownD, 585, 380, 770, 700);

                //BvertC
                penpcBvertc = new Pen(Color.Black, 2);
                surface.DrawLine(penpcBvertc, 547, 380, 547, 580);
                //BBBBBBBBBBB

                //CCCCCCCCCCCCCC
                //CdiagupG
                penpcCdiagupG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupG, 578, 550, 900, 240);

                //CdiagupF
                penpcCdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagupF, 578, 550, 900, 360);

                //ChoriE
                penpcChoriE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcChoriE, 580, 550, 900, 550);

                //CdiagdownD
                penpcCdiagdownD = new Pen(Color.Black, 2);
                surface.DrawLine(penpcCdiagdownD, 580, 550, 700, 650);
                //CCCCCCCCCCCCCCCCCCC

                //DDDDDDDDDDDDDDDDD
                //DdiagupG
                penpcDdiagupG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcDdiagupG, 700, 700, 925, 160);

                //Ddiagupf
                penpcDdiagupF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcDdiagupF, 700, 700, 930, 355);

                //DdiagupE
                penpcDdiagupE = new Pen(Color.Black, 2);
                surface.DrawLine(penpcDdiagupE, 750, 650, 870, 550);
                //DDDDDDDDDDDDDDDDDDD

                //EEEEEEEEEEEEEEE
                //EvertF
                penpcEvertF = new Pen(Color.Black, 2);
                surface.DrawLine(penpcEvertF, 910, 380, 910, 550);
                //EEEEEEEEEEEEEEEE

                //FFFFFFFFFFFFFF
                //FvertG
                penpcFvertG = new Pen(Color.Black, 2);
                surface.DrawLine(penpcFvertG, 910, 200, 910, 400);
                //FFFFFFFFFFFFFF

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
            Star7 main = new Star7();
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
