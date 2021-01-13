using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeRepo(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Create(string FirstName, string LastName, string Address, string HomePhone, string CellPhone)
        {
            var response = employeeContext.Add(new Employee
            {
                FirstName = FirstName,
                LastName = LastName,
                Address = Address,
                HomePhone = HomePhone,
                CellPhone = CellPhone
            });
            employeeContext.SaveChanges();
            return response.Entity;

         }

        public void Delete(Employee employee)
        {
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employee)
        {
            var response = employeeContext.Update(employee);
            employeeContext.SaveChanges();
            return response.Entity;
        }
    }
}
