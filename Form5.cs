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
    public partial class Form5 : Form
    {
        public Form5()
        {
            //InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Name = "Form5";
            this.ResumeLayout(false);

        }
    }
}
