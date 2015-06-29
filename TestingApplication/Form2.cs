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
    public partial class Form2 : Form
    {
        string ids;
        
        public Form2()
        {

           
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Bug' table. You can move, or remove it, as needed.
            this.bugTableAdapter.Fill(this._BugHunter1_1DataSet.Bug);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bugadd_Click(object sender, EventArgs e)
        {
            // Form3 formDig1 = new Form3();
            Form3 formDig1 = new Form3(textBox1.Text);
            formDig1.Show();
            Close();
        }

        private void bugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BugHunter1_1DataSet);

        }

        private void bugDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.bugDataGridView.Rows[e.RowIndex];
            ids = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            //MessageBox.Show("id is " + ids);
            textBox1.Text = ids;
            //    DataGridViewRow row = (DataGridViewRow)sender;
            this.bugTableAdapter.FillBy(this._BugHunter1_1DataSet.Bug);
            
            Form3 formDig1 = new Form3(textBox1.Text);
          //  Form3 formDig1 = new Form3();
            //this.test_CaseTableAdapter.Fill(this._BugHunter1_1DataSet.Test_Case);
            formDig1.Show();
            Close();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 formdig1 = new Form1();
            formdig1.Show();
            Close();
        }

       
    }
}
