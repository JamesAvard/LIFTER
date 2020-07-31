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
    public partial class WorkoutForm : Form
    {
        public WorkoutForm()
        {
            InitializeComponent();
        }

        private void WorkoutForm_Load(object sender, EventArgs e)
        {
            
            RoutineNameLabel.Text = SelectWorkoutPage.routineName;
                        
            SqlConnection cnn = new SqlConnection(LoginForm.connection);
            string query = "SELECT E.ExerciseID, E.ExerciseName, RE.DefaultSets, RE.DefaultReps, RE.DefaultWeight FROM Exercises E JOIN RoutineExercises RE ON E.ExerciseID = RE.ExerciseID WHERE RoutineID =" + SelectWorkoutPage.routineID;
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);            
            WorkoutGridView.DataSource = ds.Tables[0];

            WorkoutGridView.Columns["ExerciseName"].ReadOnly = true;
            WorkoutGridView.Columns["ExerciseID"].ReadOnly = true;
            WorkoutGridView.Columns["ExerciseID"].Visible = false;
            WorkoutGridView.Columns["ExerciseName"].Width = 170;
            WorkoutGridView.Columns["DefaultSets"].Width = 70;
            WorkoutGridView.Columns["DefaultReps"].Width = 70;
            WorkoutGridView.Columns["DefaultWeight"].Width = 70;
            WorkoutGridView.Columns["DefaultSets"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            WorkoutGridView.Columns["DefaultReps"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            WorkoutGridView.Columns["DefaultWeight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

        }

        private void FinishWorkoutButton_Click(object sender, EventArgs e)
        {


            SqlConnection cnn = new SqlConnection(LoginForm.connection);
            cnn.Open();            

            for (int i = 0; i < WorkoutGridView.Rows.Count; i++)
            {
                int CRID = Convert.ToInt32(SelectWorkoutPage.clientRoutineID);
                int EID = Convert.ToInt32(WorkoutGridView.Rows[i].Cells["ExerciseID"].Value);
                int Sets = Convert.ToInt32(WorkoutGridView.Rows[i].Cells["DefaultSets"].Value ?? DBNull.Value);
                int Reps = Convert.ToInt32(WorkoutGridView.Rows[i].Cells["DefaultReps"].Value ?? DBNull.Value);
                decimal Weight = Convert.ToDecimal(WorkoutGridView.Rows[i].Cells["DefaultWeight"].Value ?? DBNull.Value);
                DateTime date = Convert.ToDateTime(DateTime.Now.ToString());

                string insert = "INSERT INTO ClientRoutineExercises (ClientRoutineID,ExerciseID,SetsCompleted,RepsCompleted,AtWeight,Date) VALUES(@ClientRoutineID,@ExerciseID,@Sets,@Reps,@Weight,@Date)";

               
                SqlCommand command = new SqlCommand(insert, cnn);
                command.Parameters.AddWithValue("@ClientRoutineID", CRID);
                command.Parameters.AddWithValue("@ExerciseID", EID);
                command.Parameters.AddWithValue("@Sets", Sets);
                command.Parameters.AddWithValue("@Reps", Reps);
                command.Parameters.AddWithValue("@Weight", Weight);
                command.Parameters.AddWithValue("@Date", date);
                command.ExecuteNonQuery();

                string update = "UPDATE RoutineExercises SET DefaultSets =" + Sets + ", DefaultReps=" + Reps + ",DefaultWeight=" + Weight + " WHERE RoutineID=" + SelectWorkoutPage.routineID + "AND ExerciseID=" + EID;

                SqlCommand cmnd = new SqlCommand(update, cnn);
                cmnd.ExecuteNonQuery();
                
            }
            cnn.Close();
            new Homepage().Show();
            this.Close();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new SelectWorkoutPage().Show();
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
