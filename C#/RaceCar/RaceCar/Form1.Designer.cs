namespace WindowsFormsApp1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Enemy = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(340, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 120);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(340, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 120);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(340, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 120);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(178, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 120);
            this.label4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(40, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 470);
            this.label5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(680, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 470);
            this.label6.TabIndex = 3;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Red;
            this.Enemy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enemy.Location = new System.Drawing.Point(80, -100);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(80, 120);
            this.Enemy.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(747, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 13);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "lblScore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 462);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Enemy;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScore;
    }
}

