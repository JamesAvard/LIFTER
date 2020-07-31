namespace Lifter
{
    partial class CreateRoutine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExerciseList = new System.Windows.Forms.ComboBox();
            this.WorkoutName = new System.Windows.Forms.TextBox();
            this.NewRoutineView = new System.Windows.Forms.DataGridView();
            this.FinishedButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveExerciseButton = new System.Windows.Forms.Button();
            this.AddExerciseButton = new System.Windows.Forms.Button();
            this.NoName = new System.Windows.Forms.Label();
            this.AlreadyUsed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewRoutineView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExerciseList
            // 
            this.ExerciseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExerciseList.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseList.FormattingEnabled = true;
            this.ExerciseList.Location = new System.Drawing.Point(10, 130);
            this.ExerciseList.Name = "ExerciseList";
            this.ExerciseList.Size = new System.Drawing.Size(160, 31);
            this.ExerciseList.TabIndex = 4;
            // 
            // WorkoutName
            // 
            this.WorkoutName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.WorkoutName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkoutName.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkoutName.ForeColor = System.Drawing.Color.White;
            this.WorkoutName.Location = new System.Drawing.Point(10, 70);
            this.WorkoutName.Name = "WorkoutName";
            this.WorkoutName.Size = new System.Drawing.Size(185, 33);
            this.WorkoutName.TabIndex = 5;
            this.WorkoutName.Text = "Workout Name";
            this.WorkoutName.Enter += new System.EventHandler(this.WorkoutName_Enter);
            this.WorkoutName.Leave += new System.EventHandler(this.WorkoutName_Leave);
            // 
            // NewRoutineView
            // 
            this.NewRoutineView.AllowUserToAddRows = false;
            this.NewRoutineView.AllowUserToDeleteRows = false;
            this.NewRoutineView.AllowUserToResizeColumns = false;
            this.NewRoutineView.AllowUserToResizeRows = false;
            this.NewRoutineView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NewRoutineView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NewRoutineView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.NewRoutineView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewRoutineView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.NewRoutineView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NewRoutineView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NewRoutineView.DefaultCellStyle = dataGridViewCellStyle2;
            this.NewRoutineView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.NewRoutineView.Location = new System.Drawing.Point(10, 171);
            this.NewRoutineView.MultiSelect = false;
            this.NewRoutineView.Name = "NewRoutineView";
            this.NewRoutineView.ReadOnly = true;
            this.NewRoutineView.RowHeadersVisible = false;
            this.NewRoutineView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.NewRoutineView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NewRoutineView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NewRoutineView.Size = new System.Drawing.Size(380, 499);
            this.NewRoutineView.TabIndex = 6;
            // 
            // FinishedButton
            // 
            this.FinishedButton.BackColor = System.Drawing.Color.DarkRed;
            this.FinishedButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FinishedButton.FlatAppearance.BorderSize = 0;
            this.FinishedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinishedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinishedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishedButton.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishedButton.ForeColor = System.Drawing.Color.White;
            this.FinishedButton.Location = new System.Drawing.Point(100, 680);
            this.FinishedButton.Name = "FinishedButton";
            this.FinishedButton.Size = new System.Drawing.Size(200, 50);
            this.FinishedButton.TabIndex = 9;
            this.FinishedButton.Text = "ADD WORKOUT";
            this.FinishedButton.UseVisualStyleBackColor = false;
            this.FinishedButton.Click += new System.EventHandler(this.FinishedButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(10, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 3);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lifter.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(150, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::Lifter.Properties.Resources.Back;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(10, 10);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 40);
            this.BackButton.TabIndex = 10;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // RemoveExerciseButton
            // 
            this.RemoveExerciseButton.BackgroundImage = global::Lifter.Properties.Resources.Minus1;
            this.RemoveExerciseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveExerciseButton.FlatAppearance.BorderSize = 0;
            this.RemoveExerciseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoveExerciseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RemoveExerciseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveExerciseButton.Location = new System.Drawing.Point(250, 130);
            this.RemoveExerciseButton.Name = "RemoveExerciseButton";
            this.RemoveExerciseButton.Size = new System.Drawing.Size(32, 32);
            this.RemoveExerciseButton.TabIndex = 8;
            this.RemoveExerciseButton.UseVisualStyleBackColor = true;
            this.RemoveExerciseButton.Click += new System.EventHandler(this.RemoveExerciseButton_Click);
            this.RemoveExerciseButton.MouseEnter += new System.EventHandler(this.RemoveExerciseButton_MouseEnter);
            this.RemoveExerciseButton.MouseLeave += new System.EventHandler(this.RemoveExerciseButton_MouseLeave);
            // 
            // AddExerciseButton
            // 
            this.AddExerciseButton.BackgroundImage = global::Lifter.Properties.Resources.Add;
            this.AddExerciseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddExerciseButton.FlatAppearance.BorderSize = 0;
            this.AddExerciseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddExerciseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddExerciseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExerciseButton.Location = new System.Drawing.Point(200, 130);
            this.AddExerciseButton.Name = "AddExerciseButton";
            this.AddExerciseButton.Size = new System.Drawing.Size(32, 32);
            this.AddExerciseButton.TabIndex = 7;
            this.AddExerciseButton.UseVisualStyleBackColor = true;
            this.AddExerciseButton.Click += new System.EventHandler(this.AddExerciseButton_Click);
            this.AddExerciseButton.MouseEnter += new System.EventHandler(this.AddExerciseButton_MouseEnter);
            this.AddExerciseButton.MouseLeave += new System.EventHandler(this.AddExerciseButton_MouseLeave);
            // 
            // NoName
            // 
            this.NoName.AutoSize = true;
            this.NoName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoName.ForeColor = System.Drawing.Color.Red;
            this.NoName.Location = new System.Drawing.Point(232, 70);
            this.NoName.Name = "NoName";
            this.NoName.Size = new System.Drawing.Size(150, 19);
            this.NoName.TabIndex = 14;
            this.NoName.Text = "Please Enter Name";
            this.NoName.Visible = false;
            // 
            // AlreadyUsed
            // 
            this.AlreadyUsed.AutoSize = true;
            this.AlreadyUsed.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyUsed.ForeColor = System.Drawing.Color.Red;
            this.AlreadyUsed.Location = new System.Drawing.Point(221, 89);
            this.AlreadyUsed.Name = "AlreadyUsed";
            this.AlreadyUsed.Size = new System.Drawing.Size(161, 19);
            this.AlreadyUsed.TabIndex = 15;
            this.AlreadyUsed.Text = "Name Already In Use";
            this.AlreadyUsed.Visible = false;
            // 
            // CreateRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.AlreadyUsed);
            this.Controls.Add(this.NoName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FinishedButton);
            this.Controls.Add(this.RemoveExerciseButton);
            this.Controls.Add(this.AddExerciseButton);
            this.Controls.Add(this.NewRoutineView);
            this.Controls.Add(this.WorkoutName);
            this.Controls.Add(this.ExerciseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 740);
            this.MinimumSize = new System.Drawing.Size(400, 740);
            this.Name = "CreateRoutine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.CreateRoutine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewRoutineView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ExerciseList;
        private System.Windows.Forms.TextBox WorkoutName;
        private System.Windows.Forms.DataGridView NewRoutineView;
        private System.Windows.Forms.Button AddExerciseButton;
        private System.Windows.Forms.Button RemoveExerciseButton;
        private System.Windows.Forms.Button FinishedButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NoName;
        private System.Windows.Forms.Label AlreadyUsed;
    }
}