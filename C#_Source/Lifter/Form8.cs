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
    public partial class ClientHomepage : Form
    {
        public ClientHomepage()
        {
            InitializeComponent();
            ProgressChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            ProgressChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            ProgressChart.ChartAreas[0].AxisX.LineColor = Color.Gray;

            ProgressChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            ProgressChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            ProgressChart.ChartAreas[0].AxisY.LineColor = Color.Gray;
        }

        

        private void Form8_Load(object sender, EventArgs e)
        {
            ClientNameLabel.Text = LoginForm.ClientName;

            SqlConnection cnn = new SqlConnection(LoginForm.connection);

            string query = "SELECT DISTINCT E.ExerciseName FROM ClientRoutines CR JOIN ClientRoutineExercises CRE ON CR.ClientroutineID = CRE.ClientRoutineID JOIN Exercises E ON E.ExerciseID = CRE.ExerciseID WHERE CR.ClientID ='" + LoginForm.ClientID + "' ORDER BY E.ExerciseName ASC";

            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds, "ClientExercises");
            ExercisesList.ValueMember = "ExerciseName";
            ExercisesList.DataSource = ds.Tables["ClientExercises"];
        }

        private void LoadChart_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(LoginForm.connection);

            string query = "SELECT TOP(5) E.ExerciseName, CRE.AtWeight, CRE.Date FROM ClientRoutines CR JOIN ClientRoutineExercises CRE on CR.ClientRoutineID = CRE.ClientRoutineID JOIN Exercises E on E.ExerciseID = CRE.ExerciseID WHERE CR.ClientID = '" + LoginForm.ClientID + "'  AND E.ExerciseName = '" + ExercisesList.Text + "' ORDER BY Date ASC";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            ProgressChart.Series["Progress"].XValueMember = "Date";
            ProgressChart.Series["Progress"].YValueMembers = "AtWeight";
            ProgressChart.DataSource = ds;
            ProgressChart.DataBind();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();

        }

        private void LogoutButton_MouseEnter(object sender, EventArgs e)
        {
            LogoutButton.Size = new Size(42, 42);
        }

        private void LogoutButton_MouseLeave(object sender, EventArgs e)
        {
            LogoutButton.Size = new Size(40, 40);
        }

        private void LoadChart_MouseEnter(object sender, EventArgs e)
        {
            LoadChart.Size = new Size(34, 34);
        }

        private void LoadChart_MouseLeave(object sender, EventArgs e)
        {
            LoadChart.Size = new Size(32, 32);
        }
    }
}
