using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            zapusk = new Form1();
            nastroiki = new Form5();
        }

        readonly Form1 zapusk;
        readonly Form5 nastroiki;

        private void Button40_сlick(object sender, EventArgs e)
        {
            zapusk.Show();
            this.Hide();
        }

        private void Button20_сlick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button30_сlick(object sender, EventArgs e)
        {
            nastroiki.Show();
            this.Hide();
        }
    }
}
