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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            logic2 = new Form2();
            pamiat = new Form3();
            vnimanie = new Form4();
            logic1 = new Form6();
        }

        readonly Form2 logic2;
        readonly Form3 pamiat;
        readonly Form4 vnimanie;
        readonly Form6 logic1;


        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form0 = Application.OpenForms[0];
            form0.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            logic2.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            vnimanie.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pamiat.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            logic1.Show();
            this.Hide();
        }
    }
}
