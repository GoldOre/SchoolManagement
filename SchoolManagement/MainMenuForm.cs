﻿using SchoolManagement.BAL.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.BAL;

namespace SchoolManagement
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            StudentsBo stdBo = new StudentsBo();
            stdBo.Create();
        }

    }
}
