using System;
using System.Windows.Forms;

namespace C_Sharp_WinForm_Practice
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        bool timeFlag = false;

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Zoom;
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string bakuTime, londonTime;
            bakuTime = DateTime.Now.ToLongTimeString();
            londonTime = DateTime.Now.AddHours(-3).ToLongTimeString();

            if (!timeFlag) lblTime .Text= bakuTime;
            else lblTime .Text= londonTime;
            
        }

        private void btnBaku_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bakuImage2;
            timeFlag=false;
            
        }

        private void btnLondon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.londonImage;
            timeFlag = true;
        }
    }
}
