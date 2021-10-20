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
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void logOnButton_MouseEnter(object sender, EventArgs e)
        {
            logOnButton.ForeColor = Color.FromArgb(232, 83, 79);
            logOnButton.BackColor = Color.White;
        }

        private void logOnButton_MouseLeave(object sender, EventArgs e)
        {
            logOnButton.ForeColor = Color.White;
            logOnButton.BackColor = Color.FromArgb(232, 83, 79);
        }

        private void logOnButton_Click(object sender, EventArgs e)
        {
            ConnectToDataBase connect = new ConnectToDataBase();
            connect.ConnectRoDataBase();
        }
    }
}
