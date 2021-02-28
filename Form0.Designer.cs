
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form0
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button20 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.AutoSize = true;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(469, 367);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(420, 90);
            this.button20.TabIndex = 1;
            this.button20.Text = "Выход";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Button20_click);
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button30.AutoSize = true;
            this.button30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button30.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button30.Location = new System.Drawing.Point(469, 271);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(420, 90);
            this.button30.TabIndex = 2;
            this.button30.Text = "Настройки";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.Button30_click);
            // 
            // button40
            // 
            this.button40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button40.AutoSize = true;
            this.button40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button40.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button40.ForeColor = System.Drawing.Color.Black;
            this.button40.Location = new System.Drawing.Point(469, 175);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(420, 90);
            this.button40.TabIndex = 3;
            this.button40.Text = "Играть";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.Button40_click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button20);
            this.Name = "Form0";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button30_click(object sender, EventArgs e)
        {
            nastroiki.Show();
            this.Hide();
        }

        private void Button20_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button40_click(object sender, EventArgs e)
        {
            zapusk.Show();
            this.Hide();
        }

        #endregion
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button40;
    }
}

