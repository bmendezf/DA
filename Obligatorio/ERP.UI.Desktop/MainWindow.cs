using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Entities;
using ERP.Entities.Section;
using ERP.Logic;
using ERP.UI.Subject;
using ERP.UI.Student;
using ERP.UI.Van;
using ERP.UI.Teacher;


namespace ERP.UI
{
    public partial class MainWindow : Form
    {
        public Data.Data Database { get; set; }

        public SubjectLogic subjectSection {get; set; }

        public TeacherLogic teacherSection { get; set; }

        public StudentLogic studentSection { get; set; }

        public VanLogic vanSection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeDatabase();
          
        }

        private void InitializeDatabase()
        {
            Data.Data someData = new Data.Data();


            Section subjectS = new Section();
            subjectS.Name = "Materias";
            subjectS.Description = "Gestion de MATERIAS";
            subjectS.Actions.Add("ABM Materias");

            Section teacherS = new Section();
            teacherS.Name = "Docentes";
            teacherS.Description = "Gestion de Docentes";
            teacherS.Actions.Add("ABM Docentes");


            Section studentS = new Section();
            studentS.Name = "Alumnos";
            studentS.Description = "Gestion de Alumnos";
            studentS.Actions.Add("ABM Alumnos");


            Section vansS = new Section();
            vansS.Name = "Vans";
            vansS.Description = "Gestion de Vans";
            vansS.Actions.Add("ABM Vans");
            vansS.Actions.Add("Calcular rutas");
            vansS.Actions.Add("Agregar coordenadas");


            someData.AddSection(subjectS);
            someData.AddSection(teacherS);
            someData.AddSection(studentS);
            someData.AddSection(vansS);


            this.Database = someData;

        }

        private void subjectMB_Click_1(object sender, EventArgs e)
        {
            SubjectMain main = new SubjectMain(this);
            this.ChangeMainPanel(main);

            SubjectMenu menu = new SubjectMenu(this);
            this.ChangeMenuPanel(menu);
        }

        private void teacherMB_Click(object sender, EventArgs e)
        {
            TeacherMain main = new TeacherMain(this);
            this.ChangeMainPanel(main);

            TeacherMenu menu = new TeacherMenu(this);
            this.ChangeMenuPanel(menu);
        }

        private void studentMB_Click(object sender, EventArgs e)
        {
            StudentMain main = new StudentMain(this);
            this.ChangeMainPanel(main);

            StudentMenu menu = new StudentMenu(this);
            this.ChangeMenuPanel(menu);
        }

        private void vanMB_Click(object sender, EventArgs e)
        {
            VanMain main = new VanMain(this);
            this.ChangeMainPanel(main);

            VanMenu menu = new VanMenu(this);
            this.ChangeMenuPanel(menu);
        }

        public void ChangeMainPanel(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
        }
        public void ChangeMenuPanel(UserControl userControl)

        {
            subMenuPanel.Controls.Clear();
            subMenuPanel.Controls.Add(userControl);
        }
    }
}
