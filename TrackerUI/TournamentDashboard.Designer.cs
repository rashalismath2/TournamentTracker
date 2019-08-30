namespace TrackerUI
{
    partial class TournamentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboard));
            this.headerLabel = new System.Windows.Forms.Label();
            this.loardTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentComboBox = new System.Windows.Forms.ComboBox();
            this.loadTournamentbutton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.headerLabel.Location = new System.Drawing.Point(40, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(408, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // loardTournamentLabel
            // 
            this.loardTournamentLabel.AutoSize = true;
            this.loardTournamentLabel.Location = new System.Drawing.Point(118, 94);
            this.loardTournamentLabel.Name = "loardTournamentLabel";
            this.loardTournamentLabel.Size = new System.Drawing.Size(252, 30);
            this.loardTournamentLabel.TabIndex = 15;
            this.loardTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentComboBox
            // 
            this.loadExistingTournamentComboBox.FormattingEnabled = true;
            this.loadExistingTournamentComboBox.Location = new System.Drawing.Point(116, 127);
            this.loadExistingTournamentComboBox.Name = "loadExistingTournamentComboBox";
            this.loadExistingTournamentComboBox.Size = new System.Drawing.Size(256, 38);
            this.loadExistingTournamentComboBox.TabIndex = 16;
            // 
            // loadTournamentbutton
            // 
            this.loadTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loadTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentbutton.Location = new System.Drawing.Point(142, 182);
            this.loadTournamentbutton.Name = "loadTournamentbutton";
            this.loadTournamentbutton.Size = new System.Drawing.Size(199, 42);
            this.loadTournamentbutton.TabIndex = 27;
            this.loadTournamentbutton.Text = "Load Tournament";
            this.loadTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(64, 285);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(368, 42);
            this.createTournamentButton.TabIndex = 28;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 348);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentbutton);
            this.Controls.Add(this.loadExistingTournamentComboBox);
            this.Controls.Add(this.loardTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 387);
            this.MinimumSize = new System.Drawing.Size(504, 387);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label loardTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentComboBox;
        private System.Windows.Forms.Button loadTournamentbutton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}