using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RaceCar
{
    public partial class Form1 : Form
    {
        int scoreCounter = 0;
        int score = 0;
        int playercounter = 0;
        bool isPaused = true;
        int[] street = new int[2];
        int carDim = 0;
        Timer timerCarR = new Timer();
        Timer timerCarL = new Timer();
        Random randomLocation = new Random();

        void setProp()
        {
            street[0] = RightBarier.Left - LeftBarier.Right;
            street[1] = this.Height;
            if (File.Exists("Leaderboard.txt"))
            {
                listScores.Items.AddRange(File.ReadAllLines("Leaderboard.txt"));
                playercounter = listScores.Items.Count;
            }
        }

        public Form1()
        {
            InitializeComponent();
            setProp();
            timerCarL.Interval = 10;
            timerCarR.Interval = 10;
            timerCarL.Tick += delegate
            {
                Car.Left -= 5;
            };
            timerCarR.Tick += delegate
            {
                Car.Left += 5;
            };
        }

        private void TimerStreet_Tick(object sender, EventArgs e)
        {
            label1.Top += 5;
            label2.Top += 5;
            label3.Top += 5;
            if (label1.Top >= this.Height)
                label1.Top = -130;
            if (label2.Top >= this.Height)
                label2.Top = -130;
            if (label3.Top >= this.Height)
                label3.Top = -130;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isPaused)
            {
                switch (e.KeyData)
                {
                    case Keys.Left:
                        timerCarL.Start();
                        break;
                    case Keys.Right:
                        timerCarR.Start();
                        break;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    timerCarL.Stop();
                    break;
                case Keys.Right:
                    timerCarR.Stop();
                    break;
            }
        }

        private void Timerchecker_Tick(object sender, EventArgs e)
        {
            if (++scoreCounter == 30)
            {
                lblScore.Text = score.ToString();
                score++;
                if (score % 150 == 0)
                {
                    this.BackColor = (this.BackColor == Color.White) ? Color.Black : Color.White;
                    LeftBarier.BackColor = RightBarier.BackColor = label1.BackColor = label2.BackColor = label3.BackColor =
                        (LeftBarier.BackColor == Color.Black) ? Color.White : Color.Black;
                    label4.ForeColor = lblScore.ForeColor = label5.ForeColor =
                        (label4.ForeColor == Color.Black) ? Color.White : Color.Black;
                }
                scoreCounter = 0;
            }

            carDim = street[0] - Car.Left;

            if (carDim <= 40 || carDim >= 520 || Car.Bounds.IntersectsWith(Enemy.Bounds))
            {
                playercounter++;
                timerchecker.Stop();
                timerCarL.Stop();
                timerCarR.Stop();
                timerEnemy.Stop();
                timerStreet.Stop();
                isPaused = true;
                btnStartPause.Text = "Start";
                MessageBox.Show("oh no!");
                listScores.Items.Add(string.Format("Player{0}\tScore:{1}", playercounter, score));
                File.AppendAllText(@"Leaderboard.txt", listScores.Items[playercounter - 1]+"\n\r");
                score = 0;
                Enemy.Top = -120;
                Car.Left = 80;
            }
        }


        private void TimerEnemy_Tick(object sender, EventArgs e)
        {
            if (Enemy.Top == -120)
                Enemy.Left = randomLocation.Next(40, 520);
            Enemy.Top += 5;
            if (Enemy.Top >= this.Height)
                Enemy.Top = -120;
        }

        private void BtnStartPause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            if (!isPaused)
            {
                timerchecker.Start();
                timerStreet.Start();
                timerEnemy.Start();
            }
            else
            {
                timerchecker.Stop();
                timerStreet.Stop();
                timerEnemy.Stop();
            }
            this.Focus();
            btnStartPause.Text = (isPaused) ? "Start" : "Pause";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string saveContent = $"{Car.Left}\n\r{Enemy.Top}\r\n{Enemy.Left}\r\n{score}\r\n{label1.Top}\r\n{label2.Top}\r\n{label3.Top}";
            File.WriteAllText("settings.txt", saveContent);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string[] saveContents = File.ReadAllLines("settings.txt");
            Car.Left = int.Parse(saveContents[0]);
            Enemy.Left = int.Parse(saveContents[1]);
            Enemy.Top = int.Parse(saveContents[2]);
            score = int.Parse(saveContents[3]);
            lblScore.Text = score.ToString();
            label1.Top = int.Parse(saveContents[4]);
            label2.Left = int.Parse(saveContents[5]);
            label3.Left = int.Parse(saveContents[6]);
        }
    }
}
