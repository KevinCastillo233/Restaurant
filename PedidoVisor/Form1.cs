using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
namespace PruebaVisorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            geckoWebBrowser1.Navigate("https://restauranteqr17.000webhostapp.com/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (geckoWebBrowser1.Url.Equals("about:black"))
            {
                geckoWebBrowser1.Reload();
            }

            
        }
    }
}
