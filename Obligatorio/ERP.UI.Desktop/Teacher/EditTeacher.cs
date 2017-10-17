using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.UI.Teacher;

namespace ERP.UI.Teacher
{
    public partial class EditTeacher : UserControl
    {
        public MainWindow mainWindow { get; set; }

        public ERP.Entities.Teacher.Teacher aTeacher { get; set; }
        public EditTeacher(MainWindow mainW, ERP.Entities.Teacher.Teacher aTea)
        {
            InitializeComponent();
            InitializeSubjects();
            this.mainWindow = mainW;
            this.aTeacher = aTea;
        }
        private void InitializeSubjects()
        {
            if (mainWindow.Database.GetAllSubjects().Count != 0)
            {
                MessageBox.Show("No hay alumnos");
                return;
            }

            subjectsListBox.Items.Clear();
            foreach (ERP.Entities.Subject.Subject item in mainWindow.Database.GetAllSubjects())
            {
                subjectsListBox.Items.Add(item);
                if (this.aTeacher.Subjects.Contains(item))
                {
                    subjectsListBox.SelectedItems.Add(item);
                }
            }

            subjectsListBox.SelectedIndex = subjectsListBox.Items.Count - 1;

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            TeacherMain main = new TeacherMain(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            this.aTeacher.FirstName = firstNameBox.Text;
            this.aTeacher.LastName = lastNameBox.Text;

            List<ERP.Entities.Subject.Subject> listSubjects = new List<ERP.Entities.Subject.Subject>();
            foreach (ERP.Entities.Subject.Subject itemChecked in subjectsListBox)
            {
                listSubjects.Add(mainWindow.subjectSection.GetSubject(itemChecked));
            }


            this.aTeacher.Subjects = listSubjects;

            bool successful = mainWindow.teacherSection.UpdateTeacher(this.aTeacher);
            if (successful)
            {
                MessageBox.Show("Materia creada correctamente");
                TeacherMain back = new TeacherMain(mainWindow);
                mainWindow.ChangeMainPanel(back);
            }

            else
            {
                MessageBox.Show("No se pudo crear la materia. Verifique los datos.");
            }
        }
    }
}
