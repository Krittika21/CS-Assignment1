using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.MethodCalled += new CallForDelegate(MethodCall);

            Console.WriteLine("\nEnter the Id of the Employee: ");
            emp.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee ID is: " + emp.GetId());

            Console.WriteLine("\nEnter the name of the employee: ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Name of the Employee is: " + emp.GetName());

            Console.WriteLine("\nEnter the department of Employee: ");
            emp.DeptName = Console.ReadLine();
            Console.WriteLine("The Department of the Employee is: " + emp.GetDepartmentName());
            Console.WriteLine("10 for Id, 20 for name and 30 for department name \n Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 10:
                    string ret = emp.ForUpdate(emp.Id);
                    Console.WriteLine("The updated Id is: "+ret);
                    break;
                case 20:
                    string ret1 = emp.ForUpdate(emp.Name);
                    Console.WriteLine("the updated name is :"+ret1);
                    break;
                case 30:
                    string ret2 = emp.ForUpdate(emp.DeptName);
                    Console.WriteLine("The updated Department Name is: "+ret2);
                    break;
                default:
                    Console.WriteLine("Wrong Choise");
                    break;
            }
        }
        static void MethodCall(string value)
        {
            Console.WriteLine(value);
        }
    }
}
