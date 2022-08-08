using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Sliding_Sidebar
{
   
    public partial class Form1 : Form
    {
        bool sidebarxpand;
        bool homeCollasp=false;
        public Form1()
        {
            InitializeComponent();
        
        }

       
        private void menu_Click(object sender, EventArgs e)
        {
          sidebarTimer.Start();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            homeCollasp = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

            Hometimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarxpand)
            {
                //if sidebar is expand
                sidebarpanel.Width -= 10;
                if (sidebarpanel.Width == sidebarpanel.MinimumSize.Width) {
                    sidebarxpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarpanel.Width += 10;
                if (sidebarpanel.Width == sidebarpanel.MaximumSize.Width) {
                    sidebarxpand = true;
                    sidebarTimer.Stop();
                }
               
            }

        }

        private void Hometimer_Tick(object sender, EventArgs e)
        {
            if (homeCollasp == false)
            {
                homeCollasp = true;
                HomeCantainer.Height += 168;
                
                    Hometimer.Stop();
               
            }
            else
            {
                HomeCantainer.Height -= 168;
                homeCollasp = false;
                
                    Hometimer.Stop();
                

            }
        }
    }
}
