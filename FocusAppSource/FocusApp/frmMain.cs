using FocusApp.Models;
using FocusApp.ViewModels;
using FocusApp.ViewModels.Style_Models;
using SoftwareTrainingApplication.Models.Tools;
using SoftwareTrainingApplication.Models.UserControls;
using SoftwareTrainingApplication.ViewModels.Style;
using SoftwareTrainingApplication.ViewModels.Style_Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FocusApp
{
    partial class frmMain : CustomForm
    {
        IsoDataBase db = new IsoDataBase("Web Address", DirInfo.dbPath);
        SingleDataBase timeDb = new SingleDataBase(DirInfo.sdbPath);
        TimeController time = new TimeController();

        FormMovedEvent movedEvent = new FormMovedEvent();
        public frmMain()
        {
            InitializeComponent();
            movedEvent.SetForm(this, pnlBar);
            TimeControl();
            CheckListBoxReload();
        }
        private void CheckListBoxReload()
        {
            clistboxWebAddress.Clear();
            foreach (var item in db.ToList())
            {
                clistboxWebAddress.Add(item.address, item.activate);
            }
        }
        private void TimeControl()
        {
            isFocusWorking = timeDb.Select().working;
            type = timeDb.Select().type;
            if (isFocusWorking)
            {
                Focus(true);
                tbtnTimeLimit.Checked = type == "backward";
                time.TimeSet(timeDb.Select().time);
                tmr.Start();
            }
        }
        int count = 1;
        string type = "forward";

        bool isFocusWorking = false;
        private void Focus(bool _isFocusing)
        {
            pnlTimer.Visible = _isFocusing;
            pnlSettigs.Enabled = !_isFocusing;
            btnShowNewAddress.Enabled = !_isFocusing;
            btnStartFocus.Visible = !_isFocusing;
            btnFinishFocus.Visible = _isFocusing;
            clistboxWebAddress.Enabled = !_isFocusing;
            count = (type == "forward" ? +1 : type == "backward" ? -1 : 0);

            if (tbtnTimeLimit.Checked && _isFocusing)
            {
                time.TimeSet(0, int.Parse(cmboxTime.Text));
            }
            if (_isFocusing)
            {
                tmr.Start();
                RedirectController.StartRestrictiveProcess(clistboxWebAddress.CheckedToList());
                isFocusWorking = true;
            }
            else
            {
                tmr.Stop();
                RedirectController.FinishRestrictiveProcess();
                isFocusWorking = false;
            }
        }
        private void btnStartFocus_Click(object sender, EventArgs e)
        {
            Focus(true);
        }
        private void btnFinishFocus_Click(object sender, EventArgs e)
        {
            if (type == "forward")
                Focus(false);
            else
                MessageBox.Show("Süre bitene kadar Odaklanma devam edecektir.");

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isFocusWorking)
                MessageBox.Show("Odaklanma devam ediyorken programı kapatamazsınız.");
            else
                Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void tbtnTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            cmboxTime.Visible = !cmboxTime.Visible;
            type = (!tbtnTimeLimit.Checked ? "forward" : "backward");

        }
        private void btnShowNewAddress_Click(object sender, EventArgs e)
        {
            pnlNewAddress.Visible = !pnlNewAddress.Visible;
        }
        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (txtWebAddress.Texts != "")
                if (clistboxWebAddress.ToList().Where(b => b == txtWebAddress.Texts).Count() == 0)
                {
                    db.Add(txtWebAddress.Texts, true);
                    txtWebAddress.Texts = "";
                    pnlNewAddress.Visible = false;
                    CheckListBoxReload();
                }
        }
        private void clistboxWebAddress_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.Action)
            {
                case "Add":
                    db.Add((e.Item as CheckListItem).Texts, (e.Item as CheckListItem).Checked);
                    break;
                case "Remove":
                    db.Remove((e.Item as CheckListItem).Texts);
                    break;
                case "Update":
                    db.UpdateActivate((e.Item as CheckListItem).Texts, (e.Item as CheckListItem).Checked);
                    break;
                default:
                    break;
            }
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            var nowTime = time.TimerExport();
            time.TimeProgression(count);
            lblTimer.Text = nowTime._hour.ToString("00") + ":" + nowTime._minute.ToString("00") + ":" + nowTime._second.ToString("00");
            if (time.IsFinishTime())
                Focus(false);
            SaveTimeInfo();
        }
        private void SaveTimeInfo()
        {
            timeDb.Update(time.TimerExport(), count > 0 ? "forward" : "backward", isFocusWorking);
        }
    }
}
