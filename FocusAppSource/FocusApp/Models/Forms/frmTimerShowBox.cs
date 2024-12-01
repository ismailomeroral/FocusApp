using FocusApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusApp.Models.Forms
{
    public partial class frmTimerShowBox : Form
    {
        public frmTimerShowBox()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
        }
        Label lblMainTimer;
        public void LabelSet(Label _mainlabel)
        {
            lblMainTimer = _mainlabel;
        }
        public void TimerStart() { timer.Start(); }
        public void TimerStop() { timer.Stop(); }

    }
}
