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
    public partial class Sites : Form
    {
        public Sites()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cubeworldwiki.net/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.reddit.com/r/cubeworld");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://picroma.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("http://cubeworldforum.org/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("http://wiki.cubeworldforum.org/index.php?title=Pets");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("http://wollay.blogspot.nl/");
        }
    }
}
