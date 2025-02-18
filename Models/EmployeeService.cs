using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Models
{
    public class EmployeeService
    {
        private static List<Employee> EmployeeList;
        public EmployeeService() {
            EmployeeList = new List<Employee>()
            {
              new Employee{ID=101,Name="Ganga",Age=25}
            };
        
        }

        public List<Employee> GetAll()
        {
            return EmployeeList;
        }

        public bool Add(Employee Emp)
        {
            if (Emp.Age < 21 || Emp.Age > 58)
                throw new ArgumentException("Invalid age limit for employee");
            EmployeeList.Add(Emp);
            return true;

        }

        public bool Update(Employee EmployeeToUpdate)
        {
            bool IsUpdtaed = false;
            for(int index=0; index < EmployeeList.Count; index++)
            {
                if (EmployeeList[index].ID == EmployeeToUpdate.ID)
                {
                    EmployeeList[index].Name=EmployeeToUpdate.Name;
                    EmployeeList[index].Age = EmployeeToUpdate.Age;

                     IsUpdtaed = true;
                }
            }

            return IsUpdtaed;
        }

        public bool Delete(int id)
        {
            bool isDeleted = false;
            for(int i=0; i<EmployeeList.Count; i++)
            {
                if (EmployeeList[i].ID == id)
                {
                    isDeleted = true;
                    break;
                }
            }
            return isDeleted;
        }

        public Employee Search(int id)
        {
            return EmployeeList.FirstOrDefault(e => e.ID == id);
        }
    }
}
