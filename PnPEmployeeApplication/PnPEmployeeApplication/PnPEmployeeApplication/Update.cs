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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            txtEmpNum.Text = Welcome.one.EmpNum;
            txtName.Text = Welcome.one.Name;
            txtSurname.Text = Welcome.one.Surname;
            dtDOB.Value = Welcome.one.DOB;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (var item in Welcome.employees)
            {
                if (txtEmpNum.Text == item.EmpNum)
                {
                    item.Name = txtName.Text;
                    item.Surname = txtSurname.Text;
                    item.DOB = dtDOB.Value;
                    item.calculateAge();
                }
            }

            Welcome.bs.DataSource = null;
            Welcome.bs.DataSource = Welcome.employees;
            this.Close();
        }
    }
}
