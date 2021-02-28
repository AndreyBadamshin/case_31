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
    public partial class Form6 : Form

    {
        public static int scrs;
        public Form6()
        {
            InitializeComponent();
        }
        int count = 10;
        List<int> listc = new List<int>();
        private void testcq()
        {
            var random = new Random();
            listc.Add(1);
            for (var i = 2; i < count; i++)
            {
                var swap = random.Next(i - 1);
                listc.Add(listc[swap]);
                listc[swap] = i;
            }
        }
        private void buttonf_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[1];
            this.Hide();
            form1.Show();

            listc.Clear();
            label1.Text = "123456789";
            label2.Text = "";

            buttons.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void buttons_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            testcq();

            label1.Text = "123456789";
            label2.Text = "";
            label5.Text = scrs.ToString();

            buttons.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            label1.Visible = false;
            label2.Visible = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;

            button1.Text = listc[0].ToString();
            button2.Text = listc[1].ToString();
            button3.Text = listc[2].ToString();
            button4.Text = listc[3].ToString();
            button5.Text = listc[4].ToString();
            button6.Text = listc[5].ToString();
            button7.Text = listc[6].ToString();
            button8.Text = listc[7].ToString();
            button9.Text = listc[8].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button1.Text;
            button1.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text.ToString() + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                    label5.Text = label5.Text.ToString() + 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button2.Text;
            button2.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button3.Text;
            button3.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button4.Text;
            button4.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button5.Text;
            button5.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text.ToString() + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button6.Text;
            button6.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text.ToString() + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button7.Text;
            button7.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text.ToString() + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button8.Text;
            button8.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text.ToString() + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button9.Text;
            button9.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                    label5.Text = label5.Text.ToString() + 1;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            testcq();

            label1.Text = "123456789";
            label2.Text = "";

            buttons.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            listc.Clear();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            scrs = 0;
        }
    }
}
