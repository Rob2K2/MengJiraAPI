namespace JiraAPI
{
    partial class Form1
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnVerifySession = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnGetProjects = new System.Windows.Forms.Button();
            this.btnGetIssue = new System.Windows.Forms.Button();
            this.txtIssueKey = new System.Windows.Forms.TextBox();
            this.getWorklog = new System.Windows.Forms.Button();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.txtAddWorklog = new System.Windows.Forms.Button();
            this.txtWorklogID = new System.Windows.Forms.TextBox();
            this.cboProjects = new System.Windows.Forms.ComboBox();
            this.btnSelectProject = new System.Windows.Forms.Button();
            this.lvIssues = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeSpent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timeOriginalEstimate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbHora = new System.Windows.Forms.RadioButton();
            this.rbMediaHora = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(177, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "merino@live.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(177, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "robertitoma";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(177, 87);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(331, 12);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(457, 230);
            this.txtResponse.TabIndex = 3;
            // 
            // btnVerifySession
            // 
            this.btnVerifySession.Location = new System.Drawing.Point(331, 248);
            this.btnVerifySession.Name = "btnVerifySession";
            this.btnVerifySession.Size = new System.Drawing.Size(78, 23);
            this.btnVerifySession.TabIndex = 4;
            this.btnVerifySession.Text = "VerifySession";
            this.btnVerifySession.UseVisualStyleBackColor = true;
            this.btnVerifySession.Click += new System.EventHandler(this.btnVerifySession_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(710, 248);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(78, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 355);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 6;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(15, 387);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtValue.Size = new System.Drawing.Size(773, 230);
            this.txtValue.TabIndex = 7;
            // 
            // btnGetProjects
            // 
            this.btnGetProjects.Location = new System.Drawing.Point(710, 358);
            this.btnGetProjects.Name = "btnGetProjects";
            this.btnGetProjects.Size = new System.Drawing.Size(78, 23);
            this.btnGetProjects.TabIndex = 8;
            this.btnGetProjects.Text = "Get Projects";
            this.btnGetProjects.UseVisualStyleBackColor = true;
            this.btnGetProjects.Click += new System.EventHandler(this.btnGetProjects_Click);
            // 
            // btnGetIssue
            // 
            this.btnGetIssue.Location = new System.Drawing.Point(363, 358);
            this.btnGetIssue.Name = "btnGetIssue";
            this.btnGetIssue.Size = new System.Drawing.Size(75, 23);
            this.btnGetIssue.TabIndex = 12;
            this.btnGetIssue.Text = "Get Issue";
            this.btnGetIssue.UseVisualStyleBackColor = true;
            this.btnGetIssue.Click += new System.EventHandler(this.btnGetIssue_Click);
            // 
            // txtIssueKey
            // 
            this.txtIssueKey.Location = new System.Drawing.Point(257, 360);
            this.txtIssueKey.Name = "txtIssueKey";
            this.txtIssueKey.Size = new System.Drawing.Size(100, 20);
            this.txtIssueKey.TabIndex = 11;
            // 
            // getWorklog
            // 
            this.getWorklog.Location = new System.Drawing.Point(607, 358);
            this.getWorklog.Name = "getWorklog";
            this.getWorklog.Size = new System.Drawing.Size(75, 23);
            this.getWorklog.TabIndex = 14;
            this.getWorklog.Text = "Get Worklog";
            this.getWorklog.UseVisualStyleBackColor = true;
            this.getWorklog.Click += new System.EventHandler(this.getWorklog_Click);
            // 
            // txtIssueID
            // 
            this.txtIssueID.Location = new System.Drawing.Point(501, 360);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(100, 20);
            this.txtIssueID.TabIndex = 13;
            // 
            // txtAddWorklog
            // 
            this.txtAddWorklog.Location = new System.Drawing.Point(1184, 248);
            this.txtAddWorklog.Name = "txtAddWorklog";
            this.txtAddWorklog.Size = new System.Drawing.Size(75, 23);
            this.txtAddWorklog.TabIndex = 16;
            this.txtAddWorklog.Text = "Add Worklog";
            this.txtAddWorklog.UseVisualStyleBackColor = true;
            this.txtAddWorklog.Click += new System.EventHandler(this.txtAddWorklog_Click);
            // 
            // txtWorklogID
            // 
            this.txtWorklogID.Location = new System.Drawing.Point(501, 334);
            this.txtWorklogID.Name = "txtWorklogID";
            this.txtWorklogID.Size = new System.Drawing.Size(100, 20);
            this.txtWorklogID.TabIndex = 17;
            // 
            // cboProjects
            // 
            this.cboProjects.FormattingEnabled = true;
            this.cboProjects.Location = new System.Drawing.Point(710, 331);
            this.cboProjects.Name = "cboProjects";
            this.cboProjects.Size = new System.Drawing.Size(121, 21);
            this.cboProjects.TabIndex = 18;
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.Location = new System.Drawing.Point(837, 329);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(82, 23);
            this.btnSelectProject.TabIndex = 19;
            this.btnSelectProject.Text = "Select Project";
            this.btnSelectProject.UseVisualStyleBackColor = true;
            this.btnSelectProject.Click += new System.EventHandler(this.btnSelectProject_Click);
            // 
            // lvIssues
            // 
            this.lvIssues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.timeSpent,
            this.timeOriginalEstimate});
            this.lvIssues.Location = new System.Drawing.Point(837, 13);
            this.lvIssues.Name = "lvIssues";
            this.lvIssues.Size = new System.Drawing.Size(422, 229);
            this.lvIssues.TabIndex = 20;
            this.lvIssues.UseCompatibleStateImageBehavior = false;
            this.lvIssues.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // timeSpent
            // 
            this.timeSpent.Text = "Time Spent";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(1078, 250);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 21;
            // 
            // timeOriginalEstimate
            // 
            this.timeOriginalEstimate.Text = "Time Original Estimate";
            // 
            // rbHora
            // 
            this.rbHora.AutoSize = true;
            this.rbHora.Location = new System.Drawing.Point(1078, 277);
            this.rbHora.Name = "rbHora";
            this.rbHora.Size = new System.Drawing.Size(57, 17);
            this.rbHora.TabIndex = 22;
            this.rbHora.TabStop = true;
            this.rbHora.Text = "1 Hora";
            this.rbHora.UseVisualStyleBackColor = true;
            this.rbHora.CheckedChanged += new System.EventHandler(this.rbHora_CheckedChanged);
            // 
            // rbMediaHora
            // 
            this.rbMediaHora.AutoSize = true;
            this.rbMediaHora.Location = new System.Drawing.Point(1078, 301);
            this.rbMediaHora.Name = "rbMediaHora";
            this.rbMediaHora.Size = new System.Drawing.Size(68, 17);
            this.rbMediaHora.TabIndex = 23;
            this.rbMediaHora.TabStop = true;
            this.rbMediaHora.Text = "1/2 Hora";
            this.rbMediaHora.UseVisualStyleBackColor = true;
            this.rbMediaHora.CheckedChanged += new System.EventHandler(this.rbMediaHora_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 629);
            this.Controls.Add(this.rbMediaHora);
            this.Controls.Add(this.rbHora);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lvIssues);
            this.Controls.Add(this.btnSelectProject);
            this.Controls.Add(this.cboProjects);
            this.Controls.Add(this.txtWorklogID);
            this.Controls.Add(this.txtAddWorklog);
            this.Controls.Add(this.getWorklog);
            this.Controls.Add(this.txtIssueID);
            this.Controls.Add(this.btnGetIssue);
            this.Controls.Add(this.txtIssueKey);
            this.Controls.Add(this.btnGetProjects);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnVerifySession);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnVerifySession;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnGetProjects;
        private System.Windows.Forms.Button btnGetIssue;
        private System.Windows.Forms.TextBox txtIssueKey;
        private System.Windows.Forms.Button getWorklog;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.Button txtAddWorklog;
        private System.Windows.Forms.TextBox txtWorklogID;
        private System.Windows.Forms.ComboBox cboProjects;
        private System.Windows.Forms.Button btnSelectProject;
        private System.Windows.Forms.ListView lvIssues;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader timeSpent;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ColumnHeader timeOriginalEstimate;
        private System.Windows.Forms.RadioButton rbHora;
        private System.Windows.Forms.RadioButton rbMediaHora;
    }
}

