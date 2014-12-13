using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchLivestreamerLauncher
{
    public partial class TwitchLauncherWindow : Form
    {
        private string streamQuality = "source";
        
        public TwitchLauncherWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            string s = System.Environment.GetEnvironmentVariable("PATH");
            if (!s.Contains("Livestreamer"))
                MessageBox.Show("It seems you don't have livestreamer in your PATH variable, the program may not run correctly.");
        }

        private void launchStreamButton_Click(object sender, EventArgs e)
        {
            //http://www.twitch.tv/chat/embed?channel=jeraxai&popout_chat=true
            if (streamQualityTextBox.Text.Length != 0)
                streamQuality = streamQualityTextBox.Text;
            else
                streamQuality = "source";
            System.Diagnostics.Debug.WriteLine("[DEBUG] Launching Livestreamer with adress twitch.tv/" + channelNameTextBox.Text);
            System.Diagnostics.Debug.WriteLine("cmd.exe", "/Q /C livestreamer twitch.tv/" + channelNameTextBox.Text + " " + streamQuality);
            System.Diagnostics.Process.Start("cmd.exe", "/Q /C livestreamer twitch.tv/" + channelNameTextBox.Text + " " + streamQuality);
        }

        private void launchChatButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("[DEBUG] Launching chat");
            System.Diagnostics.Process.Start("http://www.twitch.tv/chat/embed?channel=" + channelNameTextBox.Text + "&popout_chat=true");        
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            launchStreamButton_Click(this, null);
            launchChatButton_Click(this, null);
        }

        private void TwitchLauncherWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
