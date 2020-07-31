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
    public partial class CreateRoutine : Form
    {
        public CreateRoutine()
        {
            InitializeComponent();
        }

        private void CreateRoutine_Load(object sender, EventArgs e)
        {
            
            SqlConnection cnn = new SqlConnection(LoginForm.connection);

            string query = "SELECT  ExerciseName FROM Exercises ORDER BY ExerciseName ASC";

            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds,"Exercises");
            ExerciseList.ValueMember = "ExerciseName";
            ExerciseList.DataSource = ds.Tables["Exercises"];

            NewRoutineView.ColumnCount = 5;
            NewRoutineView.Columns[0].Name = "ExerciseID";
            NewRoutineView.Columns[1].Name = "ExerciseName";
            NewRoutineView.Columns[2].Name = "Sets";
            NewRoutineView.Columns[3].Name = "Reps";
            NewRoutineView.Columns[4].Name = "Weight";

            NewRoutineView.Columns[0].Visible = false;
            NewRoutineView.Columns[2].Visible = false;
            NewRoutineView.Columns[3].Visible = false;
            NewRoutineView.Columns[4].Visible = false;
            

        }

        private void AddExerciseButton_Click(object sender, EventArgs e)
        {
            string Exercise = ExerciseList.SelectedValue.ToString();

            SqlConnection cnn = new SqlConnection(LoginForm.connection);

            string selectEID = "SELECT ExerciseID,DefaultSets,DefaultReps,DefaultWeight FROM Exercises WHERE ExerciseName ='" + Exercise + "'";
            SqlDataAdapter sda = new SqlDataAdapter(selectEID, cnn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds, "ExerciseID");
            string ExerciseID = Convert.ToString(ds.Tables[0].Rows[0]["ExerciseID"]);
            int Sets = Convert.ToInt32(ds.Tables[0].Rows[0]["DefaultSets"]);
            int Reps = Convert.ToInt32(ds.Tables[0].Rows[0]["DefaultReps"]);
            int Weight = Convert.ToInt32(ds.Tables[0].Rows[0]["DefaultWeight"]);

            NewRoutineView.Rows.Add(ExerciseID, Exercise,Sets,Reps,Weight);

              
            
        }

        private void RemoveExerciseButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow exercise in NewRoutineView.SelectedRows)
            {
                NewRoutineView.Rows.RemoveAt(exercise.Index);
            }

        }

        private void FinishedButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(LoginForm.connection);
            cnn.Open();

            if (WorkoutName.Text == "Workout Name" || NewRoutineView == null || NewRoutineView.Rows.Count == 0)
            {
                NoName.Visible = true;

            }
            else 
            {
                
                string selectRName = "SELECT RoutineName FROM Routines WHERE RoutineName='"+ WorkoutName.Text.Trim()+"'";
                SqlDataAdapter sdaSelectRName = new SqlDataAdapter(selectRName, cnn);
                SqlCommandBuilder commandSelectRName = new SqlCommandBuilder(sdaSelectRName);
                DataTable dtbl = new DataTable();
                sdaSelectRName.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    AlreadyUsed.Visible = true;
                }
                else 
                {
                    string insertR = "INSERT INTO Routines (RoutineName) VALUES(@RName)";
                    

                    SqlCommand commandInsertR = new SqlCommand(insertR, cnn);
                    commandInsertR.Parameters.AddWithValue("@RName", WorkoutName.Text.Trim());
                    commandInsertR.ExecuteNonQuery();

                    string selectRID = "SELECT RoutineID FROM Routines WHERE RoutineName='" + WorkoutName.Text.Trim()+"'";

                    SqlDataAdapter sdaSelectRID = new SqlDataAdapter(selectRID, cnn);
                    SqlCommandBuilder cmndBuilder = new SqlCommandBuilder(sdaSelectRID);
                    var dsSelectRID = new DataSet();                

                    sdaSelectRID.Fill(dsSelectRID);          


                    string insertCR = "INSERT INTO ClientRoutines (ClientID,RoutineID) VALUES(@CID,@RID)";

                    SqlCommand command2 = new SqlCommand(insertCR, cnn);
                    command2.Parameters.AddWithValue("@CID", ClientListForm.clientID);
                    command2.Parameters.AddWithValue("@RID", (dsSelectRID.Tables[0].Rows[0][0]));
                    command2.ExecuteNonQuery();


                    for (int i = 0; i < NewRoutineView.Rows.Count; i++)
                    {
                        
                        int EID = Convert.ToInt32(NewRoutineView.Rows[i].Cells["ExerciseID"].Value);
                        int Sets = Convert.ToInt32(NewRoutineView.Rows[i].Cells["Sets"].Value);
                        int Reps = Convert.ToInt32(NewRoutineView.Rows[i].Cells["Reps"].Value);
                        decimal Weight = Convert.ToDecimal(NewRoutineView.Rows[i].Cells["Weight"].Value);
                        

                        string insertRE = "INSERT INTO RoutineExercises (RoutineID,ExerciseID,DefaultSets,DefaultReps,DefaultWeight) VALUES(@RID,@ExerciseID,@Sets,@Reps,@Weight)";


                        SqlCommand commandRE = new SqlCommand(insertRE, cnn);
                        commandRE.Parameters.AddWithValue("@RID", (dsSelectRID.Tables[0].Rows[0][0]));
                        commandRE.Parameters.AddWithValue("@ExerciseID", EID);
                        commandRE.Parameters.AddWithValue("@Sets", Sets);
                        commandRE.Parameters.AddWithValue("@Reps", Reps);
                        commandRE.Parameters.AddWithValue("@Weight", Weight);
                        
                        commandRE.ExecuteNonQuery();                       

                    }
                    cnn.Close();
                    new Homepage().Show();
                    this.Close();


                }             

            }          

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new Homepage().Show();
            this.Close();
        }

        private void WorkoutName_Enter(object sender, EventArgs e)
        {
            if (WorkoutName.Text == "Workout Name")
            {
                WorkoutName.Text = "";
            }
        }

        private void WorkoutName_Leave(object sender, EventArgs e)
        {
            if (WorkoutName.Text == "")
            {
                WorkoutName.Text = "Workout Name";
            }
        }

        private void AddExerciseButton_MouseEnter(object sender, EventArgs e)
        {
            AddExerciseButton.Size = new Size(34, 34);
        }

        private void AddExerciseButton_MouseLeave(object sender, EventArgs e)
        {
            AddExerciseButton.Size = new Size(32, 32);
        }

        private void RemoveExerciseButton_MouseEnter(object sender, EventArgs e)
        {
            AddExerciseButton.Size = new Size(34, 34);
        }

        private void RemoveExerciseButton_MouseLeave(object sender, EventArgs e)
        {
            AddExerciseButton.Size = new Size(32, 32);
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
