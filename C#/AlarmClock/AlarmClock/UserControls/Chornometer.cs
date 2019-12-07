using System;
using System.Windows.Forms;
using WMPLib;

namespace AlarmClock.UserControls
{
    public partial class Chornometer : UserControl
    {
        decimal hour = 0, min = 0, sec = 0;
        string[] temp = new string[3];
        WindowsMediaPlayer wmplayer = new WindowsMediaPlayer();
        Timer timer = new Timer();
        public Chornometer()
        {
            InitializeComponent();
            wmplayer.URL = @".\Alarm.mp3";
            wmplayer.controls.stop();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            resetBtn.Enabled = false;
            startStopBtn.Enabled = false;
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            if (hourTxt.Value + minTxt.Value + secTxt.Value != 0)
            {

                startStopBtn.Enabled = true;
                hour = hourTxt.Value;
                min = minTxt.Value;
                sec = secTxt.Value;
                hourTxt.Value = 0;
                minTxt.Value = 0;
                secTxt.Value = 0;
                if (sec < 10) temp[0] = "0" + sec; else temp[0] = sec.ToString();
                if (min < 10) temp[1] = "0" + min; else temp[1] = min.ToString();
                if (hour < 10) temp[2] = "0" + hour; else temp[2] = hour.ToString();
                clocklbl.Text = $"{temp[2]}:{temp[1]}:{temp[0]}";
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            sec = min = hour = 0;
            clocklbl.Text = "00:00:00";
            resetBtn.Enabled = false;
            startStopBtn.Enabled = false;
            setBtn.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                if (min == 0)
                {
                    if (hour == 0)
                    {
                        timer.Stop();
                        wmplayer.controls.play();
                        MessageBox.Show("CountDown ended!!");
                        resetBtn.Enabled = false;
                        startStopBtn.Enabled = false;
                        startStopBtn.Text = "Start";
                        setBtn.Enabled = true;
                        wmplayer.controls.stop();
                    }
                    else
                    {
                        hour--;
                        min = 59;
                    }
                }
                else
                {
                    min--;
                    sec = 59;
                }
            }
            else sec--;
            if (sec < 10) temp[0] = "0" + sec; else temp[0] = sec.ToString();
            if (min < 10) temp[1] = "0" + min; else temp[1] = min.ToString();
            if (hour < 10) temp[2] = "0" + hour; else temp[2] = hour.ToString();
            clocklbl.Text = $"{temp[2]}:{temp[1]}:{temp[0]}";
        }

        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
                resetBtn.Enabled = false;
            }
            else
            {
                timer.Stop();
                resetBtn.Enabled = true;

            }
            setBtn.Enabled = false;
            startStopBtn.Text = (timer.Enabled) ? "Stop" : "Start";
        }
    }
}
