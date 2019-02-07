using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details
{
    class Employee
    {
        private int _id;
        private string _name;
        private string _departmentname;
        public Employee()
        {
            _id = 1;
            _name = "";
            _departmentname = "";
        }
        public Employee(int Id, string Name, string DeptName)
        {
            Id = _id;
            Name = _name;
            DeptName = _departmentname;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string DeptName { get; set; }

        public int GetId()
        {
            MethodCalled("GetId() Method called.");
            return Id;
            
        }
        public string GetName()
        {
            MethodCalled("GetName() Method called.");
            return Name;
            
        }
        public string GetDepartmentName()
        {
            MethodCalled("GetDepartmentName() Method called.");
            return DeptName; 
        }
        public event CallForDelegate MethodCalled;
  
        //Method Overloading
        public string ForUpdate(int id)
        {
            Console.WriteLine("Enter another ID:");
            string uid = Console.ReadLine();
            return uid;
        }
        public string ForUpdate(string name)
        {
            Console.WriteLine("Enter another Name:");
            string un = Console.ReadLine();
            return un;
        }
        public string ForUpdate()
        {
            Console.WriteLine("Enter another Department Name:");
            string udn = Console.ReadLine();
            return udn;
        }
    }
}
