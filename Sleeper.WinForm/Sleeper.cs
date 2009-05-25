using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sleeper.WinForm
{
    public partial class Sleeper : Form
    {
        private static int TIMER_INTERVAL = 1000; // 1 second
        private static int TIMER_MAX = 5 * 60 * 1000; // 5 mins
        private long totalTimeInMillis = 0;

        public Sleeper()
        {
            InitializeComponent();
        }

        private void Sleeper_Load(object sender, EventArgs e)
        {
            setupProgressBar();
            createTimer();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setupProgressBar()
        {
            sleepProgress.Minimum = 0;
            sleepProgress.Maximum = TIMER_MAX;
            sleepProgress.Step = TIMER_INTERVAL;
            sleepProgress.Value = 0;
        }

        private void createTimer()
        {
            Timer sleepTimer = new Timer();
            sleepTimer.Interval = TIMER_INTERVAL;
            sleepTimer.Tick += new EventHandler(timerUpdate);
            sleepTimer.Start();
        }

        private void timerUpdate(object sender, EventArgs e)
        {
            totalTimeInMillis += TIMER_INTERVAL;
            if (totalTimeInMillis > TIMER_MAX)
            {
                // trigger sleep
                Win32ApiHelper.doSuspeng();
                Application.Exit();
            }
            else
            {
                // update progress bar
                sleepProgress.PerformStep();
            }
        }
    }
}
