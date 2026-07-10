using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UI_Control
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //    MessageBox.Show("Checked");
            //}

            //string value = departmentComboBox.Text; 
            //departmentListBox1.Items.Add(value);

            string value = departmentComboBox.SelectedItem?.ToString();
            MessageBox.Show(value);
        }
    }
}
