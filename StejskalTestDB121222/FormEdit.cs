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
    public partial class FormEdit : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        Form1 form1 = new Form1();

        public FormEdit()
        {
            InitializeComponent();
        }
        public void GetData(string id,string firstname, string lastname,string phone, string email)
        {
            labelId.Text = "ID:" + id;
            inputFirstname.Text = firstname;
            inputLastname.Text = lastname;
            inputPhone.Text = phone;
            inputEmail.Text = email;
        }
        private void buttonEditData_Click(object sender, EventArgs e)
        {
            sqlRepository.AddEmployee(inputFirstname.Text, inputLastname.Text, inputPhone.Text, inputEmail.Text);
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
