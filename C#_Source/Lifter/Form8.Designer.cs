namespace Lifter
{
    partial class ClientHomepage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ExercisesList = new System.Windows.Forms.ComboBox();
            this.LoadChart = new System.Windows.Forms.Button();
            this.ProgressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.ForeColor = System.Drawing.Color.White;
            this.ClientNameLabel.Location = new System.Drawing.Point(10, 70);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(155, 33);
            this.ClientNameLabel.TabIndex = 4;
            this.ClientNameLabel.Text = "ClientName";
            // 
            // ExercisesList
            // 
            this.ExercisesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExercisesList.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExercisesList.FormattingEnabled = true;
            this.ExercisesList.Location = new System.Drawing.Point(16, 120);
            this.ExercisesList.Name = "ExercisesList";
            this.ExercisesList.Size = new System.Drawing.Size(160, 31);
            this.ExercisesList.TabIndex = 5;
            // 
            // LoadChart
            // 
            this.LoadChart.BackgroundImage = global::Lifter.Properties.Resources.Graph;
            this.LoadChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoadChart.FlatAppearance.BorderSize = 0;
            this.LoadChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoadChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoadChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadChart.Location = new System.Drawing.Point(203, 119);
            this.LoadChart.Name = "LoadChart";
            this.LoadChart.Size = new System.Drawing.Size(32, 32);
            this.LoadChart.TabIndex = 7;
            this.LoadChart.UseVisualStyleBackColor = true;
            this.LoadChart.Click += new System.EventHandler(this.LoadChart_Click);
            this.LoadChart.MouseEnter += new System.EventHandler(this.LoadChart_MouseEnter);
            this.LoadChart.MouseLeave += new System.EventHandler(this.LoadChart_MouseLeave);
            // 
            // ProgressChart
            // 
            this.ProgressChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 80F;
            chartArea1.InnerPlotPosition.X = 10F;
            chartArea1.Name = "ChartArea1";
            this.ProgressChart.ChartAreas.Add(chartArea1);
            this.ProgressChart.Location = new System.Drawing.Point(10, 180);
            this.ProgressChart.Name = "ProgressChart";
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Name = "Progress";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.ProgressChart.Series.Add(series1);
            this.ProgressChart.Size = new System.Drawing.Size(380, 550);
            this.ProgressChart.TabIndex = 8;
            this.ProgressChart.Text = "Progress";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackgroundImage = global::Lifter.Properties.Resources.Logout7;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(350, 10);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(40, 40);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.LogoutButton.MouseEnter += new System.EventHandler(this.LogoutButton_MouseEnter);
            this.LogoutButton.MouseLeave += new System.EventHandler(this.LogoutButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lifter.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(150, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ClientHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ProgressChart);
            this.Controls.Add(this.LoadChart);
            this.Controls.Add(this.ExercisesList);
            this.Controls.Add(this.ClientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 740);
            this.MinimumSize = new System.Drawing.Size(400, 740);
            this.Name = "ClientHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.ComboBox ExercisesList;
        private System.Windows.Forms.Button LoadChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProgressChart;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}