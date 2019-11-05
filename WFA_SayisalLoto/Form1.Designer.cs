namespace WFA_SayisalLoto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 184);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(630, 53);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "Çekiliş Yap";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // t6
            // 
            this.t6.Enabled = false;
            this.t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6.Location = new System.Drawing.Point(553, 96);
            this.t6.Multiline = true;
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(100, 82);
            this.t6.TabIndex = 5;
            this.t6.Text = "0";
            this.t6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t4
            // 
            this.t4.Enabled = false;
            this.t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.Location = new System.Drawing.Point(341, 96);
            this.t4.Multiline = true;
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(100, 82);
            this.t4.TabIndex = 3;
            this.t4.Text = "0";
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2
            // 
            this.t2.Enabled = false;
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(129, 96);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 82);
            this.t2.TabIndex = 1;
            this.t2.Text = "0";
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t5
            // 
            this.t5.Enabled = false;
            this.t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5.Location = new System.Drawing.Point(447, 96);
            this.t5.Multiline = true;
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(100, 82);
            this.t5.TabIndex = 4;
            this.t5.Text = "0";
            this.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t3
            // 
            this.t3.Enabled = false;
            this.t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.Location = new System.Drawing.Point(235, 96);
            this.t3.Multiline = true;
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 82);
            this.t3.TabIndex = 2;
            this.t3.Text = "0";
            this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t1
            // 
            this.t1.Enabled = false;
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(23, 96);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 82);
            this.t1.TabIndex = 0;
            this.t1.Text = "0";
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 261);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Name = "Form1";
            this.Text = "Sayısal Loto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Timer timer1;
    }
}

