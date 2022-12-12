using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StejskalTestDB121222
{
    public partial class Form1 : Form
    {
        List<Employee> employees;
        SqlRepository sqlRepository = new SqlRepository();
        public Form1()
        {
            InitializeComponent();
            employees = sqlRepository.GetEmployees();
            RefreshGUI();
        }
        public void RefreshGUI()
        {
            listView1.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    employee.Id.ToString(),
                    employee.Firstname.ToString(),
                    employee.Lastname.ToString(),
                    employee.Phone.ToString(),
                    employee.Email.ToString(),
                    employee.Birthday.ToString("dd.MM.yyyy")
                });
                listView1.Items.Add(listViewItem);
                listView1.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = listView1.SelectedItems[0];
            var idValue = selectedRow.SubItems[0].Text;
            sqlRepository.RemoveEmployees(idValue);
            listView1.SelectedItems[0].Remove();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdd formAdd = new FormAdd();
            formAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshGUI();
        }
    }
}
