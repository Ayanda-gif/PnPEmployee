using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PnPEmployeeApplication
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Welcome.employees.Add(new Employee(txtEmpNum.Text,txtName.Text,txtSurname.Text,dtDOB.Value));
            //Welcome.one.calculateAge
            foreach (var item in Welcome.employees)
            {
                item.calculateAge();
            }
            Welcome.bs.DataSource = null;
            Welcome.bs.DataSource = Welcome.employees;  
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
