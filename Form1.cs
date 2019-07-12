using NLog.Targets.Wrappers;
using NLog.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLog.WinFormPerformance
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        private bool LogWriteStarted = false;
        int numMessagesPerSecond;
        public int NumMessagesPerSecond
        {
            get
            {
                return numMessagesPerSecond;
            }
            set
            {
                if (numMessagesPerSecond != value)
                {
                    numMessagesPerSecond = value;
                    NotifyPropertyChanged();
                }
            }
        }

        int waitBetweenMessagesInMs;
        public int WaitBetweenMessagesInMs
        {
            get
            {
                return waitBetweenMessagesInMs;
            }
            set
            {
                if (waitBetweenMessagesInMs != value)
                {
                    waitBetweenMessagesInMs = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int MessageCount;
        private AsyncTargetWrapper guiWrapper;
        private RichTextBoxTarget logWindow;

        public event PropertyChangedEventHandler PropertyChanged;

        public Form1()
        {
            InitializeComponent();
            form1BindingSource.DataSource = this;
            NumMessagesPerSecond = 1;
            WaitBetweenMessagesInMs = 500;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigLogger();
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ConfigLogger()
        {

            logWindow = new NLog.Windows.Forms.RichTextBoxTarget
            {
                Name = "LogWindow",
                Layout = "${date:format=yyyy.MM.dd HH.mm.ss} ${threadname:padding=-6} ${threadid:padding=-2} ${pad:padding=-7:inner=[${level:uppercase=True}]}: ${message}${onexception:inner=${literal:text=\\:} ${exception:innerformat=Message:maxInnerExceptionLevel=10:innerExceptionSeparator=-->:format=Message}}",
                ControlName = "logRichTextBox",
                FormName = "Form1",
                AutoScroll = true,
                MaxLines = 500,
                UseDefaultRowColoringRules = true
            };
            maxLinesTextBox.Text = logWindow.MaxLines.ToString();
            guiWrapper = new NLog.Targets.Wrappers.AsyncTargetWrapper()
            {
                Name = "GUI",
                OverflowAction = NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Discard,
                BatchSize = 10,
                QueueLimit = 500,
                FullBatchSizeWriteLimit = 1,
                TimeToSleepBetweenBatches = 400,
                WrappedTarget = logWindow
            };
            timeToSleepBetweenBatchesTextBox.Text = guiWrapper.TimeToSleepBetweenBatches.ToString();
            overflowActionComboBox.Items.AddRange(Enum.GetNames(typeof(AsyncTargetWrapperOverflowAction)));
            overflowActionComboBox.SelectedIndex = (int)guiWrapper.OverflowAction;
            queueLimitTextBox.Text = guiWrapper.QueueLimit.ToString();
            fullBatchSizeWriteLimitTextBox.Text = guiWrapper.FullBatchSizeWriteLimit.ToString();
            batchSizeTextBox.Text = guiWrapper.BatchSize.ToString();
            LogManager.Configuration.AddTarget(guiWrapper.Name, guiWrapper);
            LogManager.Configuration.LoggingRules.Add(new NLog.Config.LoggingRule("*", LogLevel.Trace, guiWrapper));
            LogManager.ReconfigExistingLoggers();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            LogWriteStarted = !LogWriteStarted;
            UpdateStartStopButtonText();
            if (LogWriteStarted)
            {
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            else
                backgroundWorker1.CancelAsync();
        }

        private void UpdateStartStopButtonText()
        {
            startStopButton.Text = LogWriteStarted
                ? "Stop"
                : "Start";
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var levels = new[] { LogLevel.Trace, LogLevel.Debug, LogLevel.Info, LogLevel.Warn, LogLevel.Error, LogLevel.Fatal };
            while (!backgroundWorker1.CancellationPending)
            {
                int numMessages = Math.Max(NumMessagesPerSecond * WaitBetweenMessagesInMs / 1000, 1);
                for (int i = 0; i < numMessages; i++)
                    Logger.Log(levels[MessageCount % levels.Length], "This is log message #{0}", ++MessageCount);
                System.Threading.Thread.Sleep(WaitBetweenMessagesInMs);
                if (Control.ModifierKeys == Keys.Shift)
                {
                    break;
                }
            }
            LogWriteStarted = false;
            MessageCount = 0;
            this.Invoke(new Action(() => UpdateStartStopButtonText()));
        }

        private void ApplyLoggerButton_Click(object sender, EventArgs e)
        {
            logWindow.MaxLines = Convert.ToInt32(maxLinesTextBox.Text);
            guiWrapper.TimeToSleepBetweenBatches = Convert.ToInt32(timeToSleepBetweenBatchesTextBox.Text);
            guiWrapper.OverflowAction = (AsyncTargetWrapperOverflowAction)overflowActionComboBox.SelectedIndex;
            guiWrapper.QueueLimit = Convert.ToInt32(queueLimitTextBox.Text);
            guiWrapper.FullBatchSizeWriteLimit = Convert.ToInt32(fullBatchSizeWriteLimitTextBox.Text);
            guiWrapper.BatchSize = Convert.ToInt32(batchSizeTextBox.Text);
            LogManager.ReconfigExistingLoggers();
        }

        private void LogRichTextBox_TextChanged(object sender, EventArgs e)
        {
            logsLabel.Text = $"{logRichTextBox.Lines.Length} logs";
        }
    }
}
