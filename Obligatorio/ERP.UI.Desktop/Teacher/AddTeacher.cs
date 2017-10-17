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
            this.mainWindow = mainW;
        }


    }
}
