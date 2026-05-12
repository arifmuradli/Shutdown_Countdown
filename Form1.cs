using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Media;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        // int secondsRemaining = 900;

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            // Parse minutes and seconds from label
            int minutes = int.Parse(countdownLabel.Text.Substring(0, 2));
            int seconds = int.Parse(countdownLabel.Text.Substring(3, 2));
            // Decrement one second
            if (seconds > 0)
            {
                seconds--;
            }
            else
            {
                if (minutes > 0)
                {
                    minutes--;
                    seconds = 59;
                }
                else
                {
                    InitiateShutdown(); // Call shutdown function
                                        // Timer expired
                    WarningTimer.Stop(); // <-- Corrected timer name
                    MessageBox.Show("Timer expired!");
                    return;
                }
            }

            // Update label text
            countdownLabel.Text = $"{minutes:D2}:{seconds:D2}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WarningTimer.Start();
            ResourceManager rm = new ResourceManager(typeof(Form1)); // Replace "MyForm" with your form class name
            SoundPlayer player = new SoundPlayer(rm.GetStream("livech")); // Replace "mySound" with your resource name

            // Play the sound
            player.Play();

        }


        private void reject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitiateShutdown()
        {
            // Directly initiate system shutdown (no warning)
            Process.Start("shutdown", "/s /t 0");
            Environment.Exit(0); // Exit the application
        }

        private void WarningTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Stop the warning timer
            ((System.Timers.Timer)sender).Stop();

            // Perform system shutdown (after warning period)
            Process.Start("shutdown", "/s /t 5");
            Environment.Exit(0); // Exit the application
        }
    }
}

        
    

