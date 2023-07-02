using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeptandEmp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<Department> DepartmentList { get; set; }
        public List<Employee> EmployeeList
        {
            get
            {
                return employeeList;
            }
            set
            {
                employeeList = value;
                OnPropertyChanged(nameof(EmployeeList));
            }
        }

        private List<Employee> employeeList { get; set; }
        public Department SelectedDepartment
        {
            get
            {
                return selectedDepartment;
            }
            set
            {
                selectedDepartment = value;
                List<Employee> EmployeeListClone = new List<Employee>();
                foreach (var emp in EmployeeList)
                {
                    if (emp.DeptId == selectedDepartment.Id)
                    {
                        EmployeeListClone.Add(emp);
                    }
                }
                EmployeeList.Clear();
                EmployeeList = EmployeeListClone;
            }
        }
        private Department selectedDepartment { get; set; }

        public Employee SelectedEmployee { get; set; }
        private Employee selectedEmployee { get; set; }

        public MainWindowViewModel()
        {
            DepartmentList = new List<Department>();
            DepartmentList.Add(new Department() { Id = 1, DepartmentName = "IT" });
            DepartmentList.Add(new Department() { Id = 2, DepartmentName = "Accounts" });
            DepartmentList.Add(new Department() { Id = 3, DepartmentName = "Admin" });
            DepartmentList.Add(new Department() { Id = 4, DepartmentName = "Networking" });
            DepartmentList.Add(new Department() { Id = 5, DepartmentName = "Support" });

            EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee() { Id = 1, DeptId = 1, EmployeeName = "Mohan" });
            EmployeeList.Add(new Employee() { Id = 2, DeptId = 1, EmployeeName = "Rohan" });
            EmployeeList.Add(new Employee() { Id = 3, DeptId = 1, EmployeeName = "Santosh" });
            EmployeeList.Add(new Employee() { Id = 4, DeptId = 2, EmployeeName = "Kiran" });
            EmployeeList.Add(new Employee() { Id = 5, DeptId = 2, EmployeeName = "Mohini" });
            EmployeeList.Add(new Employee() { Id = 6, DeptId = 3, EmployeeName = "Sanjana" });
            EmployeeList.Add(new Employee() { Id = 7, DeptId = 4, EmployeeName = "Shreya" });
            EmployeeList.Add(new Employee() { Id = 8, DeptId = 5, EmployeeName = "Kaustubh" });
            EmployeeList.Add(new Employee() { Id = 9, DeptId = 5, EmployeeName = "Lakhan" });
            EmployeeList.Add(new Employee() { Id = 10, DeptId = 5, EmployeeName = "Ram" });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
