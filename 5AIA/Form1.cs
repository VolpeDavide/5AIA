using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5AIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GO TO SCALABERNI GIULIA'S BLOG
        private void btnScalaberni_Click(object sender, EventArgs e)
        {
            // Launch browser to my blog...
            System.Diagnostics.Process.Start("http://giuliascalaberni.wordpress.com");
        }


        private void btnGabrieleStefani_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.gabrielestefani.tryalbtester.com");

        }

        private void btnMattiaRanfagni_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mattiaranfagni.wordpress.com");
        }

        private void btnBlogCalamandrei_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.calamandrei-lorenzo.it");
        }
    }
}
