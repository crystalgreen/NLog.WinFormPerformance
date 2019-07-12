namespace NLog.WinFormPerformance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.logsLabel = new System.Windows.Forms.Label();
            this.numMsgParSecTrackBar = new System.Windows.Forms.TrackBar();
            this.msgPerSecondLabel = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.waitBetweenMessagesTrackBar = new System.Windows.Forms.TrackBar();
            this.waitBetweenMessagesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.queueLimitTextBox = new System.Windows.Forms.TextBox();
            this.applyLoggerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fullBatchSizeWriteLimitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.batchSizeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxLinesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.overflowActionComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeToSleepBetweenBatchesTextBox = new System.Windows.Forms.TextBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numMsgParSecTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitBetweenMessagesTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logRichTextBox.Location = new System.Drawing.Point(21, 31);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(511, 407);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            this.logRichTextBox.TextChanged += new System.EventHandler(this.LogRichTextBox_TextChanged);
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.Location = new System.Drawing.Point(18, 15);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(33, 13);
            this.logsLabel.TabIndex = 1;
            this.logsLabel.Text = "Logs:";
            // 
            // numMsgParSecTrackBar
            // 
            this.numMsgParSecTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numMsgParSecTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.form1BindingSource, "NumMessagesPerSecond", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numMsgParSecTrackBar.LargeChange = 50;
            this.numMsgParSecTrackBar.Location = new System.Drawing.Point(537, 72);
            this.numMsgParSecTrackBar.Maximum = 10000;
            this.numMsgParSecTrackBar.Minimum = 1;
            this.numMsgParSecTrackBar.Name = "numMsgParSecTrackBar";
            this.numMsgParSecTrackBar.Size = new System.Drawing.Size(237, 45);
            this.numMsgParSecTrackBar.TabIndex = 2;
            this.numMsgParSecTrackBar.Value = 1;
            // 
            // msgPerSecondLabel
            // 
            this.msgPerSecondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msgPerSecondLabel.AutoSize = true;
            this.msgPerSecondLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.form1BindingSource, "NumMessagesPerSecond", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "0 messages/s"));
            this.msgPerSecondLabel.Location = new System.Drawing.Point(538, 45);
            this.msgPerSecondLabel.Name = "msgPerSecondLabel";
            this.msgPerSecondLabel.Size = new System.Drawing.Size(64, 13);
            this.msgPerSecondLabel.TabIndex = 3;
            this.msgPerSecondLabel.Text = "messages/s";
            // 
            // startStopButton
            // 
            this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButton.Location = new System.Drawing.Point(543, 15);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 4;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // waitBetweenMessagesTrackBar
            // 
            this.waitBetweenMessagesTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.waitBetweenMessagesTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.form1BindingSource, "WaitBetweenMessagesInMs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.waitBetweenMessagesTrackBar.LargeChange = 50;
            this.waitBetweenMessagesTrackBar.Location = new System.Drawing.Point(537, 149);
            this.waitBetweenMessagesTrackBar.Maximum = 1000;
            this.waitBetweenMessagesTrackBar.Name = "waitBetweenMessagesTrackBar";
            this.waitBetweenMessagesTrackBar.Size = new System.Drawing.Size(237, 45);
            this.waitBetweenMessagesTrackBar.TabIndex = 5;
            this.waitBetweenMessagesTrackBar.Value = 500;
            // 
            // waitBetweenMessagesLabel
            // 
            this.waitBetweenMessagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.waitBetweenMessagesLabel.AutoSize = true;
            this.waitBetweenMessagesLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.form1BindingSource, "WaitBetweenMessagesInMs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "\"Wait\" 0 \"ms between sending messages\""));
            this.waitBetweenMessagesLabel.Location = new System.Drawing.Point(537, 124);
            this.waitBetweenMessagesLabel.Name = "waitBetweenMessagesLabel";
            this.waitBetweenMessagesLabel.Size = new System.Drawing.Size(163, 13);
            this.waitBetweenMessagesLabel.TabIndex = 6;
            this.waitBetweenMessagesLabel.Text = "Wait between sending messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "If the window freezes, you can keep shift pressed until logging stops.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.timeToSleepBetweenBatchesTextBox);
            this.groupBox1.Controls.Add(this.overflowActionComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.batchSizeTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fullBatchSizeWriteLimitTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.queueLimitTextBox);
            this.groupBox1.Location = new System.Drawing.Point(543, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AsyncWrapper";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "QueueLimit";
            // 
            // queueLimitTextBox
            // 
            this.queueLimitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.queueLimitTextBox.Location = new System.Drawing.Point(162, 83);
            this.queueLimitTextBox.Name = "queueLimitTextBox";
            this.queueLimitTextBox.Size = new System.Drawing.Size(75, 20);
            this.queueLimitTextBox.TabIndex = 1;
            // 
            // applyLoggerButton
            // 
            this.applyLoggerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyLoggerButton.Location = new System.Drawing.Point(713, 415);
            this.applyLoggerButton.Name = "applyLoggerButton";
            this.applyLoggerButton.Size = new System.Drawing.Size(75, 23);
            this.applyLoggerButton.TabIndex = 0;
            this.applyLoggerButton.Text = "Apply";
            this.applyLoggerButton.UseVisualStyleBackColor = true;
            this.applyLoggerButton.Click += new System.EventHandler(this.ApplyLoggerButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FullBatchSizeWriteLimit";
            // 
            // fullBatchSizeWriteLimitTextBox
            // 
            this.fullBatchSizeWriteLimitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullBatchSizeWriteLimitTextBox.Location = new System.Drawing.Point(162, 108);
            this.fullBatchSizeWriteLimitTextBox.Name = "fullBatchSizeWriteLimitTextBox";
            this.fullBatchSizeWriteLimitTextBox.Size = new System.Drawing.Size(75, 20);
            this.fullBatchSizeWriteLimitTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "BatchSize";
            // 
            // batchSizeTextBox
            // 
            this.batchSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.batchSizeTextBox.Location = new System.Drawing.Point(162, 135);
            this.batchSizeTextBox.Name = "batchSizeTextBox";
            this.batchSizeTextBox.Size = new System.Drawing.Size(75, 20);
            this.batchSizeTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.maxLinesTextBox);
            this.groupBox2.Location = new System.Drawing.Point(543, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RichTextBoxTarget";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "MaxLines";
            // 
            // maxLinesTextBox
            // 
            this.maxLinesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLinesTextBox.Location = new System.Drawing.Point(162, 23);
            this.maxLinesTextBox.Name = "maxLinesTextBox";
            this.maxLinesTextBox.Size = new System.Drawing.Size(75, 20);
            this.maxLinesTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "OverflowAction";
            // 
            // overflowActionComboBox
            // 
            this.overflowActionComboBox.FormattingEnabled = true;
            this.overflowActionComboBox.Location = new System.Drawing.Point(162, 19);
            this.overflowActionComboBox.Name = "overflowActionComboBox";
            this.overflowActionComboBox.Size = new System.Drawing.Size(75, 21);
            this.overflowActionComboBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "TimeToSleepBetweenBatches";
            // 
            // timeToSleepBetweenBatchesTextBox
            // 
            this.timeToSleepBetweenBatchesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeToSleepBetweenBatchesTextBox.Location = new System.Drawing.Point(162, 51);
            this.timeToSleepBetweenBatchesTextBox.Name = "timeToSleepBetweenBatchesTextBox";
            this.timeToSleepBetweenBatchesTextBox.Size = new System.Drawing.Size(75, 20);
            this.timeToSleepBetweenBatchesTextBox.TabIndex = 9;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(NLog.WinFormPerformance.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waitBetweenMessagesLabel);
            this.Controls.Add(this.waitBetweenMessagesTrackBar);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.msgPerSecondLabel);
            this.Controls.Add(this.applyLoggerButton);
            this.Controls.Add(this.numMsgParSecTrackBar);
            this.Controls.Add(this.logsLabel);
            this.Controls.Add(this.logRichTextBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "NLog RichTextBoxTarget Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMsgParSecTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitBetweenMessagesTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logsLabel;
        private System.Windows.Forms.TrackBar numMsgParSecTrackBar;
        private System.Windows.Forms.Label msgPerSecondLabel;
        private System.Windows.Forms.Button startStopButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar waitBetweenMessagesTrackBar;
        private System.Windows.Forms.Label waitBetweenMessagesLabel;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button applyLoggerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox queueLimitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullBatchSizeWriteLimitTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox batchSizeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxLinesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox overflowActionComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox timeToSleepBetweenBatchesTextBox;
    }
}

