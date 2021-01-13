using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
     internal interface IEmployeeRepo
    {
        Employee Create(string FirstName,
            string LastName,
            string Address, 
            string HomePhone,
            string CellPhone);

        Employee Update(Employee employee);

        void Delete(int id);
   
    }
}
