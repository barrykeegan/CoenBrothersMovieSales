using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoenBrothersMovieSales.Models
{
    public enum StaffLevelEnum
    {
        AdminStaff,
        ManagerStaff,
        EmployeeStaff
    }

    public class Staff
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public StaffLevelEnum Level { get; set; }
        public StaffPriveleges Privileges { get; set; } 
    }
}