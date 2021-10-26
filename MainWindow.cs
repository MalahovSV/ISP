using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_service_provider
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showTableContracts(object sender, EventArgs e)
        {
            var userControl = new tableContractsControls();
            controlSetting(userControl);
        }

        private void controlSetting(UserControl userControl)
        {
            
            if (mainContainer.Panel2.Controls.Count > 0)
                mainContainer.Panel2.Controls.RemoveAt(0);
            mainContainer.Panel2.Controls.Add(userControl);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showTableClients(object sender, EventArgs e)
        {
            var userControl = new tableClientsControl();
            controlSetting(userControl);
        }
    }
}
