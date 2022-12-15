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
    public partial class FormAdd : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public FormAdd()
        {           
            InitializeComponent();
        }

        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            sqlRepository.AddEmployee(inputFirstname.Text,inputLastname.Text, inputPhone.Text, inputEmail.Text, inputBirtday.Value);
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
