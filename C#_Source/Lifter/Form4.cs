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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }        

        private void AddClient_Load(object sender, EventArgs e)
        {
            UsernameExistsLabel.Visible = false;            
            nullBoxesLabel.Visible = false;           
            
        }             

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientNameTextBox.Text == "Name" || ClientPasswordTextBox.Text == "Username" || ClientPasswordTextBox.Text == "Password")
            {
                nullBoxesLabel.Visible = true;
            }
            else
            {
                string clientName = ClientNameTextBox.Text;               
                string clientUsername = ClientUsernameTextBox.Text;
                string clientPassword = ClientPasswordTextBox.Text;

                SqlConnection cnn = new SqlConnection(LoginForm.connection);
                string query = "select * From Clients Where ClientUsername ='" + clientUsername +  "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    UsernameExistsLabel.Visible = true;                   
                }
                else
                {
                    string insert = "insert into Clients (TrainerID,ClientName,ClientUsername,ClientPassword) Values(@TID,@ClientName,@Username,@Password)";
                    
                    cnn.Open();    
                   
                    SqlCommand command = new SqlCommand(insert, cnn);
                    command.Parameters.AddWithValue("@TID", LoginForm.trainerID);
                    command.Parameters.AddWithValue("@ClientName", clientName);                    
                    command.Parameters.AddWithValue("@Username", clientUsername);
                    command.Parameters.AddWithValue("@Password", clientPassword);                    
                    command.ExecuteNonQuery();

                    cnn.Close();


                    new ClientListForm().Show();
                    this.Hide();
                                     
                }
                                                                         
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ClientListForm().Show();
            this.Hide();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.Size = new Size(42, 42);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.Size = new Size(40, 40);
        }

        private void ClientNameTextBox_Enter(object sender, EventArgs e)
        {
            if (ClientNameTextBox.Text == "Name")
            {
                ClientNameTextBox.Text = "";
            }
        }

        private void ClientNameTextBox_Leave(object sender, EventArgs e)
        {
            if (ClientNameTextBox.Text == "")
            {
                ClientNameTextBox.Text = "Name";
            }
        }

        private void ClientUsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (ClientUsernameTextBox.Text == "Username")
            {
                ClientUsernameTextBox.Text = "";
            }
        }

        private void ClientUsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (ClientUsernameTextBox.Text == "")
            {
                ClientUsernameTextBox.Text = "Username";
            }
        }

        private void ClientPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (ClientPasswordTextBox.Text == "Password")
            {
                ClientPasswordTextBox.Text = "";
                
            }
        }

        private void ClientPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ClientPasswordTextBox.Text == "")
            {
                ClientPasswordTextBox.Text = "Password";
                
            }
        }
    }
}
