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
        private void RefreshGUI()
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
            }
        }
    }
}
