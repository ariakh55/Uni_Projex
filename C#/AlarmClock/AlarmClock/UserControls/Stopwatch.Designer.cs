namespace AlarmClock.UserControls
{
    partial class Stopwatch
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
            this.lapBtn = new System.Windows.Forms.Button();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.lapList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clocklbl
            // 
            this.clocklbl.AutoSize = true;
            this.clocklbl.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clocklbl.Location = new System.Drawing.Point(55, 17);
            this.clocklbl.Name = "clocklbl";
            this.clocklbl.Size = new System.Drawing.Size(104, 22);
            this.clocklbl.TabIndex = 3;
            this.clocklbl.Text = "00:00:00";
            // 
            // lapBtn
            // 
            this.lapBtn.Location = new System.Drawing.Point(29, 93);
            this.lapBtn.Name = "lapBtn";
            this.lapBtn.Size = new System.Drawing.Size(75, 23);
            this.lapBtn.TabIndex = 4;
            this.lapBtn.Text = "Lap";
            this.lapBtn.UseVisualStyleBackColor = true;
            this.lapBtn.Click += new System.EventHandler(this.LapBtn_Click);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(29, 64);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(156, 23);
            this.startStopBtn.TabIndex = 5;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(110, 93);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // lapList
            // 
            this.lapList.FormattingEnabled = true;
            this.lapList.Location = new System.Drawing.Point(3, 122);
            this.lapList.Name = "lapList";
            this.lapList.Size = new System.Drawing.Size(211, 134);
            this.lapList.TabIndex = 7;
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lapList);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.lapBtn);
            this.Controls.Add(this.clocklbl);
            this.Name = "Stopwatch";
            this.Size = new System.Drawing.Size(217, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clocklbl;
        private System.Windows.Forms.Button lapBtn;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ListBox lapList;
    }
}
