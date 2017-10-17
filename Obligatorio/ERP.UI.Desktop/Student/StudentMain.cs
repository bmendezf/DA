using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Entities.Student;
using ERP.Logic;

namespace ERP.UI.Student
{
    public partial class StudentMain : UserControl
    {
        public MainWindow mainWindow { get; set; }

        public StudentLogic studentLogic { get; set; }
        public StudentMain(MainWindow mainW)
        {
            InitializeComponent();
            InitializeStudents();
            this.mainWindow = mainW;
            this.studentLogic = new StudentLogic(mainW.Database);

        }

        private void InitializeStudents()
        {
            studentDataGrid.Rows.Clear();
            foreach (ERP.Entities.Student.Student stud in mainWindow.Database.GetAllStudents())
            {
                if (mainWindow.Database.GetAllStudents().Count != 0)
                {
                    MessageBox.Show("No hay alumnos");
                    return;
                }

                studentDataGrid.Rows.Add(stud.Name, stud.LastName, stud.StudentNumber, stud.CI);
                
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddStudent main = new AddStudent(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void studentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
