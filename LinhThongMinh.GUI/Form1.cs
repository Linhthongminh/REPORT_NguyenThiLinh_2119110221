using LinhThongMinh.BAL.BAL;
using LinhThongMinh.DTO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhThongMinh.GUI
{
    public partial class Form1 : Form
    {
        EmployeeBAL employeeBAL = new EmployeeBAL();
        DepartmentBAL departmentBAL = new DepartmentBAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EmployeeDTO> employees = employeeBAL.ReadEmployee();
            foreach (EmployeeDTO employee in employees)
            {
                dgvEmployee.Rows.Add(employee.ID_Employee, employee.Name, employee.DateBirth, employee.Gender, employee.PlaceBirth, employee.Name_Department);
            }
            List<DepartmentDTO> departments = departmentBAL.ReadDepartmentList();
            foreach (DepartmentDTO department in departments)
            {
                cbMajor.Items.Add(department);
            }
            cbMajor.DisplayMember = "Name";
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvEmployee.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbDB.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                cbGender.Checked = Convert.ToBoolean(row.Cells[3].Value);
                tbPB.Text = dgvEmployee.Rows[idx].Cells[4].Value.ToString();
                cbMajor.Text = dgvEmployee.Rows[idx].Cells[5].Value.ToString();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Please enter the code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeDTO employee = new EmployeeDTO();
                employee.ID_Employee = tbId.Text;
                employee.Name = tbName.Text;
                employee.DateBirth = tbDB.Text;
                employee.Gender = cbGender.Checked;
                employee.PlaceBirth = tbPB.Text;
                employee.ID_Department = (DepartmentDTO)cbMajor.SelectedItem;
                employeeBAL.NewEmployee(employee);

                dgvEmployee.Rows.Add(employee.ID_Employee, employee.Name, employee.DateBirth, employee.Gender, employee.PlaceBirth, employee.ID_Department.Name);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure to Delete?", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                EmployeeDTO employee = new EmployeeDTO();
                employee.ID_Employee = tbId.Text;
                employee.Name = tbName.Text;

                employeeBAL.DeleteEmployee(employee);

                int idx = dgvEmployee.CurrentCell.RowIndex;
                dgvEmployee.Rows.RemoveAt(idx);
            }
            
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Please enter the code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow row = dgvEmployee.CurrentRow;
                if (row != null)
                {
                    EmployeeDTO employee = new EmployeeDTO();
                    employee.ID_Employee = tbId.Text;
                    employee.Name = tbName.Text;
                    employee.DateBirth = tbDB.Text;
                    employee.Gender = cbGender.Checked;
                    employee.PlaceBirth = tbPB.Text;
                    employee.ID_Department = (DepartmentDTO)cbMajor.SelectedItem;

                    row.Cells[0].Value = employee.ID_Employee;
                    row.Cells[1].Value = employee.Name;
                    row.Cells[2].Value = employee.DateBirth;
                    row.Cells[3].Value = employee.Gender;
                    row.Cells[4].Value = employee.PlaceBirth;
                    row.Cells[5].Value = employee.Name_Department;
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure to exit?", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
