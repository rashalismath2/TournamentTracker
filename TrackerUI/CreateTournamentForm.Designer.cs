namespace TrackerUI
{
    partial class CreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournament));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameText = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeText = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamCombo = new System.Windows.Forms.ComboBox();
            this.selectTeamlabel = new System.Windows.Forms.Label();
            this.createNewButton = new System.Windows.Forms.Label();
            this.teamsplayersListBox = new System.Windows.Forms.ListBox();
            this.teamsplayerLabel = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.deleteTeamPlayersButton = new System.Windows.Forms.Button();
            this.deletePrizesbutton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(334, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameText
            // 
            this.tournamentNameText.Location = new System.Drawing.Point(38, 118);
            this.tournamentNameText.Name = "tournamentNameText";
            this.tournamentNameText.Size = new System.Drawing.Size(308, 35);
            this.tournamentNameText.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Location = new System.Drawing.Point(33, 85);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(186, 30);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeText
            // 
            this.entryFeeText.Location = new System.Drawing.Point(165, 171);
            this.entryFeeText.Name = "entryFeeText";
            this.entryFeeText.Size = new System.Drawing.Size(181, 35);
            this.entryFeeText.TabIndex = 12;
            this.entryFeeText.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Location = new System.Drawing.Point(33, 174);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(98, 30);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamCombo
            // 
            this.selectTeamCombo.FormattingEnabled = true;
            this.selectTeamCombo.Location = new System.Drawing.Point(38, 253);
            this.selectTeamCombo.Name = "selectTeamCombo";
            this.selectTeamCombo.Size = new System.Drawing.Size(308, 38);
            this.selectTeamCombo.TabIndex = 14;
            // 
            // selectTeamlabel
            // 
            this.selectTeamlabel.AutoSize = true;
            this.selectTeamlabel.Location = new System.Drawing.Point(33, 220);
            this.selectTeamlabel.Name = "selectTeamlabel";
            this.selectTeamlabel.Size = new System.Drawing.Size(123, 30);
            this.selectTeamlabel.TabIndex = 13;
            this.selectTeamlabel.Text = "Select Team";
            // 
            // createNewButton
            // 
            this.createNewButton.AutoSize = true;
            this.createNewButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewButton.ForeColor = System.Drawing.Color.Blue;
            this.createNewButton.Location = new System.Drawing.Point(232, 220);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(114, 30);
            this.createNewButton.TabIndex = 15;
            this.createNewButton.Text = "create new";
            // 
            // teamsplayersListBox
            // 
            this.teamsplayersListBox.FormattingEnabled = true;
            this.teamsplayersListBox.ItemHeight = 30;
            this.teamsplayersListBox.Location = new System.Drawing.Point(464, 118);
            this.teamsplayersListBox.Name = "teamsplayersListBox";
            this.teamsplayersListBox.Size = new System.Drawing.Size(284, 124);
            this.teamsplayersListBox.TabIndex = 18;
            // 
            // teamsplayerLabel
            // 
            this.teamsplayerLabel.AutoSize = true;
            this.teamsplayerLabel.Location = new System.Drawing.Point(459, 85);
            this.teamsplayerLabel.Name = "teamsplayerLabel";
            this.teamsplayerLabel.Size = new System.Drawing.Size(156, 30);
            this.teamsplayerLabel.TabIndex = 19;
            this.teamsplayerLabel.Text = "Teams / Players";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(107, 322);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(132, 42);
            this.addTeamButton.TabIndex = 21;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click_1);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(107, 386);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(132, 42);
            this.createPrizeButton.TabIndex = 22;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // deleteTeamPlayersButton
            // 
            this.deleteTeamPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteTeamPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteTeamPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteTeamPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamPlayersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeamPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteTeamPlayersButton.Location = new System.Drawing.Point(754, 118);
            this.deleteTeamPlayersButton.Name = "deleteTeamPlayersButton";
            this.deleteTeamPlayersButton.Size = new System.Drawing.Size(132, 35);
            this.deleteTeamPlayersButton.TabIndex = 23;
            this.deleteTeamPlayersButton.Text = "Delete Selected";
            this.deleteTeamPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deletePrizesbutton
            // 
            this.deletePrizesbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizesbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePrizesbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deletePrizesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizesbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrizesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deletePrizesbutton.Location = new System.Drawing.Point(754, 300);
            this.deletePrizesbutton.Name = "deletePrizesbutton";
            this.deletePrizesbutton.Size = new System.Drawing.Size(132, 35);
            this.deletePrizesbutton.TabIndex = 26;
            this.deletePrizesbutton.Text = "Delete Selected";
            this.deletePrizesbutton.UseVisualStyleBackColor = true;
            this.deletePrizesbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Location = new System.Drawing.Point(459, 267);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(67, 30);
            this.prizesLabel.TabIndex = 25;
            this.prizesLabel.Text = "Prizes";
            this.prizesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(464, 300);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(284, 124);
            this.prizesListBox.TabIndex = 24;
            this.prizesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(304, 496);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(195, 42);
            this.createTournamentButton.TabIndex = 27;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 550);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deletePrizesbutton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteTeamPlayersButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.teamsplayerLabel);
            this.Controls.Add(this.teamsplayersListBox);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.selectTeamCombo);
            this.Controls.Add(this.selectTeamlabel);
            this.Controls.Add(this.entryFeeText);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameText);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(914, 589);
            this.MinimumSize = new System.Drawing.Size(914, 589);
            this.Name = "CreateTournament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameText;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeText;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamCombo;
        private System.Windows.Forms.Label selectTeamlabel;
        private System.Windows.Forms.Label createNewButton;
        private System.Windows.Forms.ListBox teamsplayersListBox;
        private System.Windows.Forms.Label teamsplayerLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Button deleteTeamPlayersButton;
        private System.Windows.Forms.Button deletePrizesbutton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}