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
            logic = new Form2();
            pamiat = new Form3();
            vnimanie = new Form4();
        }

        Form2 logic;
        Form3 pamiat;
        Form4 vnimanie;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logic.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vnimanie.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pamiat.Show();
            this.Hide();
        }


    }
}