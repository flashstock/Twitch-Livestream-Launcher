namespace TwitchLivestreamerLauncher
{
    partial class TwitchLauncherWindow
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
            this.startStreamButton = new System.Windows.Forms.Button();
            this.channelNameTextBox = new System.Windows.Forms.TextBox();
            this.channelNameLabel = new System.Windows.Forms.Label();
            this.streamQualityTextBox = new System.Windows.Forms.TextBox();
            this.streamQualityLabel = new System.Windows.Forms.Label();
            this.launchChatButton = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startStreamButton
            // 
            this.startStreamButton.Location = new System.Drawing.Point(11, 187);
            this.startStreamButton.Name = "startStreamButton";
            this.startStreamButton.Size = new System.Drawing.Size(75, 23);
            this.startStreamButton.TabIndex = 4;
            this.startStreamButton.Text = "Start stream";
            this.startStreamButton.UseVisualStyleBackColor = true;
            this.startStreamButton.Click += new System.EventHandler(this.launchStreamButton_Click);
            // 
            // channelNameTextBox
            // 
            this.channelNameTextBox.Location = new System.Drawing.Point(11, 25);
            this.channelNameTextBox.Name = "channelNameTextBox";
            this.channelNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.channelNameTextBox.TabIndex = 1;
            // 
            // channelNameLabel
            // 
            this.channelNameLabel.AutoSize = true;
            this.channelNameLabel.Location = new System.Drawing.Point(8, 9);
            this.channelNameLabel.Name = "channelNameLabel";
            this.channelNameLabel.Size = new System.Drawing.Size(228, 13);
            this.channelNameLabel.TabIndex = 3;
            this.channelNameLabel.Text = "Enter the name of the channel eg. dansgaming";
            // 
            // streamQualityTextBox
            // 
            this.streamQualityTextBox.Location = new System.Drawing.Point(11, 64);
            this.streamQualityTextBox.Name = "streamQualityTextBox";
            this.streamQualityTextBox.Size = new System.Drawing.Size(270, 20);
            this.streamQualityTextBox.TabIndex = 2;
            // 
            // streamQualityLabel
            // 
            this.streamQualityLabel.AutoSize = true;
            this.streamQualityLabel.Location = new System.Drawing.Point(8, 48);
            this.streamQualityLabel.Name = "streamQualityLabel";
            this.streamQualityLabel.Size = new System.Drawing.Size(161, 13);
            this.streamQualityLabel.TabIndex = 5;
            this.streamQualityLabel.Text = "Enter the quality (default Source)";
            // 
            // launchChatButton
            // 
            this.launchChatButton.Location = new System.Drawing.Point(92, 187);
            this.launchChatButton.Name = "launchChatButton";
            this.launchChatButton.Size = new System.Drawing.Size(108, 23);
            this.launchChatButton.TabIndex = 6;
            this.launchChatButton.Text = "Launch chat";
            this.launchChatButton.UseVisualStyleBackColor = true;
            this.launchChatButton.Click += new System.EventHandler(this.launchChatButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(206, 187);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 7;
            this.launchButton.Text = "Launch both";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // TwitchLauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 222);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.launchChatButton);
            this.Controls.Add(this.streamQualityLabel);
            this.Controls.Add(this.streamQualityTextBox);
            this.Controls.Add(this.channelNameLabel);
            this.Controls.Add(this.channelNameTextBox);
            this.Controls.Add(this.startStreamButton);
            this.Name = "TwitchLauncherWindow";
            this.Text = "Livestreamer Launcher";
            this.Load += new System.EventHandler(this.TwitchLauncherWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStreamButton;
        private System.Windows.Forms.TextBox channelNameTextBox;
        private System.Windows.Forms.Label channelNameLabel;
        private System.Windows.Forms.TextBox streamQualityTextBox;
        private System.Windows.Forms.Label streamQualityLabel;
        private System.Windows.Forms.Button launchChatButton;
        private System.Windows.Forms.Button launchButton;
    }
}

