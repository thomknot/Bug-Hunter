using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace TestingApplication
{
    public partial class Form3 : Form
    {
        int ids2 = 0;
        OleDbConnection connect = new OleDbConnection();
        private int ids1;
     public Form3(string ids1)
     //   public Form3()
        {
            InitializeComponent();
            textBox1.Text = ids1;
            ids2 = int.Parse(textBox1.Text);
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Bug' table. You can move, or remove it, as needed.
            //this.bugTableAdapter.Fill(this._BugHunter1_1DataSet.Bug);
          this.bugTableAdapter.FillBy1(this._BugHunter1_1DataSet.Bug, BugId);
        }
          
        private void bugDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stepsToReproduceTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form2 formDig1 = new Form2();
            formDig1.Show();
            Close();
        }





        private void Addbuttom_Click(object sender, EventArgs e)
        { }

        private void bugadd_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(bugIDTextBox1.Text + "lp");

            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\visual studio 2010\Projects\TestingApplication\TestingApplication\BugHunter1.1.accdb";
                                        
            //int bugid =1;

            String bugversion = bugVersionTextBox1.Text;
            String tcaseid = testCaseIDComboBox.Text;
            String buildno = buildNumberComboBox.Text;
            String devid = developerIDComboBox.Text;
            String bugstatus = bugStatusComboBox.Text;
            String bugdesc = bugDescriptionTextBox1.Text;
            String severity = severityComboBox1.Text;
            String priority = priorityComboBox1.Text;
            String expectres = expectedResultsTextBox1.Text;
            String actualres = actualResultsTextBox1.Text;
            String steps = stepsToReproduceTextBox1.Text;
            String addinfo = additionalInformationTextBox1.Text;
            String comments = commentsTextBox1.Text;
            String dreport = dateReportedDateTimePicker1.Text;
            String lupdate = lastUpdateDateTimePicker1.Text;
            String dfixed = dateFixedDateTimePicker.Text;
            String attach = attachmentLinkLabel.Text;
            String hyper = hyperLinkLinkLabel.Text;

            connect.Open();

          //  OleDbCommand cmd = new OleDbCommand("INSERT INTO BUG(BugStatus,BuildNumber,BugDescription,StepsToReproduce,Severity,Priority,ExpectedResults,ActualResults,Comments,AdditionalInformation,Bugversion,Developerid,TestCaseID,DateReported,LastUpdate,DateFixed,Hyperlink)" + "values(@bugstatus,@buildno,@bugdesc,@steps,@severity,@priority,@expectres,@actualres,@comments,@addinfo,@bugversion,@devid,@tcaseid,@dreport,@lupdate,@dfixed,@hyper)", connect);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO BUG(BuildNumber,BugDescription,Severity,TestCaseID)" + "values(@buildno,@bugdesc,@severity,@tcaseid)", connect);
            if (connect.State == ConnectionState.Open)
            {
                
                //  cmd.Parameters.Add("bugid", OleDbType.Integer).Value = bugid;


               // cmd.Parameters.Add("@bugstatus", OleDbType.Char, 20).Value = bugstatus;
                cmd.Parameters.Add("@buildno", OleDbType.Char, 20).Value = buildno;
                cmd.Parameters.Add("@bugdesc", OleDbType.Char, 20).Value = bugdesc;
             //   cmd.Parameters.Add("@steps", OleDbType.Char, 20).Value = steps;
                cmd.Parameters.Add("@severity", OleDbType.Char, 20).Value = severity;
                //cmd.Parameters.Add("@priority", OleDbType.Char, 20).Value = priority;
                //cmd.Parameters.Add("@expectres", OleDbType.Char, 20).Value = expectres;
                //cmd.Parameters.Add("@actualres", OleDbType.Char, 20).Value = actualres;
                //cmd.Parameters.Add("@comments", OleDbType.Char, 20).Value = comments;
                //cmd.Parameters.Add("@addinfo", OleDbType.Char, 20).Value = addinfo;
                //cmd.Parameters.Add("bugversion", OleDbType.Char, 20).Value = bugversion;
                //cmd.Parameters.Add("devid", OleDbType.Char, 20).Value = devid;
                cmd.Parameters.Add("tcaseid", OleDbType.Char, 20).Value = tcaseid;
                //cmd.Parameters.Add("@dreport", OleDbType.Char, 20).Value = dreport;
                //cmd.Parameters.Add("@lupdate", OleDbType.Char, 20).Value = lupdate;
                //cmd.Parameters.Add("@dfixed", OleDbType.Char, 20).Value = dfixed;
                ////cmd.Parameters.Add("attach", OleDbType.Char, 20).Value = attach;
                //cmd.Parameters.Add("@hyper", OleDbType.Char, 20).Value = hyper;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("BUG ADDED");
                connect.Close();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("BUG ADDED");
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
            Form2 formDig1 = new Form2();
            formDig1.Show();
            Close();


        }


        public int BugId
        {

            get { return ids2; }// { return TestCaseID; }
            set { }//TestCaseID = id1; }//int.Parse(textBox1.Text) ;}
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bugTableAdapter.FillBy(this._BugHunter1_1DataSet.Bug);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void updatebutton_Click(object sender, EventArgs e) { }
        //{
        //    connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\visual studio 2010\Projects\TestingApplication\TestingApplication\BugHunter1.1.accdb";
        //    String lupdate = lastUpdateDateTimePicker1.Text;
        //    String dfixed = dateFixedDateTimePicker.Text;
        //    String bugversion = bugVersionTextBox1.Text;
        //    String bugstatus = bugStatusComboBox.Text;
        //    int  budid1 = int.Parse(bugIDTextBox1.Text);
        //    connect.Open();

        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.CommandType = CommandType.Text;

        //    cmd.CommandText = ("UPDATE BUG SET BugStatus='@bugstatus' WHERE BUGID='BUGID'");//, connect);
        //    //cmd.Connection = connect;
        //    //connect.Open();
        //    if (connect.State == ConnectionState.Open)
        //    {

        //       // cmd.Connection.Open();
        //        cmd.Parameters.Add("BugId",OleDbType.Integer , 20).Value = budid1;
        //        //cmd.Parameters.AddWithValue("@bugstatus", bugStatusComboBox.Text);
        //        cmd.Parameters.Add("@bugstatus", OleDbType.Char, 20).Value = bugstatus;
        //        //cmd.Parameters.Add("@bugversion", OleDbType.Char, 20).Value = bugversion;
        //        //cmd.Parameters.Add("lupdate", OleDbType.Char, 20).Value = lupdate;
        //        //cmd.Parameters.Add("dfixed", OleDbType.Char, 20).Value = dfixed;
        //        cmd.Connection = connect;
        //        //connect.Open();
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("BUG UPDATED");
        //        connect.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show(" CONNECTION FAILED");
        //    }
          // }
        

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 formdig1 = new Form1();
            formdig1.Show();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testCaseIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bugStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bugStatusComboBox.Text == "Closed")
            {
                dateFixedDateTimePicker.Visible = true;
                dateFixedDateTimePicker.Enabled = true;
            }
            else
            {
                dateFixedDateTimePicker.Visible = false;
                dateFixedDateTimePicker.Enabled = false;
            }
        }

        private void severityComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

}
}


