namespace AlarmClock.UserControls
{
    partial class Chornometer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clocklbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hourTxt = new System.Windows.Forms.NumericUpDown();
            this.secTxt = new System.Windows.Forms.NumericUpDown();
            this.minTxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hourTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // clocklbl
            // 
            this.clocklbl.AutoSize = true;
            this.clocklbl.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clocklbl.Location = new System.Drawing.Point(77, 23);
            this.clocklbl.Name = "clocklbl";
            this.clocklbl.Size = new System.Drawing.Size(104, 22);
            this.clocklbl.TabIndex = 3;
            this.clocklbl.Text = "00:00:00";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(130, 48);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(49, 77);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(156, 23);
            this.startStopBtn.TabIndex = 8;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(49, 48);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(75, 23);
            this.setBtn.TabIndex = 7;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sec";
            // 
            // hourTxt
            // 
            this.hourTxt.Location = new System.Drawing.Point(42, 113);
            this.hourTxt.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hourTxt.Name = "hourTxt";
            this.hourTxt.Size = new System.Drawing.Size(40, 20);
            this.hourTxt.TabIndex = 13;
            // 
            // secTxt
            // 
            this.secTxt.Location = new System.Drawing.Point(201, 113);
            this.secTxt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secTxt.Name = "secTxt";
            this.secTxt.Size = new System.Drawing.Size(40, 20);
            this.secTxt.TabIndex = 14;
            // 
            // minTxt
            // 
            this.minTxt.Location = new System.Drawing.Point(117, 113);
            this.minTxt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(44, 20);
            this.minTxt.TabIndex = 15;
            // 
            // Cornometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minTxt);
            this.Controls.Add(this.secTxt);
            this.Controls.Add(this.hourTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.clocklbl);
            this.Name = "Cornometer";
            this.Size = new System.Drawing.Size(260, 172);
            ((System.ComponentModel.ISupportInitialize)(this.hourTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clocklbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hourTxt;
        private System.Windows.Forms.NumericUpDown secTxt;
        private System.Windows.Forms.NumericUpDown minTxt;
    }
}
