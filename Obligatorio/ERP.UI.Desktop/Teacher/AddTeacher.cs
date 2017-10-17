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
    public partial class AddTeacher: UserControl
    {
        public MainWindow mainWindow { get; set; }
        public AddTeacher(MainWindow mainW)
        {
            InitializeComponent();
            InitializeSubjects();
            this.mainWindow = mainW;
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
            ERP.Entities.Teacher.Teacher tea = new ERP.Entities.Teacher.Teacher();
            tea.FirstName = firstNameBox.Text;
            tea.LastName = lastNameBox.Text;
            tea.Id = tea.Id;

            List<ERP.Entities.Subject.Subject> listSubjects = new List<ERP.Entities.Subject.Subject>();
            foreach (ERP.Entities.Subject.Subject itemChecked in subjectsListBox)
            {
                listSubjects.Add(mainWindow.subjectSection.GetSubject(itemChecked));
            }

            
           tea.Subjects = listSubjects;

            bool successful = mainWindow.teacherSection.AddTeacher(tea);
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
