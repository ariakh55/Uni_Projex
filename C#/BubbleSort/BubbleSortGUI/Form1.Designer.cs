namespace BubbleSortGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.arrayLbl = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.checkLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numbers :";
            // 
            // arrayLbl
            // 
            this.arrayLbl.AutoSize = true;
            this.arrayLbl.Location = new System.Drawing.Point(82, 9);
            this.arrayLbl.Name = "arrayLbl";
            this.arrayLbl.Size = new System.Drawing.Size(0, 13);
            this.arrayLbl.TabIndex = 1;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(233, 4);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(233, 33);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 5;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // checkLbl
            // 
            this.checkLbl.AutoSize = true;
            this.checkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLbl.ForeColor = System.Drawing.Color.Magenta;
            this.checkLbl.Location = new System.Drawing.Point(124, 33);
            this.checkLbl.Name = "checkLbl";
            this.checkLbl.Size = new System.Drawing.Size(0, 25);
            this.checkLbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 74);
            this.Controls.Add(this.checkLbl);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.arrayLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arrayLbl;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label checkLbl;
    }
}

