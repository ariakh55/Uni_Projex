using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChanger
{
    public partial class MainFrm : Form
    {
        Timer changer = new Timer();
        int counter = 0;
        public MainFrm()
        {
            InitializeComponent();
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            changer.Interval = 1;
            changer.Enabled = true;
            changer.Tick += delegate
            {
                counter++;
                if (counter == 100)
                {
                    button1.BackColor = (button1.BackColor == Color.White) ? Color.Black : Color.White;
                    button1.ForeColor = (button1.ForeColor == Color.Black) ? Color.White : Color.Black;
                    counter = 0;
                }
            };
        }
    }
}
