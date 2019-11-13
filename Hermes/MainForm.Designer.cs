namespace Hermes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.delayField = new System.Windows.Forms.NumericUpDown();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.targetChannelLabel = new System.Windows.Forms.Label();
            this.currentChannelTextBox = new System.Windows.Forms.TextBox();
            this.currentChannelLabel = new System.Windows.Forms.Label();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayField)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Location = new System.Drawing.Point(12, 12);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.Size = new System.Drawing.Size(510, 235);
            this.messagesTextBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 22);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.labelDelay);
            this.controlsGroupBox.Controls.Add(this.delayField);
            this.controlsGroupBox.Controls.Add(this.startButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 279);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(510, 66);
            this.controlsGroupBox.TabIndex = 2;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(352, 27);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(97, 13);
            this.labelDelay.TabIndex = 3;
            this.labelDelay.Text = "Delay (in seconds):";
            // 
            // delayField
            // 
            this.delayField.Location = new System.Drawing.Point(455, 25);
            this.delayField.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.delayField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayField.Name = "delayField";
            this.delayField.Size = new System.Drawing.Size(49, 20);
            this.delayField.TabIndex = 2;
            this.delayField.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.delayField.ValueChanged += new System.EventHandler(this.delayField_ValueChanged);
            // 
            // channelTextBox
            // 
            this.channelTextBox.Enabled = false;
            this.channelTextBox.Location = new System.Drawing.Point(103, 253);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(155, 20);
            this.channelTextBox.TabIndex = 3;
            // 
            // targetChannelLabel
            // 
            this.targetChannelLabel.AutoSize = true;
            this.targetChannelLabel.Location = new System.Drawing.Point(11, 256);
            this.targetChannelLabel.Name = "targetChannelLabel";
            this.targetChannelLabel.Size = new System.Drawing.Size(83, 13);
            this.targetChannelLabel.TabIndex = 4;
            this.targetChannelLabel.Text = "Target Channel:";
            // 
            // currentChannelTextBox
            // 
            this.currentChannelTextBox.Enabled = false;
            this.currentChannelTextBox.Location = new System.Drawing.Point(367, 253);
            this.currentChannelTextBox.Name = "currentChannelTextBox";
            this.currentChannelTextBox.Size = new System.Drawing.Size(155, 20);
            this.currentChannelTextBox.TabIndex = 3;
            // 
            // currentChannelLabel
            // 
            this.currentChannelLabel.AutoSize = true;
            this.currentChannelLabel.Location = new System.Drawing.Point(275, 256);
            this.currentChannelLabel.Name = "currentChannelLabel";
            this.currentChannelLabel.Size = new System.Drawing.Size(86, 13);
            this.currentChannelLabel.TabIndex = 4;
            this.currentChannelLabel.Text = "Current Channel:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 356);
            this.Controls.Add(this.currentChannelLabel);
            this.Controls.Add(this.targetChannelLabel);
            this.Controls.Add(this.currentChannelTextBox);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.messagesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hermes";
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.NumericUpDown delayField;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.Label targetChannelLabel;
        private System.Windows.Forms.TextBox currentChannelTextBox;
        private System.Windows.Forms.Label currentChannelLabel;
    }
}

