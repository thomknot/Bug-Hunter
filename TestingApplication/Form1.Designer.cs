namespace TestingApplication
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loginIDLabel;
            System.Windows.Forms.Label loginPasswordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginbutton = new System.Windows.Forms.Button();
            this.userlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.Usertext = new System.Windows.Forms.TextBox();
            this.Passtext = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this._BugHunter1_1DataSet = new TestingApplication._BugHunter1_1DataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new TestingApplication._BugHunter1_1DataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new TestingApplication._BugHunter1_1DataSetTableAdapters.TableAdapterManager();
            this.loginIDTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.designationIDTextBox = new System.Windows.Forms.TextBox();
            this.passchecktext = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            loginIDLabel = new System.Windows.Forms.Label();
            loginPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BugHunter1_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginIDLabel
            // 
            loginIDLabel.AutoSize = true;
            loginIDLabel.Enabled = false;
            loginIDLabel.Location = new System.Drawing.Point(192, 623);
            loginIDLabel.Name = "loginIDLabel";
            loginIDLabel.Size = new System.Drawing.Size(64, 17);
            loginIDLabel.TabIndex = 24;
            loginIDLabel.Text = "Login ID:";
            loginIDLabel.Visible = false;
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Enabled = false;
            loginPasswordLabel.Location = new System.Drawing.Point(154, 330);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new System.Drawing.Size(112, 17);
            loginPasswordLabel.TabIndex = 25;
            loginPasswordLabel.Text = "Login Password:";
            loginPasswordLabel.Visible = false;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(216, 529);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(132, 32);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = " LOGIN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.BackColor = System.Drawing.SystemColors.Control;
            this.userlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userlabel.Location = new System.Drawing.Point(78, 460);
            this.userlabel.MaximumSize = new System.Drawing.Size(132, 22);
            this.userlabel.MinimumSize = new System.Drawing.Size(132, 22);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(132, 22);
            this.userlabel.TabIndex = 1;
            this.userlabel.Text = " USER NAME";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.BackColor = System.Drawing.SystemColors.Control;
            this.passlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passlabel.Location = new System.Drawing.Point(77, 488);
            this.passlabel.MaximumSize = new System.Drawing.Size(132, 22);
            this.passlabel.MinimumSize = new System.Drawing.Size(132, 22);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(132, 22);
            this.passlabel.TabIndex = 2;
            this.passlabel.Text = " PASSWORD";
            this.passlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Usertext
            // 
            this.Usertext.Location = new System.Drawing.Point(216, 460);
            this.Usertext.Name = "Usertext";
            this.Usertext.Size = new System.Drawing.Size(131, 22);
            this.Usertext.TabIndex = 3;
            // 
            // Passtext
            // 
            this.Passtext.Location = new System.Drawing.Point(215, 488);
            this.Passtext.Name = "Passtext";
            this.Passtext.PasswordChar = '*';
            this.Passtext.Size = new System.Drawing.Size(132, 22);
            this.Passtext.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 362);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(213, 588);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 17);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 588);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 22);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bug Hunter";
            // 
            // _BugHunter1_1DataSet
            // 
            this._BugHunter1_1DataSet.DataSetName = "_BugHunter1_1DataSet";
            this._BugHunter1_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this._BugHunter1_1DataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.Sub_ProjectTableAdapter = null;
            this.tableAdapterManager.Test_CaseTableAdapter = null;
            this.tableAdapterManager.Test_SuiteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestingApplication._BugHunter1_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loginIDTextBox
            // 
            this.loginIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LoginID", true));
            this.loginIDTextBox.Location = new System.Drawing.Point(262, 623);
            this.loginIDTextBox.Name = "loginIDTextBox";
            this.loginIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginIDTextBox.TabIndex = 25;
            this.loginIDTextBox.Visible = false;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LoginPassword", true));
            this.loginPasswordTextBox.Location = new System.Drawing.Point(272, 325);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginPasswordTextBox.TabIndex = 26;
            // 
            // designationIDTextBox
            // 
            this.designationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "DesignationID", true));
            this.designationIDTextBox.Location = new System.Drawing.Point(166, 350);
            this.designationIDTextBox.Name = "designationIDTextBox";
            this.designationIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.designationIDTextBox.TabIndex = 27;
            // 
            // passchecktext
            // 
            this.passchecktext.Location = new System.Drawing.Point(38, 330);
            this.passchecktext.Name = "passchecktext";
            this.passchecktext.Size = new System.Drawing.Size(100, 22);
            this.passchecktext.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 699);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passchecktext);
            this.Controls.Add(this.designationIDTextBox);
            this.Controls.Add(loginPasswordLabel);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(loginIDLabel);
            this.Controls.Add(this.loginIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Passtext);
            this.Controls.Add(this.Usertext);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.loginbutton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BugHunter1_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox Usertext;
        private System.Windows.Forms.TextBox Passtext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private _BugHunter1_1DataSet _BugHunter1_1DataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private _BugHunter1_1DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private _BugHunter1_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox loginIDTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.TextBox designationIDTextBox;
        private System.Windows.Forms.TextBox passchecktext;
        private System.Windows.Forms.TextBox textBox1;
    }
}

