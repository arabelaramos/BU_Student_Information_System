﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSheet
{
    public partial class StudentSheetPage2 : Form
    {
        public StudentSheetPage2()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSheetPage1 studentSheetPage1 = new StudentSheetPage1();
            studentSheetPage1.Show();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSheetPage3 studentSheetPage3 = new StudentSheetPage3();
            studentSheetPage3.Show();
        }
    }
}
