using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Control
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Checked");
            }

            //string value = departmentComboBox.SelectedItem?.ToString();
            //MessageBox.Show(value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> departmentList = new List<string>();
            
            departmentList.Add("CSE");
            departmentList.Add("EEE");
            departmentList.Add("ENG");
            departmentList.Add("BBA");
            departmentList.Add("LAW");

            foreach (var data in departmentList)
            {
                departmentComboBox.Items.Add(data);
            }

            //departmentComboBox.DataSource = departmentList;

            //departmentComboBox.Items.Add("cse");
            //departmentComboBox.Items.Add("eee");
            //departmentComboBox.Items.Add("eng");
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }
    }
}
