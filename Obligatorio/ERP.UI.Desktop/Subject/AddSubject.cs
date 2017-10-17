using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UI.Subject
{
    public partial class AddSubject : UserControl
    {

        public MainWindow mainWindow { get; set; }
        public AddSubject(MainWindow mainW)
        {
            InitializeComponent();
            InitializeTeachers();
            InitializeStudents();
            this.mainWindow = mainW;
        }

        private void InitializeTeachers()
        {
            if (mainWindow.Database.GetAllTeachers().Count != 0)
            {
                MessageBox.Show("No hay docentes");
                return;
            }

            teachersBox.Items.Clear();
            foreach (ERP.Entities.Teacher.Teacher item in mainWindow.Database.GetAllTeachers())
            {
                teachersBox.Items.Add(item);
            }

            teachersBox.SelectedIndex = teachersBox.Items.Count - 1;
        }

        private void InitializeStudents()
        {
            if (mainWindow.Database.GetAllStudents().Count != 0)
            {
                MessageBox.Show("No hay alumnos");
                return;
            }

            studentBox.Items.Clear();
            foreach (ERP.Entities.Student.Student item in mainWindow.Database.GetAllStudents())
            {
                studentBox.Items.Add(item);
            }

            studentBox.SelectedIndex = studentBox.Items.Count - 1;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            ERP.Entities.Subject.Subject sub = new ERP.Entities.Subject.Subject();
            sub.Code = codeBox.Text;
            sub.Name = nameBox.Text;

            List<ERP.Entities.Teacher.Teacher> listTeachers = new List<ERP.Entities.Teacher.Teacher>();
            foreach (ERP.Entities.Teacher.Teacher itemChecked in teachersBox)
            {
                listTeachers.Add(mainWindow.teacherSection.GetTeacher(itemChecked));
            }

            List<ERP.Entities.Student.Student> listStudents = new List<ERP.Entities.Student.Student>();
            foreach (ERP.Entities.Student.Student itemChecked in studentBox)
            {
                listStudents.Add(mainWindow.studentSection.GetStudent(itemChecked));
            }

            sub.Students = listStudents;
            sub.Teachers = listTeachers;

            bool successful = mainWindow.subjectSection.AddSubject(sub);
            if (successful)
            {
                MessageBox.Show("Materia creada correctamente");
                SubjectMain back = new SubjectMain(mainWindow);
                mainWindow.ChangeMainPanel(back);
            }

            else
            {
                MessageBox.Show("No se pudo crear la materia. Verifique los datos.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SubjectMain main = new SubjectMain(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }
    }
}
