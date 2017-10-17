using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UI.Van
{
    public partial class VanMenu: UserControl
    {
        public MainWindow mainWindow { get; set; }
        public VanMenu(MainWindow mainW)
        {
            InitializeComponent();
            this.mainWindow = mainW;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCoordinates main = new AddCoordinates(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddVan main = new AddVan(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowRoutes main = new ShowRoutes(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }
    }
}
