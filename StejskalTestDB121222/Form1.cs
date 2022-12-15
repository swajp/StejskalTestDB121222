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
                    employee.Email.ToString(),
                    employee.Phone.ToString(),
                    employee.Birthday.ToString("dd.MM.yyyy")
                });
                listView1.Items.Add(listViewItem);
                listView1.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Row isn't selected");
            }
            else
            {
                var selectedRow = listView1.SelectedItems[0];
                var idValue = selectedRow.SubItems[0].Text;
                sqlRepository.DeleteEmployees(idValue);
                listView1.SelectedItems[0].Remove();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdd formAdd = new FormAdd();
            formAdd.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Row isn't selected");
            }
            else
            {
                this.Hide();
                FormEdit formEdit = new FormEdit();
                formEdit.Show();
                var selectedRow = listView1.SelectedItems[0];
                var id = selectedRow.SubItems[0].Text;
                var firstname = selectedRow.SubItems[1].Text;
                var lastname = selectedRow.SubItems[2].Text;
                var phone = selectedRow.SubItems[4].Text;
                var email = selectedRow.SubItems[3].Text;
                formEdit.GetData(id, firstname, lastname, phone, email);
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current number of employees is: " + sqlRepository.GetCount());
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {

        }

        private void buttonMaximum_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinimum_Click(object sender, EventArgs e)
        {

        }
    }
}
