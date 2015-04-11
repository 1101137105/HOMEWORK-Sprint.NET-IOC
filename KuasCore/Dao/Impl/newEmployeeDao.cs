using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
   public class newEmployeeDao : IEmployeeDao

    {

        public IList<Employee> GetAllEmployees()
        {

            List<Employee> employeeies = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "LALA";
            employee1.Name = "拉拉";
            employee1.Age = 100;
            employeeies.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = "BEAR";
            employee2.Name = "熊熊";
            employee2.Age = 10;
            employeeies.Add(employee2);

            return employeeies;
        
        }


        public Employee GetEmployeeById(string id){
            Employee employees = new Employee();
            employees.Id = "BEAR";
            employees.Name = "熊熊";
            employees.Age = 10;
            return employees;
        
        }
    }
}
