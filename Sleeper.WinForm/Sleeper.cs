using System;
using System.Windows.Forms;

namespace Sleeper.WinForm
{
    public partial class Sleeper : Form
    {
        private long _totalTimeInMillis;
        private const int TimerInterval = 1000; // 1 second
        private const int TimerMax = 5 * 60 * 1000; // 5 mins

        public Sleeper()
        {
            InitializeComponent();
        }

        private void Sleeper_Load(object sender, EventArgs e)
        {
            SetupProgressBar();
            CreateTimer();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetupProgressBar()
        {
            sleepProgress.Minimum = 0;
            sleepProgress.Maximum = TimerMax;
            sleepProgress.Step = TimerInterval;
            sleepProgress.Value = 0;
        }

        private void CreateTimer()
        {
            var sleepTimer = new Timer {Interval = TimerInterval};
            sleepTimer.Tick += TimerUpdate;
            sleepTimer.Start();
        }

        private void TimerUpdate(object sender, EventArgs e)
        {
            _totalTimeInMillis += TimerInterval;
            if (_totalTimeInMillis > TimerMax)
            {
                // trigger sleep
                Win32ApiHelper.DoSuspeng();
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
