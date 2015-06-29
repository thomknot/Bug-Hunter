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
    public partial class testfrom1 : Form
    {
        String id;
        public testfrom1()
        {
            InitializeComponent();
            
        }

        private void test_SuiteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
            this.tableAdapterManager.UpdateAll(this._BugHunter1_1DataSet);

        }

        private void testfrom1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Test_Case' table. You can move, or remove it, as needed.
            this.test_CaseTableAdapter.Fill(this._BugHunter1_1DataSet.Test_Case);
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Test_Case' table. You can move, or remove it, as needed.
           // this.test_CaseTableAdapter.Fill(this._BugHunter1_1DataSet.Test_Case);
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Test_Suite' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 formDig1 = new Form5(textBox1.Text);
            formDig1.Show();
            Close();

        }

        private void test_CaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to add a bug to the existing Test Case?", "Bug Hunter", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form3 formDig1 = new Form3(textBox2.Text);
               // Form3 formDig1 = new Form3();
                formDig1.Show();
            }
            else 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.test_CaseDataGridView.Rows[e.RowIndex];
                id = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
               // MessageBox.Show("id is " + id);
                textBox1.Text = id;
                //    DataGridViewRow row = (DataGridViewRow)sender;
                this.test_CaseTableAdapter.FillBy(this._BugHunter1_1DataSet.Test_Case,15 );

                Form5 formDig1 = new Form5(textBox1.Text);

                //this.test_CaseTableAdapter.Fill(this._BugHunter1_1DataSet.Test_Case);
                formDig1.Show();
                Close();
            }
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formdig1 = new Form1();
            formdig1.Show();
            Close();
        }

        public int TestCaseID { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formdig1 = new Form2();
            formdig1.Show();

        }
    }
}
