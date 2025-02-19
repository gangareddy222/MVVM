using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Mvvm.Models;
using Mvvm.Commands;
using System.Collections.ObjectModel;

namespace Mvvm.ViewModels
{
   public class EmployeeViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
            }
        }
        #endregion

        EmployeeService Obj;
        public EmployeeViewModel()
        {
          Obj =new EmployeeService();
            LoadData();
            CurrentEmployee = new Employee();
            saveCommand = new RelayCommand(save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            
        }

        #region Display Opperation
        private ObservableCollection<Employee> employeesList;
        public ObservableCollection<Employee> EmployeesList
        {
            get { return employeesList; }
            set { employeesList = value;OnPropertyChanged("EmployeesList"); }
        }
       private void LoadData()
        {
            EmployeesList =new ObservableCollection<Employee>(Obj.GetAll());
        }
        #endregion

        private Employee currentEmployee;
        public Employee CurrentEmployee
        {
            get { return currentEmployee; }
            set { currentEmployee = value; OnPropertyChanged("CurrentEmployee"); }
        }

        private string message;
        public string  Message {
            get { return message; }
                set{ message = value;OnPropertyChanged("Message"); } 
        }
        #region SaveOperation
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand {
            get { return saveCommand; }
   
        }

        public void save()
        {
            try
            {
                var IsSaved = Obj.Add(CurrentEmployee);
                LoadData();
                if (IsSaved)
                    Message = "Employee Saved";
                else
                    Message = "Save operration failed";
            }
            catch(Exception ex)
            {
                Message= ex.Message;
            }
        }
        #endregion

        private RelayCommand searchCommand;

        #region Search operation

        public RelayCommand SearchCommand
        {
            get
            {
                return searchCommand;
            }
        }
        public void Search()
        {
            try
            {
                var ObjEmployee = Obj.Search(CurrentEmployee.ID);
                if(ObjEmployee != null)
                {
                    CurrentEmployee.Name = ObjEmployee.Name;
                    CurrentEmployee.Age = ObjEmployee.Age;
                }
                else
                {
                    Message = "Employee Not Foumnd";
                }
            }
            catch(Exception ex)
            {
                Message =ex.Message;

            }
            
        }
        #endregion

        public RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }
        public void Update()
        {
            try
            {
                var isUpdated = Obj.Update(CurrentEmployee);

                if (isUpdated)
                {
                    Message = "Employee Updated";
                    LoadData();

                }
                else
                {
                    Message = "Update Operation Failed";
                }

            }
            catch(Exception ex)
            {
                Message = ex.Message;
            }
        }




    }
}
