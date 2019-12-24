using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isCrashed = false;
        Random rnd = new Random();
        Timer timer_carL = new Timer();
        Timer timer_carR = new Timer();
        Timer timer_score = new Timer();
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            timer_score.Enabled = true;
            lblScore.Text = "0";
            timer_score.Interval = 850;
            timer_score.Tick += delegate
            {
                score++;
                lblScore.Text = score.ToString();
            };
            timer_carL.Interval = 5;
            timer_carL.Tick += delegate
            {
                label4.Left -= 5;
                
            };
            timer_carR.Interval = 5;
            timer_carR.Tick += delegate
            {
                label4.Left += 5;
                
            };
            timer1.Interval = 1;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Top += 5;
            label2.Top += 5;
            label3.Top += 5;
            if (label3.Top >= this.Height)
                label3.Top = -10;
            if (label2.Top >= this.Height)
                label2.Top = -10;
            if (label1.Top >= this.Height)
                label1.Top = -10;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!isCrashed)
                    {
                        timer_carL.Start();
                        if (label4.Left <= label5.Right)
                        {
                            isCrashed = true;
                            timer_carR.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer_score.Stop();
                        }
                    }
                    else
                        return;
                    break;
                case Keys.Right:
                    if (!isCrashed)
                    {
                        timer_carR.Start();
                        if (label4.Right >= label6.Left)
                        {
                            isCrashed = true;
                            timer_carL.Stop();
                            timer1.Stop();
                            timer2.Stop();
                            timer_score.Stop();
                        }
                    }
                    else
                        return;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    timer_carL.Stop();
                    break;
                case Keys.Right:
                    timer_carR.Stop();
                    break;
            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            Enemy.Top += 5;
            if (Enemy.Top >= this.Height)
            {
                Enemy.Left = rnd.Next(50, 550);
                Enemy.Top = -100;
            }
        }
    }
}
