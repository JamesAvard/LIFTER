namespace Lifter
{
    partial class ClientListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ClientList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectButton.FlatAppearance.BorderSize = 0;
            this.SelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Bahnschrift Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ForeColor = System.Drawing.Color.White;
            this.SelectButton.Location = new System.Drawing.Point(100, 680);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(200, 50);
            this.SelectButton.TabIndex = 11;
            this.SelectButton.Text = "SELECT";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ClientList
            // 
            this.ClientList.AllowUserToAddRows = false;
            this.ClientList.AllowUserToDeleteRows = false;
            this.ClientList.AllowUserToResizeColumns = false;
            this.ClientList.AllowUserToResizeRows = false;
            this.ClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ClientList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientList.ColumnHeadersHeight = 50;
            this.ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientList.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientList.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClientList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientList.Location = new System.Drawing.Point(10, 70);
            this.ClientList.MultiSelect = false;
            this.ClientList.Name = "ClientList";
            this.ClientList.ReadOnly = true;
            this.ClientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientList.RowHeadersVisible = false;
            this.ClientList.RowHeadersWidth = 10;
            this.ClientList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientList.Size = new System.Drawing.Size(380, 600);
            this.ClientList.TabIndex = 10;
            this.ClientList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientListDataView_RowEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 14;
            // 
            // AddClientButton
            // 
            this.AddClientButton.BackColor = System.Drawing.Color.Transparent;
            this.AddClientButton.BackgroundImage = global::Lifter.Properties.Resources.Add_Client;
            this.AddClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddClientButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddClientButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.AddClientButton.FlatAppearance.BorderSize = 0;
            this.AddClientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientButton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClientButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddClientButton.Location = new System.Drawing.Point(10, 10);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddClientButton.Size = new System.Drawing.Size(40, 40);
            this.AddClientButton.TabIndex = 8;
            this.AddClientButton.UseVisualStyleBackColor = false;
            this.AddClientButton.Click += new System.EventHandler(this.button1_Click);
            this.AddClientButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.AddClientButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackgroundImage = global::Lifter.Properties.Resources.Logout;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(350, 10);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(40, 40);
            this.LogoutButton.TabIndex = 12;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.LogoutButton.MouseEnter += new System.EventHandler(this.LogoutButton_MouseEnter);
            this.LogoutButton.MouseLeave += new System.EventHandler(this.LogoutButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lifter.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(150, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 740);
            this.MinimumSize = new System.Drawing.Size(400, 740);
            this.Name = "ClientListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client List";
            this.Load += new System.EventHandler(this.ClientListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView ClientList;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}