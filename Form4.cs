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

        private void Button4_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label4.Hide();
            label5.Hide();
            button4.Hide();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            Random rnd = new Random();
            IList<Color> myColors = new[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Pink };
            string[] myListCilors = { "Красный", "Синий", "Зеленый", "Желтый", "Оранжевый", "Розовый" };
            var l2t = myListCilors[rnd.Next(0, myListCilors.Length)];
            var l2c = myColors[rnd.Next(myColors.Count)];
            label2.Text = l2t;
            label2.ForeColor = l2c;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";

            for (int i = 1; i < 20; i++)
            {
                button2.BackColor = myColors[rnd.Next(myColors.Count)];
                button1.BackColor = myColors[rnd.Next(myColors.Count)];
                button3.BackColor = myColors[rnd.Next(myColors.Count)];
                if (button2.BackColor != button1.BackColor & button2.BackColor != button3.BackColor & button1.BackColor != button3.BackColor & (button1.BackColor == l2c ^ button2.BackColor == l2c ^ button3.BackColor == l2c))
                {
                    break;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = Application.OpenForms[1];
            form1.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button4.Show();
            if (button1.BackColor == label2.ForeColor)
            {
                label4.Show();
            }
            else
            {
                label5.Show();
            }
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button4.Show();
            if (button2.BackColor == label2.ForeColor)
            {
                label4.Show();
            }
            else
            {
                label5.Show();
            }
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button4.Show();
            if (button3.BackColor == label2.ForeColor)
            {
                label4.Show();
            }
            else
            {
                label5.Show();
            }
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}