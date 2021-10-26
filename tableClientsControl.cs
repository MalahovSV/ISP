using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_service_provider
{
    public partial class tableClientsControl : UserControl
    {
        private string select;
        private DataSet ds;
        private SqlDataAdapter adapter;
        public tableClientsControl()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            ds = new DataSet();
            select = "select ID_Subscriber as 'ID', Surname as 'Фамилия', First_Name as 'Имя', Paronymic as 'Отчество', Number_Phone as 'Номер телефона' from subscriber";
            using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                connection.Open();
                adapter = new SqlDataAdapter(select, connection);
                adapter.Fill(ds);
            }
            tableSubscribers.DataSource = ds.Tables[0];
            tableSubscribers.Columns["ID"].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void updateDataSet()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                connection.Open();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter = new SqlDataAdapter(select, connection);
                adapter.InsertCommand = new SqlCommand("sp_CreateSubscriber", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Surname", SqlDbType.VarChar, 20, "Фамилия"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.VarChar, 20, "Имя"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Paronymic", SqlDbType.VarChar, 20, "Отчество"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Number_Phone", SqlDbType.VarChar, 13, "Номер телефона"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@ID_Subscriber", SqlDbType.Int, 0, "ID");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);

            }
        }

        private void updateTableButton_Click(object sender, EventArgs e)
        {
            updateDataSet();
        }
    }
}
