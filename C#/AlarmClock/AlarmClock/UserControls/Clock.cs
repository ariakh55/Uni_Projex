using System;
using System.Windows.Forms;
using WMPLib;

namespace AlarmClock.UserControls
{
    public partial class Clock : UserControl
    {
        Timer timer = new Timer();
        DateTime usertime;
        bool is_alarmset = false;
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        public Clock()
        {
            InitializeComponent();
            wplayer.URL = @".\Alarm.mp3";
            wplayer.controls.stop();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick; ;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            clocklbl.Text = current.ToShortTimeString();
            datelbl.Text = current.ToShortDateString();
            if (is_alarmset)
            {
                if(current.Day==usertime.Day &&
                    current.Hour==usertime.Hour &&
                    current.Minute==usertime.Minute &&
                    current.Second == usertime.Second)
                {
                    wplayer.controls.play();
                    MessageBox.Show("Ring ring ....", "Alarm Clock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wplayer.controls.stop();
                    is_alarmset = false;
                    setBtn.Text = "Set alarm";
                }
            }
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            if (!is_alarmset)
            {
                usertime = dateTimePicker1.Value;
                MessageBox.Show("Alarm set!!");
                is_alarmset = true;
                setBtn.Text = "Cancel alarm";
            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    is_alarmset = false;
                    setBtn.Text = "Set alarm";

                }
            }
        }
    }
}
