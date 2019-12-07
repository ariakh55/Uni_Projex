using System;
using System.Windows.Forms;

namespace AlarmClock.UserControls
{
    public partial class Stopwatch : UserControl
    {
        Timer timer = new Timer();
        int hour = 0, min = 0, sec = 0;
        public Stopwatch()
        {
            InitializeComponent();
            resetBtn.Enabled = false;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            sec = min = hour = 0;
            clocklbl.Text = "00:00:00";
            lapList.Items.Clear();
        }

        private void LapBtn_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                lapList.Items.Add(clocklbl.Text);
        }

        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
                timer.Start();
            else
                timer.Stop();
            resetBtn.Enabled = (timer.Enabled) ? false : true;
            startStopBtn.Text = (timer.Enabled) ? "Stop" : "Start";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string[] temp = new string[3];
            sec++;
            if (sec == 59)
            {
                sec = 0;
                min++;
                if (min == 59)
                {
                    min = 0;
                    hour++;
                }
            }
            if (sec < 10) temp[0] = "0" + sec; else temp[0] = sec.ToString();
            if (min < 10) temp[1] = "0" + min; else temp[1] = min.ToString();
            if (hour < 10) temp[2] = "0" + hour; else temp[2] = hour.ToString();
            clocklbl.Text = string.Format("{0}:{1}:{2}", temp[2], temp[1], temp[0]);
        }
    }
}
