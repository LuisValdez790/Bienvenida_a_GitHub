using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaGitHub
{
    public partial class frmLoading : Form
    {//LuisValdez790
        public frmLoading()
        {
            InitializeComponent();
            timerBar.Start();
        }

        private void timerBar_Tick(object sender, EventArgs e)
        {            
            BarLoading.Increment(1);
            
            if (BarLoading.Value==20)
            {
                lblLoading.Text = ("Loading..");
            }
            if (BarLoading.Value == 40)
            {
                lblLoading.Text = ("Loading...");
            }
            if (BarLoading.Value == 60)
            {
                lblLoading.Text = ("Loading.");
            }
            if (BarLoading.Value == 80)
            {
                lblLoading.Text = ("Loading..");
            }
           
            lblPorciento.Text = BarLoading.Value + (" %");
            if (BarLoading.Value==100)
            {
                timerBar.Stop();
                lblLoading.Text = ("Loading...");
                frmHolaGitHub iniciar = new frmHolaGitHub();
                iniciar.Show();
            }            
        }
        //LuisValdez790
    }
}
