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
   
    public partial class Welcome : Form
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmpNum = "E05",Name = "Susan" , Surname = "Doe", DOB = Convert.ToDateTime("1999/09/07")},
            new Employee(){EmpNum = "E03",Name = "James" , Surname = "Cotzee", DOB = Convert.ToDateTime("2000/09/07")}

        };
        public static BindingSource bs = new BindingSource();

        public static Employee one = new Employee();
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            // Use IComparable to implement the CompareTo method so that you can sort using Name
            //employees.Sort();
            foreach (var item in employees)
            {
                item.calculateAge();
            }
            bs.DataSource = employees;
            dgvEmployees.DataSource = bs;
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            Employee selection = (Employee)bs.Current;
            if (selection != null)
            {
                txtEmpNum.Text = selection.EmpNum;  
            }
            //Search 
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (var item in employees)
            {
                if (txtEmpNum.Text == item.EmpNum)
                {
                    one.EmpNum = item.EmpNum;
                    one.Name = item.Name;
                    one.Surname = item.Surname;
                    one.DOB = Convert.ToDateTime(item.DOB);
                    Update updateForm = new Update();
                    updateForm.ShowDialog();
                }
            }
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}
