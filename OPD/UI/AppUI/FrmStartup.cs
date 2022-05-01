﻿using System;
using System.IO;
using System.Windows.Forms;

namespace SHSCC.OPD.UI.AppUI
{
    public partial class FrmStartup : Form
    {
        public EventHandler AppStartClicked;
        public FrmStartup()
        {
            InitializeComponent();
        }

        private void FrmStartup_Load(object sender, EventArgs e)
        {
            lblSeltedDriveinfo.Text = $"{Properties.Settings.Default.DefaultDir} is Selected Data Drive";
            lblDateTime.Text = $"{DateTime.Now.ToShortDateString()}-And Time-{DateTime.Now.ToShortTimeString()}";
            //if (txtDataLocation.Text != "")
            //    btnBrows.Text = "Change Data Path";
            //else
            //    btnStart.Enabled = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.txtDataLocation.Text = folderBrowserDialog1.SelectedPath;
            //    btnStart.Enabled = true;

            //}
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //saving datapath in settings

            //checking if datapath exist
            if (SHSCCTextDataOperationTasks.ValidatePathStructure_CreateIfNotExist().GetAwaiter().GetResult())
            {

                AppStartClicked?.Invoke(this, null);
            }
            else
            {
                MessageBox.Show("New Data Setup Complete");
                AppStartClicked?.Invoke(this, null);
            }

        }

        private void txtDataLocation_TextChanged(object sender, EventArgs e)
        {
            //if (txtDataLocation.Text != "")
            //    btnBrows.Text = "Change Data Path";
            //else
            //{
            //    btnStart.Enabled = false;
            //    btnBrows.Text = "Select Data Path";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtDataLocation.Clear();
        }

        private void kryptonComboBox1_DropDown(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            kryptonComboBox1.Items.Clear();
            kryptonComboBox1.Items.AddRange(allDrives);
        }

        private void kryptonComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultDir = kryptonComboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            lblSeltedDriveinfo.Text = $"{Properties.Settings.Default.DefaultDir} is Selected Data Drive";
        }
    }
}
