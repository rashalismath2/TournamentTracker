namespace TrackerUI
{
    partial class CreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeam));
            this.headerLabel = new System.Windows.Forms.Label();
            this.teamnameText = new System.Windows.Forms.TextBox();
            this.teamNamelabel = new System.Windows.Forms.Label();
            this.selectTeamMemberCombo = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberlabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.contactText = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.teamMemberTextBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(223, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Team";
            // 
            // teamnameText
            // 
            this.teamnameText.Location = new System.Drawing.Point(21, 114);
            this.teamnameText.Name = "teamnameText";
            this.teamnameText.Size = new System.Drawing.Size(308, 35);
            this.teamnameText.TabIndex = 12;
            // 
            // teamNamelabel
            // 
            this.teamNamelabel.AutoSize = true;
            this.teamNamelabel.Location = new System.Drawing.Point(16, 81);
            this.teamNamelabel.Name = "teamNamelabel";
            this.teamNamelabel.Size = new System.Drawing.Size(124, 30);
            this.teamNamelabel.TabIndex = 11;
            this.teamNamelabel.Text = "Team Name";
            // 
            // selectTeamMemberCombo
            // 
            this.selectTeamMemberCombo.FormattingEnabled = true;
            this.selectTeamMemberCombo.Location = new System.Drawing.Point(22, 201);
            this.selectTeamMemberCombo.Name = "selectTeamMemberCombo";
            this.selectTeamMemberCombo.Size = new System.Drawing.Size(308, 38);
            this.selectTeamMemberCombo.TabIndex = 17;
            // 
            // selectTeamMemberlabel
            // 
            this.selectTeamMemberlabel.AutoSize = true;
            this.selectTeamMemberlabel.Location = new System.Drawing.Point(17, 168);
            this.selectTeamMemberlabel.Name = "selectTeamMemberlabel";
            this.selectTeamMemberlabel.Size = new System.Drawing.Size(207, 30);
            this.selectTeamMemberlabel.TabIndex = 16;
            this.selectTeamMemberlabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(103, 257);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(132, 42);
            this.addMemberButton.TabIndex = 22;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.contactText);
            this.addNewMemberGroupBox.Controls.Add(this.contactLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailText);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameText);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameText);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(21, 314);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(343, 277);
            this.addNewMemberGroupBox.TabIndex = 23;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            this.addNewMemberGroupBox.Enter += new System.EventHandler(this.addNewMemberGroupBox_Enter);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(175, 45);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(162, 35);
            this.firstNameText.TabIndex = 12;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(18, 48);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(175, 86);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(162, 35);
            this.lastNameText.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(18, 89);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 30);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name";
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(175, 168);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(162, 35);
            this.contactText.TabIndex = 18;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(18, 171);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(85, 30);
            this.contactLabel.TabIndex = 17;
            this.contactLabel.Text = "Contact";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(175, 127);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(162, 35);
            this.emailText.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(18, 130);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberButton.Location = new System.Drawing.Point(82, 219);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(132, 42);
            this.createMemberButton.TabIndex = 22;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(322, 623);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(132, 42);
            this.createTeamButton.TabIndex = 23;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // teamMemberTextBox
            // 
            this.teamMemberTextBox.FormattingEnabled = true;
            this.teamMemberTextBox.ItemHeight = 30;
            this.teamMemberTextBox.Location = new System.Drawing.Point(444, 110);
            this.teamMemberTextBox.Name = "teamMemberTextBox";
            this.teamMemberTextBox.Size = new System.Drawing.Size(288, 484);
            this.teamMemberTextBox.TabIndex = 24;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(752, 110);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(132, 42);
            this.deleteSelectedMemberButton.TabIndex = 25;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 677);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMemberTextBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberCombo);
            this.Controls.Add(this.selectTeamMemberlabel);
            this.Controls.Add(this.teamnameText);
            this.Controls.Add(this.teamNamelabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(927, 716);
            this.MinimumSize = new System.Drawing.Size(927, 716);
            this.Name = "CreateTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeam_Load);
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox teamnameText;
        private System.Windows.Forms.Label teamNamelabel;
        private System.Windows.Forms.ComboBox selectTeamMemberCombo;
        private System.Windows.Forms.Label selectTeamMemberlabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.ListBox teamMemberTextBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
    }
}