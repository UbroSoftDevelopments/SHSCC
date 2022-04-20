﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHSCC
{
    public partial class FrmSHSC : Form
    {

        OPD.UI.AppUI.FrmHome homepage;
        OPD.UI.Patient.FrmAddNew adnew;
        public FrmSHSC()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowHomePage();
        }
       void ShowHomePage()
        {
            homepage = new OPD.UI.AppUI.FrmHome();
            homepage.MdiParent = this;
            homepage.Dock = DockStyle.Fill;
            homepage.Show();
        }
        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homepage.Dispose();
            OPD.UI.Patient.FrmAddNew frmAdd = new OPD.UI.Patient.FrmAddNew(0);
            frmAdd.MdiParent = this;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();

        }

        private void patientToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}