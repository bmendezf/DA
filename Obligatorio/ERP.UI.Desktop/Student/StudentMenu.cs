﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UI.Student
{
    public partial class StudentMenu : UserControl
    {
        public MainWindow mainWindow { get; set; }
        public StudentMenu(MainWindow mainW)
        {
            InitializeComponent();
            this.mainWindow = mainW;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent main = new AddStudent(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }
    }
}