using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CWlauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Launch_Click(object sender, EventArgs e)
        {
            if (File.Exists("Cube.exe")) { Process.Start("Cube.exe"); if (checkBox1.Checked == true) { this.Close(); } }
            else { MessageBox.Show("Cube.exe was not found, make sure that you have this launcer installed in the same folder.", "Error"); }
            
        }

        private void LaunchServer_Click(object sender, EventArgs e)
        {
            if (File.Exists("Server.exe")) { Process.Start("Server.exe"); }
            else { MessageBox.Show("Server.exe was not found, make sure that you have this launcer installed in the same folder.", "Error"); }
            
        }

        private void LaunchOfficial_Click(object sender, EventArgs e)
        {
            if (File.Exists("CubeLauncher.exe")) { Process.Start("CubeLauncher.exe"); if (checkBox1.Checked == true) { this.Close(); } }
            else { MessageBox.Show("CubeLauncher.exe was not found, make sure that you have this launcer installed in the same folder.", "Error"); }
            
        }

        private void Websites_Click(object sender, EventArgs e)
        {
            Sites sites = new Sites();
            sites.Show();
        }

        private void Seed_Click(object sender, EventArgs e)
        {
            if (File.Exists("options.cfg") && File.Exists("Server.cfg"))
            {
                Settings seed = new Settings();
                seed.Show();
            }
            else { MessageBox.Show("Server.cfg or options.cfg were not found by the program, make sure that you've ran Server.exe atleast once and that you've installed the launcher inside the cubeworld directory.", "Error"); }
        }

        private void Directory_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;
            Process.Start(startupPath);
            
        }
    }
}
