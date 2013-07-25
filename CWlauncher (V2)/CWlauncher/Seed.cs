using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CWlauncher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        int Line = 1;
        string Line1;
        string Line2;
        string Line3;
        string Line4;
        string Line5;
        string Line6;
        string Line7;
        string Line8;
        string Line9;
        string Line10;
        string Line11;
        string Line12;

        //For seed
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Server.cfg");
            if (textBox1.Text != "")
            {

                
                if (IsAllNumbers(textBox1.Text) == true)
                {
                    sw.Write(textBox1.Text);
                    label2.Text = textBox1.Text;
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Only us Numbers", "error");
                    textBox1.Text = "";

                }
                sw.Close();
            }
            else
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 1000000000);
                sw.Write(randomNumber);
                label2.Text = randomNumber.ToString();
                sw.Close();
            }

            
        }
        //for Seed
        public static bool IsAllNumbers(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seed_Load(object sender, EventArgs e)
        {
            //Load for Seed

                StreamReader sr = new StreamReader("Server.cfg");
                string sLine;
                sLine = sr.ReadLine();
                label2.Text = sLine;
                sr.Close();


                //Load for Settings
                StreamReader settings = new StreamReader("options.cfg");
                Line1 = settings.ReadLine();
                Line++;
                while (Line < 13)
                {
                    if (Line == 2) { Line2 = settings.ReadLine(); }
                    if (Line == 3) { Line3 = settings.ReadLine(); }
                    if (Line == 4) { Line4 = settings.ReadLine(); }
                    if (Line == 5) { Line5 = settings.ReadLine(); }
                    if (Line == 6) { Line6 = settings.ReadLine(); }
                    if (Line == 7) { Line7 = settings.ReadLine(); }
                    if (Line == 8) { Line8 = settings.ReadLine(); }
                    if (Line == 9) { Line9 = settings.ReadLine(); }
                    if (Line == 10) { Line10 = settings.ReadLine(); }
                    if (Line == 11) { Line11 = settings.ReadLine(); }
                    if (Line == 12) { Line12 = settings.ReadLine(); }
                    Line++;
                }
                settings.Close();


                //setting all the Setings to how they are
                try
                {
                    //fullscreen
                    if (Line1 == "fullscreen 1") { cbFS.Text = "Yes"; }
                    else if (Line1 == "fullscreen 0") { cbFS.Text = "No"; }

                    //Resolution
                    char[] MyChar = { 'r', 'e', 's', 'o', 'l', 'u', 't', 'i', 'o', 'n', 'X', 'Y', ' ' };
                    string Resolution = Line2.TrimStart(MyChar) + " x " + Line3.TrimStart(MyChar);
                    cbReso.Text = Resolution;
                    if (cbReso.Text == "") { MessageBox.Show("Sorry i didn't program your selected resolution into the program, keep the resolution bar empty or select one of the resolutions in the drop down box."); cbReso.Text = "Unknown"; }


                    //Language
                    if (Line10 == "language 0") { cbLanguage.Text = "English"; }

                    //InvertY
                    if (Line11 == "invertY 0") { cbInvertY.Text = "No"; }
                    else if (Line11 == "invertY 1") { cbInvertY.Text = "Yes"; }

                    //AA
                    if (Line4 == "antiAliasing 0") { tbAA.Value = 0; lblAA.Text = "Off"; }
                    else if (Line4 == "antiAliasing 1") { tbAA.Value = 1; lblAA.Text = "2x"; }
                    else if (Line4 == "antiAliasing 2") { tbAA.Value = 2; lblAA.Text = "4x"; }

                    //renderDistance
                    tbRD.Value = Convert.ToInt32(Line5.Remove(0, 15));
                    lblRD.Text = Line5.Remove(0, 15) + "%";

                    //soundVolume
                    tbSV.Value = Convert.ToInt32(Line6.Remove(0, 12));
                    lblSV.Text = Line6.Remove(0, 12) + "%";

                    //MusicVolume
                    tbMV.Value = Convert.ToInt32(Line7.Remove(0, 12));
                    lblMV.Text = Line7.Remove(0, 12) + "%";

                    //cameraSpeed
                    tbCS.Value = Convert.ToInt32(Line8.Remove(0, 12));
                    lblCS.Text = Line8.Remove(0, 12) + "%";

                    //cameraSmoothness
                    tbCSmooth.Value = Convert.ToInt32(Line9.Remove(0, 17));
                    lblCSmooth.Text = Line9.Remove(0, 17) + "%";

                    //MaxFPS
                    //30 = 33
                    //62 = 16
                    //83 = 12
                    //100 = 10
                    //111 = 9
                    //142 = 7
                    //200 = 5
                    //Unlimited = 0
                    int maxFPSvalue = Convert.ToInt32(Line12.Remove(0, 11));
                    if (maxFPSvalue == 33) { tbFSP.Value = 0; lblFPS.Text = "30 "; }
                    else if (maxFPSvalue == 16) { tbFSP.Value = 1; lblFPS.Text = "62"; }
                    else if (maxFPSvalue == 12) { tbFSP.Value = 2; lblFPS.Text = "83"; }
                    else if (maxFPSvalue == 10) { tbFSP.Value = 3; lblFPS.Text = "100 "; }
                    else if (maxFPSvalue == 9) { tbFSP.Value = 4; lblFPS.Text = "111"; }
                    else if (maxFPSvalue == 7) { tbFSP.Value = 5; lblFPS.Text = "142"; }
                    else if (maxFPSvalue == 5) { tbFSP.Value = 6; lblFPS.Text = "200"; }
                    else if (maxFPSvalue == 0) { tbFSP.Value = 7; lblFPS.Text = "No limit"; }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }


        }
        //Scrolling
        private void tbAA_Scroll(object sender, EventArgs e)
        {
            if (tbAA.Value == 0) { lblAA.Text = "Off"; }
            if (tbAA.Value == 1) { lblAA.Text = "2x"; }
            if (tbAA.Value == 2) { lblAA.Text = "4x"; }
        }

        private void tbRD_Scroll(object sender, EventArgs e)
        {
            lblRD.Text = tbRD.Value.ToString() + "%";
        }
        private void tbSV_Scroll(object sender, EventArgs e)
        {
            lblSV.Text = tbSV.Value.ToString() + "%";
        }
        private void tbMV_Scroll(object sender, EventArgs e)
        {
            lblMV.Text = tbMV.Value.ToString() + "%";
        }

        private void tbCS_Scroll(object sender, EventArgs e)
        {
            lblCS.Text = tbCS.Value.ToString() + "%";
        }

        private void tbCSmooth_Scroll(object sender, EventArgs e)
        {
            lblCSmooth.Text = tbCSmooth.Value.ToString() + "%";
            
        }

        private void tbFSP_Scroll(object sender, EventArgs e)
        {
            if (tbFSP.Value == 0) { lblFPS.Text = "30 fps"; }
            else if (tbFSP.Value == 1) { lblFPS.Text = "62 fps"; }
            else if (tbFSP.Value == 2) { lblFPS.Text = "83 fps"; }
            else if (tbFSP.Value == 3) { lblFPS.Text = "100 fps"; }
            else if (tbFSP.Value == 4) { lblFPS.Text = "111 fps"; }
            else if (tbFSP.Value == 5) { lblFPS.Text = "142 fps"; }
            else if (tbFSP.Value == 6) { lblFPS.Text = "200 fps"; }
            else if (tbFSP.Value == 7) { lblFPS.Text = "No limit "; }
        }


        //Saving Changes to Settings
        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter SaveSettings = new StreamWriter("options.cfg");
            //fullscreen
            if (cbFS.Text == "Yes") { SaveSettings.WriteLine("fullscreen 1"); }
            else if (cbFS.Text == "No") { SaveSettings.WriteLine("fullscreen 0"); }

            //resolution
            if (cbReso.Text == "1440 x 900") { SaveSettings.WriteLine("resolutionX 1440"); SaveSettings.WriteLine("resolutionY 900"); }
            else if (cbReso.Text == "1920 x 1080") { SaveSettings.WriteLine("resolutionX 1920"); SaveSettings.WriteLine("resolutionY 1080"); }
            else if (cbReso.Text == "1680 x 1050") { SaveSettings.WriteLine("resolutionX 1680"); SaveSettings.WriteLine("resolutionY 1050"); }
            else if (cbReso.Text == "1600 x 1024") { SaveSettings.WriteLine("resolutionX 1600"); SaveSettings.WriteLine("resolutionY 1024"); }
            else if (cbReso.Text == "1600 x 900") { SaveSettings.WriteLine("resolutionX 1600"); SaveSettings.WriteLine("resolutionY 900"); }
            else if (cbReso.Text == "1280 x 960") { SaveSettings.WriteLine("resolutionX 1280"); SaveSettings.WriteLine("resolutionY 960"); }
            else if (cbReso.Text == "1280 x 720") { SaveSettings.WriteLine("resolutionX 1280"); SaveSettings.WriteLine("resolutionY 720"); }
            else if (cbReso.Text == "1024 x 768") { SaveSettings.WriteLine("resolutionX 1024"); SaveSettings.WriteLine("resolutionY 768"); }
            else if (cbReso.Text == "800 x 600") { SaveSettings.WriteLine("resolutionX 800"); SaveSettings.WriteLine("resolutionY 600"); }
            else if (cbReso.Text == "") { SaveSettings.WriteLine("resolutionX " + Line2); SaveSettings.WriteLine("resolutionY " + Line3); }

            //AA
            SaveSettings.WriteLine("antiAliasing " + tbAA.Value);

            //RenderDistance
            SaveSettings.WriteLine("renderDistance " + tbRD.Value);

            //SoundVolume
            SaveSettings.WriteLine("soundVolume " + tbSV.Value);

            //musicVolume
            SaveSettings.WriteLine("musicVolume " + tbMV.Value);

            //CameraSpeed
            SaveSettings.WriteLine("cameraSpeed " + tbCS.Value);

            //CameraSmoothness
            SaveSettings.WriteLine("cameraSmoothness " + tbCSmooth.Value);

            //Language
            SaveSettings.WriteLine("language 0");

            //invertY
            if (cbInvertY.Text == "Yes") { SaveSettings.WriteLine("invertY 1"); }
            else if (cbInvertY.Text == "No") { SaveSettings.WriteLine("invertY 0"); }

            //MaxFPS
            if (tbFSP.Value == 0) { SaveSettings.WriteLine("minTimeStep 33"); }
            else if (tbFSP.Value == 1) { SaveSettings.WriteLine("minTimeStep 16"); }
            else if (tbFSP.Value == 2) { SaveSettings.WriteLine("minTimeStep 12"); }
            else if (tbFSP.Value == 3) { SaveSettings.WriteLine("minTimeStep 10"); }
            else if (tbFSP.Value == 4) { SaveSettings.WriteLine("minTimeStep 9"); }
            else if (tbFSP.Value == 5) { SaveSettings.WriteLine("minTimeStep 7"); }
            else if (tbFSP.Value == 6) { SaveSettings.WriteLine("minTimeStep 5"); }
            else if (tbFSP.Value == 7) { SaveSettings.WriteLine("minTimeStep 0"); }

            SaveSettings.Close();
            
        }



    }
}
