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
            this.mainWindow = mainW;
        }
    }
}
