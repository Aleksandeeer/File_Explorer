using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conductor
{
    public partial class AddForm : Form
    {
        public string File
        {
            get { return NameTextBox.Text; }
        }

        public AddForm()
        {
            InitializeComponent();
        }
    }
}
