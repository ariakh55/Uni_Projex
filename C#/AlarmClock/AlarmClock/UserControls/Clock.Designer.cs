namespace AlarmClock.UserControls
{
    partial class Clock
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
            this.datelbl = new System.Windows.Forms.Label();
            this.clocklbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.setBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.datelbl.Location = new System.Drawing.Point(67, 37);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(48, 22);
            this.datelbl.TabIndex = 3;
            this.datelbl.Text = "Date";
            // 
            // clocklbl
            // 
            this.clocklbl.AutoSize = true;
            this.clocklbl.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clocklbl.Location = new System.Drawing.Point(57, 15);
            this.clocklbl.Name = "clocklbl";
            this.clocklbl.Size = new System.Drawing.Size(70, 22);
            this.clocklbl.TabIndex = 2;
            this.clocklbl.Text = "00:00";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(23, 105);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(132, 23);
            this.setBtn.TabIndex = 5;
            this.setBtn.Text = "Set alarm";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.clocklbl);
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(179, 182);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label clocklbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button setBtn;
    }
}
