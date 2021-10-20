using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_service_provider
{
    internal class ConnectToDataBase
    {
        public void ConnectRoDataBase()
        {
            MessageBox.Show(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString(), "Connection", MessageBoxButtons.OK);
        }
    }
}
