﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
   internal class EmployeeProvider : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeProvider(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }
        public Employee Get(int id)
        {
            
            return employeeContext.Employee.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
