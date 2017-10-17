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
    public partial class SubjectMain: UserControl
    {

        public MainWindow mainWindow { get; set; }
        public SubjectMain(MainWindow mainW)
        {
            
            InitializeComponent();
            InitializeSubjects();
            this.mainWindow = mainW;
        }

        private void InitializeSubjects()
        {
            subjectDataGrid.Rows.Clear();
            foreach (ERP.Entities.Subject.Subject sub in mainWindow.subjectSection.GetAllSubjects())
            {
                if (mainWindow.subjectSection.GetAllSubjects().Count != 0)
                {
                    MessageBox.Show("No hay alumnos");
                    return;
                }

                subjectDataGrid.Rows.Add(sub.Name, sub.Code);

            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddSubject main = new AddSubject(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
