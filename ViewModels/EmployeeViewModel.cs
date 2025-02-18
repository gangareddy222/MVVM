using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Mvvm.Models;

namespace Mvvm.ViewModels
{
   public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
            }
        }

        EmployeeService Obj;
        public EmployeeViewModel()
        {
          Obj =new EmployeeService();
            
        }
        private List<Employee> employeesList;
        public List<Employee> EmployeesList
        {
            get { return employeesList; }
            set { employeesList = value;OnPropertyChanged("EmployeesList"); }
        }

    }
}
