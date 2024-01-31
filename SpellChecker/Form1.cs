using SpellChecker.View.Mockups;
using SpellChecker.View.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellChecker
{
    public partial class Form1 : Form
    {
        PnlHome pnlHome;

        public Form1()
        {
            InitializeComponent();
            pnlHome = new PnlHome(this);
            this.Controls.Add(pnlHome);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.pnlHome.Size = new System.Drawing.Size(this.Size.Width-5,this.Height-58);
        }
    }
}
