using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace FastEddiesCarShopGUI
{
    public partial class WelcomeToFastEddies : Form
    {
        //This is the instace of timer for window close.
        Timer countDown = new Timer();

        public WelcomeToFastEddies()
        {
            InitializeComponent();
           
        }

        private void WelcomeToFastEddies_Load(object sender, EventArgs e)
        {
            // The sould player plays the sound for the opening sequence
            
           

            //this timer is for the progress bar
            timer1.Start(); 
            
            //Secondary timer for the window to be closed.
            countDown.Interval = 4000;
            countDown.Tick += new EventHandler(countDown_Tick);
            countDown.Start(); 

        }

        //This is the timer for the progress bar tick event.
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(4);
        }

        //This is the timer tick event for the window to close.
        void countDown_Tick(object sender, EventArgs e)
        {

            countDown.Stop();
            this.Close();
        }
    }
}
