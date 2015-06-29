using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace TestingApplication
{
    //using System.TimeSpan;
    public partial class Form5 : Form
    {
        int plshr = 0;
        int  id2=0;
        private DataGridViewRow _row;
        OleDbConnection connect = new OleDbConnection();
        private int id1;

        public Form5(DataGridView row)
             {
                
                
                //row.Cells[0], row.Cells[1], row.Cells[n] will work here
            }
        public Form5(String id1)
        {
            InitializeComponent();
            textBox1.Text = id1;
            id2 = int.Parse(textBox1.Text);
        }

        private void test_CaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.test_CaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BugHunter1_1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Test_Case' table. You can move, or remove it, as needed.
            this.test_CaseTableAdapter.FillBy(this._BugHunter1_1DataSet.Test_Case, TestCaseID);
       //     MessageBox.Show("id id" + id2);
        }

        
        private void bugrepbutton2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("case" + testCaseIDTextBox.Text);
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\visual studio 2010\Projects\TestingApplication\TestingApplication\BugHunter1.1.accdb";
            String pstartdate = planStartDateDateTimePicker.Text;
            String penddate = planEndDateDateTimePicker.Text;
            String astartdate = actualStartDateDateTimePicker.Text;
            String aenddate = actualEndDateDateTimePicker.Text;
            //int caseid;
            String projectid = projectIDComboBox.Text ;
            String sprojectid = subProjectIDComboBox.Text;
            String suiteid = testSuiteIDComboBox.Text;
            String testerid = testerIDComboBox.Text;
            String status = testStatusComboBox.Text;
            String desc = testCaseDescriptionTextBox.Text;
            String phours = planHoursTextBox.Text;
            String lhours = labourHoursTextBox.Text;
            String casestep = testCaseStepsTextBox.Text;
            String userreq = userRequirementsTextBox.Text;
            String comments = commentsTextBox.Text;

            connect.Open();


           
          
            OleDbCommand cmd = new OleDbCommand("INSERT INTO TEST_CASE(TESTCASEDESCRIPTION,TESTCASESTEPS,USERREQUIREMENTS,TESTSTATUS,COMMENTS,PLANHOURS,LABOURHOURS,PROJECTID,TESTERID,SUBPROJECTID,TESTSUITEID,planstartdate,planenddate,actualstartdate,actualenddate )" + "values(@desc,@casestep,@userreq,@status,@comments,@phours,@lhours,@projectid,@testerid,@sprojectid,@suiteid,@pstartdate,@penddate,@astartdate,@aenddate )", connect);
            
            if (connect.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@desc", OleDbType.Char, 20).Value = desc;
                cmd.Parameters.Add("@casestep", OleDbType.Char, 20).Value = casestep;
                cmd.Parameters.Add("@userreq", OleDbType.Char, 20).Value = userreq;
                cmd.Parameters.Add("@status", OleDbType.Char, 20).Value = status;
                cmd.Parameters.Add("@comments", OleDbType.Char, 20).Value = comments;
                cmd.Parameters.Add("@phours", OleDbType.Char, 20).Value = phours;
                cmd.Parameters.Add("@lhours", OleDbType.Char, 20).Value = lhours;
                cmd.Parameters.Add("@projectid", OleDbType.Char, 20).Value = projectid;    
                cmd.Parameters.Add("@testerid", OleDbType.Char, 20).Value = testerid;
                cmd.Parameters.Add("@sprojectid", OleDbType.Char, 20).Value = sprojectid;
                cmd.Parameters.Add("@suiteid", OleDbType.Char, 20).Value = suiteid;
                cmd.Parameters.Add("@pstartdate", OleDbType.Char, 20).Value = pstartdate;
                cmd.Parameters.Add("@penddate", OleDbType.Char, 20).Value = penddate;
                cmd.Parameters.Add("@astartdate", OleDbType.Char, 20).Value = astartdate;
                cmd.Parameters.Add("@aenddate", OleDbType.Char, 20).Value = aenddate;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("TEST CASE ADDED");
                        connect.Close();
                        try
                        {
                             cmd.ExecuteNonQuery();
                            MessageBox.Show("TEST CASE ADDED");
                            connect.Close();

                        }
                    catch (Exception expe)
                        {
                          //  MessageBox.Show(expe.Source);
                            connect.Close();
                        }
                    }
              else
                    {
                        MessageBox.Show(" CONNECTION FAILED");
                    }


            Form3 formDig1 = new Form3(textBox1.Text);
            //Form3 formDig1 = new Form3();
            formDig1.Show();
            Close();
            // testfrom1 formDig1 = new testfrom1();
            //formDig1.Show();
            //Close();


        }

        private void testerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //       // this.test_CaseTableAdapter.FillBy(this._BugHunter1_1DataSet.Test_Case);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        }

        private void fillByTestCaseIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.test_CaseTableAdapter.FillByTestCaseID(this._BugHunter1_1DataSet.Test_Case);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByTestCaseIDToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               // this.test_CaseTableAdapter.FillBy(this._BugHunter1_1DataSet.Test_Case);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public int TestCaseID {
            get { return id2; }// { return TestCaseID; }
            set { }//TestCaseID = id1; }//int.Parse(textBox1.Text) ;}
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            testfrom1 formDig1 = new testfrom1();
            formDig1.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void testStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testStatusComboBox.Text == "FAIL") 
            {
                bugrepbutton2.Visible = true;
                bugrepbutton2.Enabled = true;
                testcaseaddbutton.Visible = false;
                testcaseaddbutton.Enabled = false;
 
            }
            else 
            {
                
                testcaseaddbutton.Visible = true;
                testcaseaddbutton.Enabled = true;
                bugrepbutton2.Visible = false;
                bugrepbutton2.Enabled = false;
            }

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 formdig1 = new Form1();
            formdig1.Show();
            Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;
            
            return ts; 
        }
        private void planEndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            TimeSpan tds = getDateDifference(planEndDateDateTimePicker.Value, planStartDateDateTimePicker.Value);
           
            plshr = tds.Days;
            int plshre = (plshr * 8);
            planHoursTextBox.Text = plshre.ToString();
        }

        private void testcaseaddbutton_Click(object sender, EventArgs e)
        {
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\visual studio 2010\Projects\TestingApplication\TestingApplication\BugHunter1.1.accdb";
            String pstartdate = planStartDateDateTimePicker.Text;
            String penddate = planEndDateDateTimePicker.Text;
            String astartdate = actualStartDateDateTimePicker.Text;
            String aenddate = actualEndDateDateTimePicker.Text;
            //int caseid;
            String projectid = projectIDComboBox.Text;
            String sprojectid = subProjectIDComboBox.Text;
            String suiteid = testSuiteIDComboBox.Text;
            String testerid = testerIDComboBox.Text;
            String status = testStatusComboBox.Text;
            String desc = testCaseDescriptionTextBox.Text;
            String phours = planHoursTextBox.Text;
            String lhours = labourHoursTextBox.Text;
            String casestep = testCaseStepsTextBox.Text;
            String userreq = userRequirementsTextBox.Text;
            String comments = commentsTextBox.Text;

            connect.Open();




            OleDbCommand cmd = new OleDbCommand("INSERT INTO TEST_CASE(TESTCASEDESCRIPTION,TESTCASESTEPS,USERREQUIREMENTS,TESTSTATUS,COMMENTS,PLANHOURS,LABOURHOURS,PROJECTID,TESTERID,SUBPROJECTID,TESTSUITEID,planstartdate,planenddate,actualstartdate,actualenddate )" + "values(@desc,@casestep,@userreq,@status,@comments,@phours,@lhours,@projectid,@testerid,@sprojectid,@suiteid,@pstartdate,@penddate,@astartdate,@aenddate )", connect);

            if (connect.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@desc", OleDbType.Char, 20).Value = desc;
                cmd.Parameters.Add("@casestep", OleDbType.Char, 20).Value = casestep;
                cmd.Parameters.Add("@userreq", OleDbType.Char, 20).Value = userreq;
                cmd.Parameters.Add("@status", OleDbType.Char, 20).Value = status;
                cmd.Parameters.Add("@comments", OleDbType.Char, 20).Value = comments;
                cmd.Parameters.Add("@phours", OleDbType.Char, 20).Value = phours;
                cmd.Parameters.Add("@lhours", OleDbType.Char, 20).Value = lhours;
                cmd.Parameters.Add("@projectid", OleDbType.Char, 20).Value = projectid;
                cmd.Parameters.Add("@testerid", OleDbType.Char, 20).Value = testerid;
                cmd.Parameters.Add("@sprojectid", OleDbType.Char, 20).Value = sprojectid;
                cmd.Parameters.Add("@suiteid", OleDbType.Char, 20).Value = suiteid;
                cmd.Parameters.Add("@pstartdate", OleDbType.Char, 20).Value = pstartdate;
                cmd.Parameters.Add("@penddate", OleDbType.Char, 20).Value = penddate;
                cmd.Parameters.Add("@astartdate", OleDbType.Char, 20).Value = astartdate;
                cmd.Parameters.Add("@aenddate", OleDbType.Char, 20).Value = aenddate;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TEST CASE ADDED");
                connect.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("TEST CASE ADDED");
                    connect.Close();

                }
                catch (Exception expe)
                {
                    //  MessageBox.Show(expe.Source);
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show(" CONNECTION FAILED");
            }


            //Form3 formDig1 = new Form3(textBox1.Text);
            //formDig1.Show();
            //Close();
            testfrom1 formDig1 = new testfrom1();
            formDig1.Show();
            Close();

        }

        private void actualEndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            TimeSpan tdsm = getDateDifference(actualEndDateDateTimePicker.Value, actualStartDateDateTimePicker.Value);
          //  TimeSpan tdsm = getDateDifference(planEndDateDateTimePicker.Value, planStartDateDateTimePicker.Value);
            int ashr = tdsm.Days;
            int ashre = (ashr * 8);
            labourHoursTextBox.Text= ashre.ToString();
          //  MessageBox.Show(" pl " + ashr + " tt " + ashre + " pp " + tdsm);
       
        }
    }
}
