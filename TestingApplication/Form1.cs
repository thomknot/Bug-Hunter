using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestingApplication
{
    public partial class Form1 : Form
    {

        String log; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.User' table. You can move, or remove it, as needed.
           this.userTableAdapter.Fill(this._BugHunter1_1DataSet.User);

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            log = Usertext.Text;
            this.userTableAdapter.FillBy11(this._BugHunter1_1DataSet.User, @LoginID);
            //Form2 formDig1 = new Form2();
            //testfrom1 formDig1 = new testfrom1();
            //formDig1.Show();
            //Hide();
           // MessageBox.Show(log +"Ok"+ LoginID );

            if (Passtext.Text == loginPasswordTextBox.Text)
            {
                if(Passtext.Text==passchecktext.Text)
                {
                    MessageBox.Show("Enter Password");
                }
                else
                {
                    if (designationIDTextBox.Text == "developer")
                    {
                        //Form3 formDig1 = new Form3();
                        //Form3 formDig1 = new Form3(textBox1.Text);
                          Form2 formDig1 = new Form2();
                        formDig1.Show();
                        Hide();
                    }
                    else
                        if (designationIDTextBox.Text == "tester")
                        {
                           // Form5 formDig1 = new Form5(textBox1.Text);
                            testfrom1 formDig1 = new testfrom1();
                            formDig1.Show();
                            Hide();
                        }
                        else
                        {
                            Form6 formDig1 = new Form6();
                            formDig1.Show();
                            Hide();
                        }
                }
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
            }
            
        }

     
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact Administrator");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BugHunter1_1DataSet);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.userTableAdapter.FillBy1(this._BugHunter1_1DataSet.User, loginIDToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }


        public string LoginID
        {
            get { return log; }
            set { }
        }
    }
}
