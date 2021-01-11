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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = Application.OpenForms[0];
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = false;
            string[] text = new string[] { "Красный", "Зелёный", "Синий", "Жёлтый", "Коричневый" };
            string[] colors = new string[] { "Red", "Green", "Black", "Blue", "Orange", "Yellow"};
            var randColor = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                ;
            }
            Color slateBlue = Color.FromName("SlateBlue");
            byte g = slateBlue.G;
            byte b = slateBlue.B;
            byte r = slateBlue.R;
            byte a = slateBlue.A;
            label2.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}