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

namespace ERP.UI.Student
{
    public partial class AddStudent: UserControl
    {
        public MainWindow mainWindow { get; set; }
        public AddStudent(MainWindow mainW)
        {
            InitializeComponent();
            InitializeSubjects();
            this.mainWindow = mainW;
        }
        private void InitializeSubjects() { }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            StudentMain main = new StudentMain(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ERP.Entities.Student.Student stud = new ERP.Entities.Student.Student();
            stud.Name = nameBox.Text;
            stud.LastName = lastNameBox.Text;
            //stud.CI = idBox.Text;
            List<ERP.Entities.Subject.Subject> listSubjects = new List<ERP.Entities.Subject.Subject>();
            foreach (ERP.Entities.Subject.Subject itemChecked in subjectBox)
            {
                listSubjects.Add(mainWindow.subjectSection.GetSubject(itemChecked));
            }

            bool successful = mainWindow.studentSection.AddStudent(stud);
            if (successful)
            {
                MessageBox.Show("Alumno creado correctamente");
                StudentMain back = new StudentMain(mainWindow);
                mainWindow.ChangeMainPanel(back);
            }

            else
            {
                MessageBox.Show("No se pudo crear el alumno. Verifique los datos.");
            }
        }
    }
}
