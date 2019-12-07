namespace AlarmClock
{
    partial class MainFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.alarmTab = new System.Windows.Forms.TabPage();
            this.stopTab = new System.Windows.Forms.TabPage();
            this.timerTab = new System.Windows.Forms.TabPage();
            this.clock1 = new AlarmClock.UserControls.Clock();
            this.stopwatch1 = new AlarmClock.UserControls.Stopwatch();
            this.cornometer1 = new AlarmClock.UserControls.Chornometer();
            this.tabControl1.SuspendLayout();
            this.alarmTab.SuspendLayout();
            this.stopTab.SuspendLayout();
            this.timerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.alarmTab);
            this.tabControl1.Controls.Add(this.stopTab);
            this.tabControl1.Controls.Add(this.timerTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // alarmTab
            // 
            this.alarmTab.Controls.Add(this.clock1);
            this.alarmTab.Location = new System.Drawing.Point(4, 22);
            this.alarmTab.Name = "alarmTab";
            this.alarmTab.Size = new System.Drawing.Size(297, 264);
            this.alarmTab.TabIndex = 0;
            this.alarmTab.Text = "Clock";
            this.alarmTab.UseVisualStyleBackColor = true;
            // 
            // stopTab
            // 
            this.stopTab.Controls.Add(this.stopwatch1);
            this.stopTab.Location = new System.Drawing.Point(4, 22);
            this.stopTab.Name = "stopTab";
            this.stopTab.Size = new System.Drawing.Size(297, 264);
            this.stopTab.TabIndex = 2;
            this.stopTab.Text = "Stopwatch";
            this.stopTab.UseVisualStyleBackColor = true;
            // 
            // timerTab
            // 
            this.timerTab.Controls.Add(this.cornometer1);
            this.timerTab.Location = new System.Drawing.Point(4, 22);
            this.timerTab.Name = "timerTab";
            this.timerTab.Size = new System.Drawing.Size(297, 264);
            this.timerTab.TabIndex = 1;
            this.timerTab.Text = "Timer";
            this.timerTab.UseVisualStyleBackColor = true;
            // 
            // clock1
            // 
            this.clock1.Location = new System.Drawing.Point(51, 3);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(179, 182);
            this.clock1.TabIndex = 0;
            // 
            // stopwatch1
            // 
            this.stopwatch1.Location = new System.Drawing.Point(38, 0);
            this.stopwatch1.Name = "stopwatch1";
            this.stopwatch1.Size = new System.Drawing.Size(217, 260);
            this.stopwatch1.TabIndex = 0;
            // 
            // cornometer1
            // 
            this.cornometer1.Location = new System.Drawing.Point(17, 3);
            this.cornometer1.Name = "cornometer1";
            this.cornometer1.Size = new System.Drawing.Size(260, 165);
            this.cornometer1.TabIndex = 0;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 290);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasicAlarmClock";
            this.tabControl1.ResumeLayout(false);
            this.alarmTab.ResumeLayout(false);
            this.stopTab.ResumeLayout(false);
            this.timerTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage alarmTab;
        private System.Windows.Forms.TabPage stopTab;
        private System.Windows.Forms.TabPage timerTab;
        private UserControls.Clock clock1;
        private UserControls.Stopwatch stopwatch1;
        private UserControls.Chornometer cornometer1;
    }
}

