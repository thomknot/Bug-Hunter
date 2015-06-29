namespace TestingApplication
{
    partial class Form5
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
            System.Windows.Forms.Label testCaseIDLabel;
            System.Windows.Forms.Label testCaseDescriptionLabel;
            System.Windows.Forms.Label testCaseStepsLabel;
            System.Windows.Forms.Label userRequirementsLabel;
            System.Windows.Forms.Label planStartDateLabel;
            System.Windows.Forms.Label planEndDateLabel;
            System.Windows.Forms.Label planHoursLabel;
            System.Windows.Forms.Label actualStartDateLabel;
            System.Windows.Forms.Label actualEndDateLabel;
            System.Windows.Forms.Label labourHoursLabel;
            System.Windows.Forms.Label testStatusLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label projectIDLabel;
            System.Windows.Forms.Label subProjectIDLabel;
            System.Windows.Forms.Label testSuiteIDLabel;
            System.Windows.Forms.Label testerIDLabel;
            this._BugHunter1_1DataSet = new TestingApplication._BugHunter1_1DataSet();
            this.test_CaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_CaseTableAdapter = new TestingApplication._BugHunter1_1DataSetTableAdapters.Test_CaseTableAdapter();
            this.tableAdapterManager = new TestingApplication._BugHunter1_1DataSetTableAdapters.TableAdapterManager();
            this.testCaseIDTextBox = new System.Windows.Forms.TextBox();
            this.testCaseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.testCaseStepsTextBox = new System.Windows.Forms.TextBox();
            this.userRequirementsTextBox = new System.Windows.Forms.TextBox();
            this.planStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.planEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.planHoursTextBox = new System.Windows.Forms.TextBox();
            this.actualStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labourHoursTextBox = new System.Windows.Forms.TextBox();
            this.testStatusComboBox = new System.Windows.Forms.ComboBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.bugrepbutton2 = new System.Windows.Forms.Button();
            this.projectIDComboBox = new System.Windows.Forms.ComboBox();
            this.subProjectIDComboBox = new System.Windows.Forms.ComboBox();
            this.testSuiteIDComboBox = new System.Windows.Forms.ComboBox();
            this.testerIDComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testcaseaddbutton = new System.Windows.Forms.Button();
            this.plhourstext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            testCaseIDLabel = new System.Windows.Forms.Label();
            testCaseDescriptionLabel = new System.Windows.Forms.Label();
            testCaseStepsLabel = new System.Windows.Forms.Label();
            userRequirementsLabel = new System.Windows.Forms.Label();
            planStartDateLabel = new System.Windows.Forms.Label();
            planEndDateLabel = new System.Windows.Forms.Label();
            planHoursLabel = new System.Windows.Forms.Label();
            actualStartDateLabel = new System.Windows.Forms.Label();
            actualEndDateLabel = new System.Windows.Forms.Label();
            labourHoursLabel = new System.Windows.Forms.Label();
            testStatusLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            projectIDLabel = new System.Windows.Forms.Label();
            subProjectIDLabel = new System.Windows.Forms.Label();
            testSuiteIDLabel = new System.Windows.Forms.Label();
            testerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._BugHunter1_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_CaseBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testCaseIDLabel
            // 
            testCaseIDLabel.AutoSize = true;
            testCaseIDLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            testCaseIDLabel.Location = new System.Drawing.Point(241, 238);
            testCaseIDLabel.MaximumSize = new System.Drawing.Size(150, 22);
            testCaseIDLabel.MinimumSize = new System.Drawing.Size(120, 22);
            testCaseIDLabel.Name = "testCaseIDLabel";
            testCaseIDLabel.Size = new System.Drawing.Size(120, 22);
            testCaseIDLabel.TabIndex = 1;
            testCaseIDLabel.Text = "Test Case ID:";
            testCaseIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testCaseDescriptionLabel
            // 
            testCaseDescriptionLabel.AutoSize = true;
            testCaseDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            testCaseDescriptionLabel.Location = new System.Drawing.Point(241, 306);
            testCaseDescriptionLabel.MaximumSize = new System.Drawing.Size(150, 22);
            testCaseDescriptionLabel.MinimumSize = new System.Drawing.Size(120, 22);
            testCaseDescriptionLabel.Name = "testCaseDescriptionLabel";
            testCaseDescriptionLabel.Size = new System.Drawing.Size(120, 22);
            testCaseDescriptionLabel.TabIndex = 2;
            testCaseDescriptionLabel.Text = "Case Description:";
            testCaseDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testCaseStepsLabel
            // 
            testCaseStepsLabel.AutoSize = true;
            testCaseStepsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            testCaseStepsLabel.Location = new System.Drawing.Point(241, 344);
            testCaseStepsLabel.MaximumSize = new System.Drawing.Size(150, 22);
            testCaseStepsLabel.MinimumSize = new System.Drawing.Size(120, 22);
            testCaseStepsLabel.Name = "testCaseStepsLabel";
            testCaseStepsLabel.Size = new System.Drawing.Size(120, 22);
            testCaseStepsLabel.TabIndex = 4;
            testCaseStepsLabel.Text = "Test Case Steps:";
            testCaseStepsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userRequirementsLabel
            // 
            userRequirementsLabel.AutoSize = true;
            userRequirementsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            userRequirementsLabel.Location = new System.Drawing.Point(238, 372);
            userRequirementsLabel.MaximumSize = new System.Drawing.Size(150, 22);
            userRequirementsLabel.MinimumSize = new System.Drawing.Size(120, 22);
            userRequirementsLabel.Name = "userRequirementsLabel";
            userRequirementsLabel.Size = new System.Drawing.Size(134, 22);
            userRequirementsLabel.TabIndex = 6;
            userRequirementsLabel.Text = "User Requirements:";
            userRequirementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planStartDateLabel
            // 
            planStartDateLabel.AutoSize = true;
            planStartDateLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            planStartDateLabel.Location = new System.Drawing.Point(638, 105);
            planStartDateLabel.MaximumSize = new System.Drawing.Size(150, 22);
            planStartDateLabel.MinimumSize = new System.Drawing.Size(120, 22);
            planStartDateLabel.Name = "planStartDateLabel";
            planStartDateLabel.Size = new System.Drawing.Size(120, 22);
            planStartDateLabel.TabIndex = 8;
            planStartDateLabel.Text = "Plan Start Date:";
            planStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planEndDateLabel
            // 
            planEndDateLabel.AutoSize = true;
            planEndDateLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            planEndDateLabel.Location = new System.Drawing.Point(638, 137);
            planEndDateLabel.MaximumSize = new System.Drawing.Size(150, 22);
            planEndDateLabel.MinimumSize = new System.Drawing.Size(120, 22);
            planEndDateLabel.Name = "planEndDateLabel";
            planEndDateLabel.Size = new System.Drawing.Size(120, 22);
            planEndDateLabel.TabIndex = 10;
            planEndDateLabel.Text = "Plan End Date:";
            planEndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planHoursLabel
            // 
            planHoursLabel.AutoSize = true;
            planHoursLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            planHoursLabel.Location = new System.Drawing.Point(638, 175);
            planHoursLabel.MaximumSize = new System.Drawing.Size(150, 22);
            planHoursLabel.MinimumSize = new System.Drawing.Size(120, 22);
            planHoursLabel.Name = "planHoursLabel";
            planHoursLabel.Size = new System.Drawing.Size(120, 22);
            planHoursLabel.TabIndex = 12;
            planHoursLabel.Text = "Plan Hours:";
            planHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actualStartDateLabel
            // 
            actualStartDateLabel.AutoSize = true;
            actualStartDateLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            actualStartDateLabel.Location = new System.Drawing.Point(638, 200);
            actualStartDateLabel.MaximumSize = new System.Drawing.Size(150, 22);
            actualStartDateLabel.MinimumSize = new System.Drawing.Size(120, 22);
            actualStartDateLabel.Name = "actualStartDateLabel";
            actualStartDateLabel.Size = new System.Drawing.Size(120, 22);
            actualStartDateLabel.TabIndex = 14;
            actualStartDateLabel.Text = "Actual Start Date:";
            actualStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actualEndDateLabel
            // 
            actualEndDateLabel.AutoSize = true;
            actualEndDateLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            actualEndDateLabel.Location = new System.Drawing.Point(638, 238);
            actualEndDateLabel.MaximumSize = new System.Drawing.Size(150, 22);
            actualEndDateLabel.MinimumSize = new System.Drawing.Size(120, 22);
            actualEndDateLabel.Name = "actualEndDateLabel";
            actualEndDateLabel.Size = new System.Drawing.Size(120, 22);
            actualEndDateLabel.TabIndex = 16;
            actualEndDateLabel.Text = "Actual End Date:";
            actualEndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labourHoursLabel
            // 
            labourHoursLabel.AutoSize = true;
            labourHoursLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            labourHoursLabel.Location = new System.Drawing.Point(638, 271);
            labourHoursLabel.MaximumSize = new System.Drawing.Size(150, 22);
            labourHoursLabel.MinimumSize = new System.Drawing.Size(120, 22);
            labourHoursLabel.Name = "labourHoursLabel";
            labourHoursLabel.Size = new System.Drawing.Size(120, 22);
            labourHoursLabel.TabIndex = 18;
            labourHoursLabel.Text = "Labour Hours:";
            labourHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testStatusLabel
            // 
            testStatusLabel.AutoSize = true;
            testStatusLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            testStatusLabel.Location = new System.Drawing.Point(241, 271);
            testStatusLabel.MaximumSize = new System.Drawing.Size(150, 22);
            testStatusLabel.MinimumSize = new System.Drawing.Size(120, 22);
            testStatusLabel.Name = "testStatusLabel";
            testStatusLabel.Size = new System.Drawing.Size(120, 22);
            testStatusLabel.TabIndex = 22;
            testStatusLabel.Text = "Test Status:";
            testStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            commentsLabel.Location = new System.Drawing.Point(241, 410);
            commentsLabel.MaximumSize = new System.Drawing.Size(150, 22);
            commentsLabel.MinimumSize = new System.Drawing.Size(120, 22);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(120, 22);
            commentsLabel.TabIndex = 26;
            commentsLabel.Text = "Comments:";
            commentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectIDLabel
            // 
            projectIDLabel.AutoSize = true;
            projectIDLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            projectIDLabel.Location = new System.Drawing.Point(241, 103);
            projectIDLabel.MaximumSize = new System.Drawing.Size(150, 22);
            projectIDLabel.MinimumSize = new System.Drawing.Size(120, 22);
            projectIDLabel.Name = "projectIDLabel";
            projectIDLabel.Size = new System.Drawing.Size(120, 22);
            projectIDLabel.TabIndex = 33;
            projectIDLabel.Text = "Project ID:";
            projectIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subProjectIDLabel
            // 
            subProjectIDLabel.AutoSize = true;
            subProjectIDLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            subProjectIDLabel.Location = new System.Drawing.Point(241, 137);
            subProjectIDLabel.MaximumSize = new System.Drawing.Size(150, 22);
            subProjectIDLabel.MinimumSize = new System.Drawing.Size(120, 22);
            subProjectIDLabel.Name = "subProjectIDLabel";
            subProjectIDLabel.Size = new System.Drawing.Size(120, 22);
            subProjectIDLabel.TabIndex = 34;
            subProjectIDLabel.Text = "Sub Project ID:";
            subProjectIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testSuiteIDLabel
            // 
            testSuiteIDLabel.AutoSize = true;
            testSuiteIDLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            testSuiteIDLabel.Location = new System.Drawing.Point(241, 171);
            testSuiteIDLabel.MaximumSize = new System.Drawing.Size(150, 22);
            testSuiteIDLabel.MinimumSize = new System.Drawing.Size(120, 22);
            testSuiteIDLabel.Name = "testSuiteIDLabel";
            testSuiteIDLabel.Size = new System.Drawing.Size(120, 22);
            testSuiteIDLabel.TabIndex = 35;
            testSuiteIDLabel.Text = "Test Suite ID:";
            testSuiteIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testerIDLabel
            // 
            testerIDLabel.AutoSize = true;
            testerIDLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            testerIDLabel.Location = new System.Drawing.Point(241, 200);
            testerIDLabel.MaximumSize = new System.Drawing.Size(150, 22);
            testerIDLabel.MinimumSize = new System.Drawing.Size(120, 22);
            testerIDLabel.Name = "testerIDLabel";
            testerIDLabel.Size = new System.Drawing.Size(120, 22);
            testerIDLabel.TabIndex = 36;
            testerIDLabel.Text = "Tester ID:";
            testerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _BugHunter1_1DataSet
            // 
            this._BugHunter1_1DataSet.DataSetName = "_BugHunter1_1DataSet";
            this._BugHunter1_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test_CaseBindingSource
            // 
            this.test_CaseBindingSource.DataMember = "Test_Case";
            this.test_CaseBindingSource.DataSource = this._BugHunter1_1DataSet;
            // 
            // test_CaseTableAdapter
            // 
            this.test_CaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.Sub_ProjectTableAdapter = null;
            this.tableAdapterManager.Test_CaseTableAdapter = this.test_CaseTableAdapter;
            this.tableAdapterManager.Test_SuiteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestingApplication._BugHunter1_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testCaseIDTextBox
            // 
            this.testCaseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "TestCaseID", true));
            this.testCaseIDTextBox.Location = new System.Drawing.Point(378, 238);
            this.testCaseIDTextBox.Name = "testCaseIDTextBox";
            this.testCaseIDTextBox.Size = new System.Drawing.Size(140, 22);
            this.testCaseIDTextBox.TabIndex = 2;
            // 
            // testCaseDescriptionTextBox
            // 
            this.testCaseDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "TestCaseDescription", true));
            this.testCaseDescriptionTextBox.Location = new System.Drawing.Point(378, 306);
            this.testCaseDescriptionTextBox.Name = "testCaseDescriptionTextBox";
            this.testCaseDescriptionTextBox.Size = new System.Drawing.Size(544, 22);
            this.testCaseDescriptionTextBox.TabIndex = 8;
            // 
            // testCaseStepsTextBox
            // 
            this.testCaseStepsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "TestCaseSteps", true));
            this.testCaseStepsTextBox.Location = new System.Drawing.Point(378, 344);
            this.testCaseStepsTextBox.Name = "testCaseStepsTextBox";
            this.testCaseStepsTextBox.Size = new System.Drawing.Size(544, 22);
            this.testCaseStepsTextBox.TabIndex = 9;
            // 
            // userRequirementsTextBox
            // 
            this.userRequirementsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "UserRequirements", true));
            this.userRequirementsTextBox.Location = new System.Drawing.Point(378, 372);
            this.userRequirementsTextBox.Name = "userRequirementsTextBox";
            this.userRequirementsTextBox.Size = new System.Drawing.Size(544, 22);
            this.userRequirementsTextBox.TabIndex = 7;
            // 
            // planStartDateDateTimePicker
            // 
            this.planStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.test_CaseBindingSource, "PlanStartDate", true));
            this.planStartDateDateTimePicker.Location = new System.Drawing.Point(782, 105);
            this.planStartDateDateTimePicker.Name = "planStartDateDateTimePicker";
            this.planStartDateDateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.planStartDateDateTimePicker.TabIndex = 5;
            // 
            // planEndDateDateTimePicker
            // 
            this.planEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.test_CaseBindingSource, "PlanEndDate", true));
            this.planEndDateDateTimePicker.Location = new System.Drawing.Point(782, 137);
            this.planEndDateDateTimePicker.Name = "planEndDateDateTimePicker";
            this.planEndDateDateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.planEndDateDateTimePicker.TabIndex = 5;
            this.planEndDateDateTimePicker.ValueChanged += new System.EventHandler(this.planEndDateDateTimePicker_ValueChanged);
            // 
            // planHoursTextBox
            // 
            this.planHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "PlanHours", true));
            this.planHoursTextBox.Location = new System.Drawing.Point(782, 175);
            this.planHoursTextBox.Name = "planHoursTextBox";
            this.planHoursTextBox.Size = new System.Drawing.Size(140, 22);
            this.planHoursTextBox.TabIndex = 13;
            this.planHoursTextBox.Text = "0";
            // 
            // actualStartDateDateTimePicker
            // 
            this.actualStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.test_CaseBindingSource, "ActualStartDate", true));
            this.actualStartDateDateTimePicker.Location = new System.Drawing.Point(782, 203);
            this.actualStartDateDateTimePicker.Name = "actualStartDateDateTimePicker";
            this.actualStartDateDateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.actualStartDateDateTimePicker.TabIndex = 6;
            // 
            // actualEndDateDateTimePicker
            // 
            this.actualEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.test_CaseBindingSource, "ActualEndDate", true));
            this.actualEndDateDateTimePicker.Location = new System.Drawing.Point(782, 238);
            this.actualEndDateDateTimePicker.Name = "actualEndDateDateTimePicker";
            this.actualEndDateDateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.actualEndDateDateTimePicker.TabIndex = 7;
            this.actualEndDateDateTimePicker.ValueChanged += new System.EventHandler(this.actualEndDateDateTimePicker_ValueChanged);
            // 
            // labourHoursTextBox
            // 
            this.labourHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "LabourHours", true));
            this.labourHoursTextBox.Location = new System.Drawing.Point(782, 271);
            this.labourHoursTextBox.Name = "labourHoursTextBox";
            this.labourHoursTextBox.Size = new System.Drawing.Size(140, 22);
            this.labourHoursTextBox.TabIndex = 19;
            this.labourHoursTextBox.Text = "0";
            // 
            // testStatusComboBox
            // 
            this.testStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "TestStatus", true));
            this.testStatusComboBox.FormattingEnabled = true;
            this.testStatusComboBox.Items.AddRange(new object[] {
            "ASSIGNED",
            "IN PROGRESS",
            "PASS",
            "FAIL",
            "CLOSED",
            "UNDER REVIEW",
            "BUG REPORTED",
            "FIXING IN PROGRESS",
            "RE-OPEN"});
            this.testStatusComboBox.Location = new System.Drawing.Point(378, 269);
            this.testStatusComboBox.Name = "testStatusComboBox";
            this.testStatusComboBox.Size = new System.Drawing.Size(140, 24);
            this.testStatusComboBox.TabIndex = 4;
            this.testStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.testStatusComboBox_SelectedIndexChanged);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(378, 410);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(544, 22);
            this.commentsTextBox.TabIndex = 27;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(518, 438);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(117, 34);
            this.backbutton.TabIndex = 32;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // bugrepbutton2
            // 
            this.bugrepbutton2.Enabled = false;
            this.bugrepbutton2.Location = new System.Drawing.Point(782, 438);
            this.bugrepbutton2.Name = "bugrepbutton2";
            this.bugrepbutton2.Size = new System.Drawing.Size(140, 34);
            this.bugrepbutton2.TabIndex = 33;
            this.bugrepbutton2.Text = "REPORT A BUG";
            this.bugrepbutton2.UseVisualStyleBackColor = true;
            this.bugrepbutton2.Visible = false;
            this.bugrepbutton2.Click += new System.EventHandler(this.bugrepbutton2_Click);
            // 
            // projectIDComboBox
            // 
            this.projectIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "ProjectID", true));
            this.projectIDComboBox.FormattingEnabled = true;
            this.projectIDComboBox.Items.AddRange(new object[] {
            "0001",
            "0002",
            "0003",
            "0004"});
            this.projectIDComboBox.Location = new System.Drawing.Point(378, 103);
            this.projectIDComboBox.Name = "projectIDComboBox";
            this.projectIDComboBox.Size = new System.Drawing.Size(140, 24);
            this.projectIDComboBox.TabIndex = 34;
            // 
            // subProjectIDComboBox
            // 
            this.subProjectIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "SubProjectID", true));
            this.subProjectIDComboBox.FormattingEnabled = true;
            this.subProjectIDComboBox.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.subProjectIDComboBox.Location = new System.Drawing.Point(378, 139);
            this.subProjectIDComboBox.Name = "subProjectIDComboBox";
            this.subProjectIDComboBox.Size = new System.Drawing.Size(140, 24);
            this.subProjectIDComboBox.TabIndex = 35;
            // 
            // testSuiteIDComboBox
            // 
            this.testSuiteIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "TestSuiteID", true));
            this.testSuiteIDComboBox.FormattingEnabled = true;
            this.testSuiteIDComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.testSuiteIDComboBox.Location = new System.Drawing.Point(378, 168);
            this.testSuiteIDComboBox.Name = "testSuiteIDComboBox";
            this.testSuiteIDComboBox.Size = new System.Drawing.Size(140, 24);
            this.testSuiteIDComboBox.TabIndex = 2;
            // 
            // testerIDComboBox
            // 
            this.testerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_CaseBindingSource, "TesterID", true));
            this.testerIDComboBox.FormattingEnabled = true;
            this.testerIDComboBox.Items.AddRange(new object[] {
            "001",
            "002",
            "003"});
            this.testerIDComboBox.Location = new System.Drawing.Point(378, 203);
            this.testerIDComboBox.Name = "testerIDComboBox";
            this.testerIDComboBox.Size = new System.Drawing.Size(140, 24);
            this.testerIDComboBox.TabIndex = 3;
            this.testerIDComboBox.SelectedIndexChanged += new System.EventHandler(this.testerIDComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(532, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fILEToolStripMenuItem.Text = "File";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.lOGOUTToolStripMenuItem.Text = "Log Out";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.eXITToolStripMenuItem.Text = "Exit";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // testcaseaddbutton
            // 
            this.testcaseaddbutton.Enabled = false;
            this.testcaseaddbutton.Location = new System.Drawing.Point(641, 438);
            this.testcaseaddbutton.Name = "testcaseaddbutton";
            this.testcaseaddbutton.Size = new System.Drawing.Size(140, 34);
            this.testcaseaddbutton.TabIndex = 41;
            this.testcaseaddbutton.Text = "Add Test Case";
            this.testcaseaddbutton.UseVisualStyleBackColor = true;
            this.testcaseaddbutton.Visible = false;
            this.testcaseaddbutton.Click += new System.EventHandler(this.testcaseaddbutton_Click);
            // 
            // plhourstext
            // 
            this.plhourstext.Location = new System.Drawing.Point(323, 449);
            this.plhourstext.Name = "plhourstext";
            this.plhourstext.Size = new System.Drawing.Size(100, 22);
            this.plhourstext.TabIndex = 42;
            this.plhourstext.Text = "0";
            this.plhourstext.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(532, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Test Case Details";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plhourstext);
            this.Controls.Add(this.testcaseaddbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(testerIDLabel);
            this.Controls.Add(this.testerIDComboBox);
            this.Controls.Add(testSuiteIDLabel);
            this.Controls.Add(this.testSuiteIDComboBox);
            this.Controls.Add(subProjectIDLabel);
            this.Controls.Add(this.subProjectIDComboBox);
            this.Controls.Add(projectIDLabel);
            this.Controls.Add(this.projectIDComboBox);
            this.Controls.Add(this.bugrepbutton2);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(testStatusLabel);
            this.Controls.Add(this.testStatusComboBox);
            this.Controls.Add(labourHoursLabel);
            this.Controls.Add(this.labourHoursTextBox);
            this.Controls.Add(actualEndDateLabel);
            this.Controls.Add(this.actualEndDateDateTimePicker);
            this.Controls.Add(actualStartDateLabel);
            this.Controls.Add(this.actualStartDateDateTimePicker);
            this.Controls.Add(planHoursLabel);
            this.Controls.Add(this.planHoursTextBox);
            this.Controls.Add(planEndDateLabel);
            this.Controls.Add(this.planEndDateDateTimePicker);
            this.Controls.Add(planStartDateLabel);
            this.Controls.Add(this.planStartDateDateTimePicker);
            this.Controls.Add(userRequirementsLabel);
            this.Controls.Add(this.userRequirementsTextBox);
            this.Controls.Add(testCaseStepsLabel);
            this.Controls.Add(this.testCaseStepsTextBox);
            this.Controls.Add(testCaseDescriptionLabel);
            this.Controls.Add(this.testCaseDescriptionTextBox);
            this.Controls.Add(testCaseIDLabel);
            this.Controls.Add(this.testCaseIDTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG HUNTER";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this._BugHunter1_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_CaseBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _BugHunter1_1DataSet _BugHunter1_1DataSet;
        private System.Windows.Forms.BindingSource test_CaseBindingSource;
        private _BugHunter1_1DataSetTableAdapters.Test_CaseTableAdapter test_CaseTableAdapter;
        private _BugHunter1_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox testCaseIDTextBox;
        private System.Windows.Forms.TextBox testCaseDescriptionTextBox;
        private System.Windows.Forms.TextBox testCaseStepsTextBox;
        private System.Windows.Forms.TextBox userRequirementsTextBox;
        private System.Windows.Forms.DateTimePicker planStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker planEndDateDateTimePicker;
        private System.Windows.Forms.TextBox planHoursTextBox;
        private System.Windows.Forms.DateTimePicker actualStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker actualEndDateDateTimePicker;
        private System.Windows.Forms.TextBox labourHoursTextBox;
        private System.Windows.Forms.ComboBox testStatusComboBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button bugrepbutton2;
        private System.Windows.Forms.ComboBox projectIDComboBox;
        private System.Windows.Forms.ComboBox subProjectIDComboBox;
        private System.Windows.Forms.ComboBox testSuiteIDComboBox;
        private System.Windows.Forms.ComboBox testerIDComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Button testcaseaddbutton;
        private System.Windows.Forms.TextBox plhourstext;
        private System.Windows.Forms.Label label1;
    }
}