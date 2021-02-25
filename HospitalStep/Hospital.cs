using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStep
{
    class Hospital
    {
        public string Location { get; set; }
        public Department[] Departments { get; set; }
        public int DepartmentCount { get; set; } = 0;

        public void AddDepartment(ref Department department)
        {
            Department[] temp = new Department[++DepartmentCount];
            if (Departments != null)
            {
                Departments.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = department;
            Departments = temp;
        }

        public void Show()
        {
            Console.WriteLine($"Location:{Location}");
            foreach (var item in Departments)
            {
                item.Show();
            }
        }

    }
}
