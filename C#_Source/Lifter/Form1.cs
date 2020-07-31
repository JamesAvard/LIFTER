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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\Documents\UNI\Final Year Project\N0675709_Source\Lifter\Database1.mdf;Integrated Security=True";
        public static int trainerID;
        public static int ClientID;
        public static string ClientName;

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if(usernameTextBox.Text=="Username")
            {
                usernameTextBox.Text = "";                
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";                
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";                
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";                
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            invalidLabel.Visible = false;            
        }        

        private void loginButton_Click(object sender, EventArgs e)
        {
           

            if (TrainerRadioButton.Checked)
            {
                SqlConnection cnn = new SqlConnection(connection);
                string queryTrainers = "select * From Trainers Where TrainerUsername ='" + usernameTextBox.Text.Trim() + "'and TrainerPassword ='" + passwordTextBox.Text.Trim() + "'";
                SqlDataAdapter sdaTrainers = new SqlDataAdapter(queryTrainers, cnn);
                DataTable dtblTrainers = new DataTable();
                sdaTrainers.Fill(dtblTrainers);
                if (dtblTrainers.Rows.Count == 1)
                {
                    string query2 = "Select TrainerID from Trainers Where TrainerUsername = '" + usernameTextBox.Text.Trim() + "' and TrainerPassword ='" + passwordTextBox.Text.Trim() + "'";
                    SqlCommand command = new SqlCommand(query2, cnn);
                    cnn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        trainerID = Convert.ToInt32(reader["TrainerID"]);
                        new ClientListForm().Show();
                        this.Hide();
                        cnn.Close();
                    }
                }
                else
                {
                    invalidLabel.Visible = true;
                }
            }

            else if (ClientRadioButton.Checked)
            {
                SqlConnection cnn = new SqlConnection(connection);
                string queryClients = "SELECT * From Clients Where ClientUsername ='" + usernameTextBox.Text.Trim() + "'and ClientPassword ='" + passwordTextBox.Text.Trim() + "'";
                SqlDataAdapter sdaClients  = new SqlDataAdapter(queryClients, cnn);
                DataTable dtblClients = new DataTable();
                sdaClients.Fill(dtblClients);
                if (dtblClients.Rows.Count == 1)
                {
                    string queryClientID = "Select ClientID,ClientName from Clients Where ClientUsername = '" + usernameTextBox.Text.Trim() + "' and ClientPassword ='" + passwordTextBox.Text.Trim() + "'";
                    SqlCommand command = new SqlCommand(queryClientID, cnn);
                    cnn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        ClientID = Convert.ToInt32(reader["ClientID"]);
                        ClientName = Convert.ToString(reader["ClientName"]);
                        new ClientHomepage().Show();
                        this.Hide();
                        cnn.Close();
                    }
                }
                else
                {
                    invalidLabel.Visible = true;
                }
            }
        }
    }
}
