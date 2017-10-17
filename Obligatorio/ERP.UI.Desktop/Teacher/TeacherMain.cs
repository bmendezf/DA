using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UI.Teacher
{
    public partial class TeacherMain: UserControl
    {
        public MainWindow mainWindow { get; set; }
        public TeacherMain(MainWindow mainW)
        {
            InitializeComponent();
            this.mainWindow = mainW;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddTeacher main = new AddTeacher(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }
    }
}
