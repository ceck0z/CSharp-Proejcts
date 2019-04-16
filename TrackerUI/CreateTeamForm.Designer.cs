namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabelValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMember = new System.Windows.Forms.Button();
            this.createdTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(12, 117);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(314, 35);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(7, 84);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(126, 30);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(220, 50);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(12, 202);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(314, 38);
            this.selectTeamMemberDropDown.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(7, 169);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(209, 30);
            this.selectTeamMemberLabel.TabIndex = 15;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMemberButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.addMemberButton.Location = new System.Drawing.Point(89, 257);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(143, 37);
            this.addMemberButton.TabIndex = 17;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.AddNewMemberGroupBox.Controls.Add(this.cellPhoneValue);
            this.AddNewMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.emailValue);
            this.AddNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.lastNameLabelValue);
            this.AddNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.AddNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewMemberGroupBox.ForeColor = System.Drawing.Color.SkyBlue;
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(12, 317);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(314, 246);
            this.AddNewMemberGroupBox.TabIndex = 18;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createMemberButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.createMemberButton.Location = new System.Drawing.Point(77, 183);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(143, 37);
            this.createMemberButton.TabIndex = 19;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Location = new System.Drawing.Point(114, 144);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(190, 33);
            this.cellPhoneValue.TabIndex = 26;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cellPhoneLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.cellPhoneLabel.Location = new System.Drawing.Point(6, 146);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(103, 25);
            this.cellPhoneLabel.TabIndex = 25;
            this.cellPhoneLabel.Text = "Cell Phone";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(114, 105);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(190, 33);
            this.emailValue.TabIndex = 24;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.emailLabel.Location = new System.Drawing.Point(6, 108);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 25);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabelValue
            // 
            this.lastNameLabelValue.Location = new System.Drawing.Point(114, 65);
            this.lastNameLabelValue.Name = "lastNameLabelValue";
            this.lastNameLabelValue.Size = new System.Drawing.Size(190, 33);
            this.lastNameLabelValue.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 68);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 25);
            this.lastNameLabel.TabIndex = 21;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(114, 26);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(190, 33);
            this.firstNameValue.TabIndex = 20;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 29);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(102, 25);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(390, 112);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(247, 452);
            this.teamMembersListBox.TabIndex = 19;
            // 
            // deleteSelectedMember
            // 
            this.deleteSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.deleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSelectedMember.ForeColor = System.Drawing.Color.SkyBlue;
            this.deleteSelectedMember.Location = new System.Drawing.Point(663, 288);
            this.deleteSelectedMember.Name = "deleteSelectedMember";
            this.deleteSelectedMember.Size = new System.Drawing.Size(110, 64);
            this.deleteSelectedMember.TabIndex = 21;
            this.deleteSelectedMember.Text = "Delete Selected";
            this.deleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // createdTeamButton
            // 
            this.createdTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createdTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createdTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.createdTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createdTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createdTeamButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.createdTeamButton.Location = new System.Drawing.Point(258, 593);
            this.createdTeamButton.Name = "createdTeamButton";
            this.createdTeamButton.Size = new System.Drawing.Size(191, 40);
            this.createdTeamButton.TabIndex = 25;
            this.createdTeamButton.Text = "Create Team";
            this.createdTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 645);
            this.Controls.Add(this.createdTeamButton);
            this.Controls.Add(this.deleteSelectedMember);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team ";
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox AddNewMemberGroupBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameLabelValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMember;
        private System.Windows.Forms.Button createdTeamButton;
    }
}