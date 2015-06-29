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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1  formDig1 = new Form1();
            formDig1.Show();
            Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Test_Case' table. You can move, or remove it, as needed.
            this.test_CaseTableAdapter.Fill(this._BugHunter1_1DataSet.Test_Case);
            // TODO: This line of code loads data into the '_BugHunter1_1DataSet.Bug' table. You can move, or remove it, as needed.
            this.bugTableAdapter.Fill(this._BugHunter1_1DataSet.Bug);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            testfrom1 formDig1 = new testfrom1();
            formDig1.Show();
           // Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formDig1 = new Form2();
            formDig1.Show();
            //Hide();
        }
        void oFrm2_evtFrm()
        {
            button1.Enabled = true;
        }
    }
}
