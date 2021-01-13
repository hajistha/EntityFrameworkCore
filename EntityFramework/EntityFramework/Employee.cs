using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework
{
    [Table("Employee")]
   internal class Employee
    {
        public int Id { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("HomePhone")]
        public string HomePhone { get; set; }
        [Column("CellPhone")]
        public string CellPhone { get; set; }



    }
}
