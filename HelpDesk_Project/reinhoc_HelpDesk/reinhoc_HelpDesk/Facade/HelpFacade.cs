using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reinhoc_HelpDesk.Repositories;
using reinhoc_HelpDesk.Business_Classes;

namespace reinhoc_HelpDesk.Facade
{
    public class HelpFacade
    {
        #region [Declarations]
        //Customer creations
        CustomerRepo cR = new CustomerRepo();
        Customer c = new Customer();
        List<Customer> custsList = new List<Customer>();

        //Employee creations
        EmployeeRepo eR = new EmployeeRepo();
        Employee e = new Employee();
        List<Employee> empsList = new List<Employee>();
        #endregion

        #region [Customer Methods]
        /// <summary>
        /// Add Customer to the database
        /// </summary>
        /// <param name="cN">Customer Name</param>
        /// <param name="cA">Customer Address</param>
        /// <param name="cS">Customer State</param>
        /// <param name="cZ">Customer Zip</param>
        public void AddCustomer(string cN, string cA, string cS, int cZ)
        {            
            c.CustName = cN;
            c.CustAddress = cA;
            c.CustState = cS;
            c.CustZip = cZ;
            //Adds a Customer
            cR.InsertCustomer(c);
        }
        
        /// <summary>
        /// List of all Customer Names
        /// </summary>
        /// <returns>Customer Names are returned</returns>
        public List<string> GetCustomers()
        {            
            List<string> custsNames = new List<string>();
            custsList = cR.GetCustomers();
            foreach (var c in custsList)
            {
                custsNames.Add(c.CustName.ToString());
            }
            //Returns a list of Customer Names
            return custsNames;
        }
        
        /// <summary>
        /// Get a single customer
        /// </summary>
        /// <param name="cN">Customer Name</param>
        /// <returns></returns>
        public Customer GetCustomer(string cN)
        {
            Customer cluster = new Customer();
            foreach (Customer cust in custsList)
            {
                if (cust.CustName == cN)
                {
                    cluster = cust;
                    break;
                }
            }
            //Returns a single customer
            cluster = cR.GetCustomer(cluster);
            return cluster;
        }        
        #endregion

        #region[Employee]
        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <param name="eFN">Employee First Name</param>
        /// <param name="eLN">Employee Last Name</param>
        /// <param name="eUN">Employee User Name</param>
        public void AddEmployee(string eFN, string eLN, string eUN)
        {
            e.EmpFName = eFN;
            e.EmpLName = eLN;
            e.EmpUName = eUN;
            //Adds an Employee
            eR.InsertEmployee(e);
        }
        /// <summary>
        /// Gets all of the employees
        /// </summary>
        /// <returns>List of employee user names</returns>
        public List<string> GetEmployees()
        {
            List<string> empNames = new List<string>();
            empsList = eR.GetEmployees();
            foreach (var e in empsList)
            {
                empNames.Add(e.EmpUName.ToString());
            }

            return empNames;
        }
        /// <summary>
        /// Gets a single employee
        /// </summary>
        /// <param name="eUN">Employee User Name</param>
        /// <returns>Single Employee</returns>
        public Employee GetEmployee(string eUN)
        {
            Employee cluster = new Employee();
            foreach (Employee emp in empsList)
            {
                if (emp.EmpUName == eUN)
                {
                    cluster = emp;
                    break;
                }
            }
            cluster = eR.GetEmployee(cluster);
            return cluster;
        }
        #endregion
    }
}
