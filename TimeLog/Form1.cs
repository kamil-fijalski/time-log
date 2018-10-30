using System;
using System.Xml;
using System.Globalization;
using System.Windows.Forms;

namespace TimeLog
{
    public partial class Form1 : Form
    {
        DateTime work = DateTime.ParseExact("000001", "hhmmss", CultureInfo.InvariantCulture);
        DateTime remain = DateTime.ParseExact("075959", "hhmmss", CultureInfo.InvariantCulture);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;

            System.DateTime firstTime = DateTime.Now;
            startTime.Text = (firstTime.Hour.ToString() + ":" + firstTime.Minute.ToString() + ":" + firstTime.Second.ToString());
            System.DateTime secondTime = firstTime.AddHours(8);
            endTime.Text = (secondTime.Hour.ToString() + ":" + secondTime.Minute.ToString() + ":" + secondTime.Second.ToString());
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            work = work.AddSeconds(1);
            remain = remain.AddSeconds(-1);

            workTime.Text = (work.Hour.ToString() + ":" + work.Minute.ToString() + ":" + work.Second.ToString());
            remainTime.Text = (remain.Hour.ToString() + ":" + remain.Minute.ToString() + ":" + remain.Second.ToString());
        }
    }
}
