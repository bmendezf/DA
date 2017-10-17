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
    public partial class AddCoordinates: UserControl
    {
        public MainWindow mainWindow { get; set; }
        public AddCoordinates(MainWindow mainW)
        {
            InitializeComponent();
            this.mainWindow = mainW;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            VanMain main = new VanMain(mainWindow);
            mainWindow.ChangeMainPanel(main);
        }
    }
    }

