namespace RaceCar
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
            this.LeftBarier = new System.Windows.Forms.Label();
            this.RightBarier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerStreet = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerchecker = new System.Windows.Forms.Timer(this.components);
            this.Enemy = new System.Windows.Forms.Label();
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.listScores = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftBarier
            // 
            this.LeftBarier.BackColor = System.Drawing.Color.Black;
            this.LeftBarier.Location = new System.Drawing.Point(30, 0);
            this.LeftBarier.Name = "LeftBarier";
            this.LeftBarier.Size = new System.Drawing.Size(10, 632);
            this.LeftBarier.TabIndex = 0;
            // 
            // RightBarier
            // 
            this.RightBarier.BackColor = System.Drawing.Color.Black;
            this.RightBarier.Location = new System.Drawing.Point(600, 0);
            this.RightBarier.Name = "RightBarier";
            this.RightBarier.Size = new System.Drawing.Size(10, 632);
            this.RightBarier.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(310, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 120);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(310, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 120);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(310, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 120);
            this.label3.TabIndex = 3;
            // 
            // timerStreet
            // 
            this.timerStreet.Interval = 10;
            this.timerStreet.Tick += new System.EventHandler(this.TimerStreet_Tick);
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Blue;
            this.Car.Location = new System.Drawing.Point(80, 416);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(80, 120);
            this.Car.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(616, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(682, 6);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // timerchecker
            // 
            this.timerchecker.Interval = 1;
            this.timerchecker.Tick += new System.EventHandler(this.Timerchecker_Tick);
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Red;
            this.Enemy.Location = new System.Drawing.Point(514, -120);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(80, 120);
            this.Enemy.TabIndex = 6;
            // 
            // timerEnemy
            // 
            this.timerEnemy.Interval = 25;
            this.timerEnemy.Tick += new System.EventHandler(this.TimerEnemy_Tick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(750, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(620, 523);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 50);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnStartPause
            // 
            this.btnStartPause.Location = new System.Drawing.Point(620, 467);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(242, 50);
            this.btnStartPause.TabIndex = 7;
            this.btnStartPause.TabStop = false;
            this.btnStartPause.Text = "Start";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.BtnStartPause_Click);
            // 
            // listScores
            // 
            this.listScores.FormattingEnabled = true;
            this.listScores.Location = new System.Drawing.Point(620, 87);
            this.listScores.Name = "listScores";
            this.listScores.Size = new System.Drawing.Size(242, 368);
            this.listScores.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(616, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Leaderboard: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 631);
            this.Controls.Add(this.listScores);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RightBarier);
            this.Controls.Add(this.LeftBarier);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeftBarier;
        private System.Windows.Forms.Label RightBarier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerStreet;
        private System.Windows.Forms.Label Car;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerchecker;
        private System.Windows.Forms.Label Enemy;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.ListBox listScores;
        private System.Windows.Forms.Label label5;
    }
}

