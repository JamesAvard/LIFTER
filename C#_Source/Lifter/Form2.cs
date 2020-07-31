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

namespace Lifter
{
    public partial class ClientListForm : Form
    {
        public ClientListForm()
        {
            InitializeComponent();
        }

        public static string clientID;
        public static string clientName;    
      

        private void ClientListForm_Load(object sender, EventArgs e)
        {
           
            SqlConnection cnn = new SqlConnection(LoginForm.connection);
            string query = "select ClientID, ClientName From Clients Where TrainerID ='" + LoginForm.trainerID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ClientList.ReadOnly = true;
            ClientList.DataSource = ds.Tables[0];
            
            ClientList.Columns[0].Visible = false;
        }

        private void ClientListDataView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = ClientList.Rows[index];
            clientID = selectedRow.Cells[0].Value.ToString();
            clientName = selectedRow.Cells[1].Value.ToString();
            
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            new Homepage().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddClient().Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            AddClientButton.Size = new Size(42, 42);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            AddClientButton.Size = new Size(40, 40);
        }

        private void LogoutButton_MouseEnter(object sender, EventArgs e)
        {
            LogoutButton.Size = new Size(42, 42);
        }

        private void LogoutButton_MouseLeave(object sender, EventArgs e)
        {
            LogoutButton.Size = new Size(40, 40);
        }

    }
}
