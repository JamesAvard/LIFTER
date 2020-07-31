namespace Lifter
{
    partial class AddClient
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
            this.addClientButton = new System.Windows.Forms.Button();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientUsernameTextBox = new System.Windows.Forms.TextBox();
            this.ClientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameExistsLabel = new System.Windows.Forms.Label();
            this.nullBoxesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addClientButton.FlatAppearance.BorderSize = 0;
            this.addClientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientButton.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.ForeColor = System.Drawing.Color.White;
            this.addClientButton.Location = new System.Drawing.Point(100, 680);
            this.addClientButton.Margin = new System.Windows.Forms.Padding(0);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(200, 50);
            this.addClientButton.TabIndex = 12;
            this.addClientButton.Text = "ADD CLIENT";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientNameTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameTextBox.ForeColor = System.Drawing.Color.White;
            this.ClientNameTextBox.Location = new System.Drawing.Point(75, 17);
            this.ClientNameTextBox.MaxLength = 25;
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(220, 33);
            this.ClientNameTextBox.TabIndex = 18;
            this.ClientNameTextBox.Text = "Name";
            this.ClientNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientNameTextBox.Enter += new System.EventHandler(this.ClientNameTextBox_Enter);
            this.ClientNameTextBox.Leave += new System.EventHandler(this.ClientNameTextBox_Leave);
            // 
            // ClientUsernameTextBox
            // 
            this.ClientUsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientUsernameTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientUsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.ClientUsernameTextBox.Location = new System.Drawing.Point(75, 87);
            this.ClientUsernameTextBox.MaxLength = 20;
            this.ClientUsernameTextBox.Name = "ClientUsernameTextBox";
            this.ClientUsernameTextBox.Size = new System.Drawing.Size(220, 33);
            this.ClientUsernameTextBox.TabIndex = 19;
            this.ClientUsernameTextBox.Text = "Username";
            this.ClientUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientUsernameTextBox.Enter += new System.EventHandler(this.ClientUsernameTextBox_Enter);
            this.ClientUsernameTextBox.Leave += new System.EventHandler(this.ClientUsernameTextBox_Leave);
            // 
            // ClientPasswordTextBox
            // 
            this.ClientPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientPasswordTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.ClientPasswordTextBox.Location = new System.Drawing.Point(75, 157);
            this.ClientPasswordTextBox.MaxLength = 10;
            this.ClientPasswordTextBox.Name = "ClientPasswordTextBox";
            this.ClientPasswordTextBox.Size = new System.Drawing.Size(220, 33);
            this.ClientPasswordTextBox.TabIndex = 20;
            this.ClientPasswordTextBox.Text = "Password";
            this.ClientPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientPasswordTextBox.Enter += new System.EventHandler(this.ClientPasswordTextBox_Enter);
            this.ClientPasswordTextBox.Leave += new System.EventHandler(this.ClientPasswordTextBox_Leave);
            // 
            // UsernameExistsLabel
            // 
            this.UsernameExistsLabel.AutoSize = true;
            this.UsernameExistsLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameExistsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameExistsLabel.Location = new System.Drawing.Point(115, 370);
            this.UsernameExistsLabel.Name = "UsernameExistsLabel";
            this.UsernameExistsLabel.Size = new System.Drawing.Size(169, 25);
            this.UsernameExistsLabel.TabIndex = 29;
            this.UsernameExistsLabel.Text = "Username Taken";
            // 
            // nullBoxesLabel
            // 
            this.nullBoxesLabel.AutoSize = true;
            this.nullBoxesLabel.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullBoxesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nullBoxesLabel.Location = new System.Drawing.Point(131, 400);
            this.nullBoxesLabel.Name = "nullBoxesLabel";
            this.nullBoxesLabel.Size = new System.Drawing.Size(137, 25);
            this.nullBoxesLabel.TabIndex = 30;
            this.nullBoxesLabel.Text = "Fill All Boxes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 3);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 3);
            this.panel3.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 3);
            this.panel4.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.ClientUsernameTextBox);
            this.panel5.Controls.Add(this.ClientPasswordTextBox);
            this.panel5.Controls.Add(this.ClientNameTextBox);
            this.panel5.Location = new System.Drawing.Point(50, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 201);
            this.panel5.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lifter.Properties.Resources.ClientName;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Lifter.Properties.Resources.Padlock;
            this.pictureBox4.Location = new System.Drawing.Point(0, 140);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lifter.Properties.Resources.Avatar;
            this.pictureBox3.Location = new System.Drawing.Point(0, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lifter.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(150, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::Lifter.Properties.Resources.Back;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(10, 10);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 40);
            this.BackButton.TabIndex = 31;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.nullBoxesLabel);
            this.Controls.Add(this.UsernameExistsLabel);
            this.Controls.Add(this.addClientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.TextBox ClientUsernameTextBox;
        private System.Windows.Forms.TextBox ClientPasswordTextBox;
        private System.Windows.Forms.Label UsernameExistsLabel;
        private System.Windows.Forms.Label nullBoxesLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}