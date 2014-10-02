using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.Services;

namespace OpenCBS.GUI.Configuration
{
    public partial class SetLIBORRate : Form
    {
        public SetLIBORRate()
        {
            InitializeComponent();
        }

        private void btnSetLIBOR_Click(object sender, EventArgs e)
        {
            ApplicationSettingsServices applicationSettingsServices = ServicesProvider.GetInstance().GetApplicationSettingsServices();
            int ret = applicationSettingsServices.SetLIBORRate(DateTime.Today, Convert.ToDouble(txtLIBORRate.Text), cmbInterestPeriod.SelectedItem.ToString());

            if (ret == 1)
                MessageBox.Show("LIBOR rate successfully added.");
            else
                MessageBox.Show("LIBOR rate already added for the day.");
        }
    }
}
