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
    public partial class SelectWorkoutPage : Form
    {
        public SelectWorkoutPage()
        {
            InitializeComponent();
        }


        public static string routineID;
        public static string routineName;
        public static string clientRoutineID;

        private void SelectWorkoutPage_Load(object sender, EventArgs e)
        {
                      
            SqlConnection cnn = new SqlConnection(LoginForm.connection);
            string query = "SELECT R.RoutineID, R.RoutineName, CR.ClientRoutineID FROM Routines R JOIN ClientRoutines CR ON R.RoutineID = CR.RoutineID WHERE ClientID ='" + ClientListForm.clientID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SelectWorkoutList.ReadOnly = true;
            SelectWorkoutList.DataSource = ds.Tables[0];

            SelectWorkoutList.Columns[0].Visible = false;
            SelectWorkoutList.Columns[2].Visible = false;
        }

        private void SelectWorkoutList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = SelectWorkoutList.Rows[index];
            routineID = selectedRow.Cells[0].Value.ToString();
            routineName = selectedRow.Cells[1].Value.ToString();
            clientRoutineID = selectedRow.Cells[2].Value.ToString();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            new WorkoutForm().Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Homepage().Show();
            this.Close();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.Size = new Size(42, 42);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.Size = new Size(40, 40);
        }
    }
}
