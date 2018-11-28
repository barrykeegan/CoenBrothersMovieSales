using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoenBrothersMovieSales.Models
{
    public class StaffPrivileges
    {
        public bool CanAddAdmin { get; set; }               //AdminStaff only
        public bool CanViewAdmins { get; set; }             //AdminStaff only
        public bool CanEditAdmin { get; set; }              //AdminStaff only
        public bool CanRemoveAdmin { get; set; }            //AdminStaff only
        public bool CanAddManager { get; set; }             //AdminStaff only
        public bool CanViewManagers { get; set; }           //ManagerStaff and above
        public bool CanEditManager { get; set; }            //AdminStaff only
        public bool CanRemoveManager { get; set; }          //AdminStaff only
        public bool CanAddEmployee { get; set; }            //AdminStaff only
        public bool CanViewEmployees { get; set; }          //All Staff levels
        public bool CanEditEmployee { get; set; }           //ManagerStaff and above
        public bool CanRemoveEmployee { get; set; }         //AdminStaff only
        public bool CanViewCustomers { get; set; }          //All Staff levels
        public bool CanEditCustomer { get; set; }           //ManagerStaff and above
        public bool CanRemoveCustomer { get; set; }         //ManagerStaff and above
        public bool CanViewCustomerOrders { get; set; }     //All Staff levels
        public bool CanEditCustomerOrder { get; set; }      //ManagerStaff and above
        public bool CanRemoveCustomerOrder { get; set; }    //ManagerStaff and above
        public bool CanAddMovie { get; set; }               //ManagerStaff and above
        public bool CanEditMovie { get; set; }              //All Staff levels
        public bool CanRemoveMovie { get; set; }            //ManagerStaff and above
        public bool CanAddDirector { get; set; }            //ManagerStaff and above
        public bool CanEditDirector { get; set; }           //All Staff levels
        public bool CanRemoveDirector { get; set; }         //ManagerStaff and above
        public bool CanAddActor { get; set; }               //ManagerStaff and above
        public bool CanEditActor { get; set; }              //All Staff levels
        public bool CanRemoveActor { get; set; }            //ManagerStaff and above
    }
}