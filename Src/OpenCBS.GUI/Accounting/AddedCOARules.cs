using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenCBS.GUI.Accounting
{
    public partial class AddedCOARules : Form
    {
        public AddedCOARules()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AddCOARule addCOARule = new AddCOARule();
            addCOARule.Show();
        }
    }
}
