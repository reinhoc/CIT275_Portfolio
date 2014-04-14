using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reinhoc_HelpDesk.Repositories;
using reinhoc_HelpDesk.Business_Classes;

namespace reinhoc_HelpDesk.Facade
{
    /// <summary>
    /// The Help Desk Facade that joins all of the Repo's into one easy to manage class.
    /// </summary>
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

        //Ticket creations
        TicketRepo tR = new TicketRepo();
        Ticket t = new Ticket();
        List<Ticket> ticksList = new List<Ticket>();

        //CustTick creations
        CustTickRepo ctR = new CustTickRepo();
        CustTick cT = new CustTick();
        List<CustTick> ctsList = new List<CustTick>();

        //EmpTick creations
        EmpTickRepo etR = new EmpTickRepo();
        EmpTick eT = new EmpTick();
        List<EmpTick> etsList = new List<EmpTick>();
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
        /// <returns>Returns a single customer</returns>
        public Tuple<int, string, string, string, int> GetCustomer(string cN)
        {
            Customer cluster = new Customer();
            foreach (Customer cust in custsList)
            {
                if (cust.CustName == cN)
                {
                    cluster = cust;
                }
            }            
            cluster = cR.GetCustomer(cluster);
            //Returns a single customer
            return new Tuple<int,string,string,string,int>(cluster.CustID, cluster.CustName, cluster.CustAddress, cluster.CustState, cluster.CustZip);
        }
        /// <summary>
        /// Get a Customer by it's ID
        /// </summary>
        /// <param name="cID">Customer ID</param>
        /// <returns>Customer</returns>
        public Tuple<int, string, string, string, int> GetCustomerByID(int cID)
        {
            Customer cluster = new Customer();
            foreach (Customer cust in custsList)
            {
                if (cust.CustID == cID)
                {
                    cluster = cust;
                }
            }
            cluster = cR.GetCustomer(cluster);
            //Returns a single customer
            return new Tuple<int, string, string, string, int>(cluster.CustID, cluster.CustName, cluster.CustAddress, cluster.CustState, cluster.CustZip);
        }
        #endregion

        #region[Employee Methods]
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
        public Tuple<int, string, string, string> GetEmployee(string eUN)
        {
            Employee cluster = new Employee();
            foreach (Employee emp in empsList)
            {
                if (emp.EmpUName == eUN)
                {
                    cluster = emp;
                }
            }
            cluster = eR.GetEmployee(cluster);
            //Tuples allow returning multiple values back to the caller of a method. http://msdn.microsoft.com/en-us/library/dd268536(v=vs.110).aspx
            return new Tuple<int,string,string,string>(cluster.EmpID, cluster.EmpFName, cluster.EmpLName, cluster.EmpUName);
        }
        public int GetEmployeeByID(int eID)
        {
            Employee cluster = new Employee();
            foreach (Employee emp in empsList)
            {
                if (emp.EmpID == eID)
                {
                    cluster = emp;
                }
            }
            cluster = eR.GetEmployee(cluster);
            //Tuples allow returning multiple values back to the caller of a method. http://msdn.microsoft.com/en-us/library/dd268536(v=vs.110).aspx
            return cluster.EmpID;
        }
        #endregion

        #region [Ticket Methods]
        /// <summary>
        /// Adds a ticket to the database
        /// </summary>
        /// <param name="pT">Title of the problem</param>
        /// <param name="pD">Description of the problem</param>
        /// <param name="tS">Severity of the problem</param>
        /// <param name="tC">Is the problem completed?</param>
        /// <param name="tFD">The description of the fix</param>
        public void AddTicket(string pT, string pD, int tS, bool tC, string tFD)
        {
            t.ProblemTitle = pT;
            t.ProblemDescription = pD;
            t.Severity = tS;
            t.Completed = tC;
            t.FixDescription = tFD;
            //Adds a ticket
            tR.InsertTicket(t);
        }
        /// <summary>
        /// Updates a ticket in the database
        /// </summary>
        /// <param name="tI">ID of the ticket</param>
        /// <param name="pT">Title of the problem</param>
        /// <param name="pD">Description of the problem</param>
        /// <param name="tS">Severity of the problem</param>
        /// <param name="tC">Is the problem completed?</param>
        /// <param name="tFD">The description of the fix</param>
        public void UpdateTicket(int tI, string pT, string pD, int tS, bool tC, string tFD)
        {
            t.TickID = tI;
            t.ProblemTitle = pT;
            t.ProblemDescription = pD;
            t.Severity = tS;
            t.Completed = tC;
            t.FixDescription = tFD;
            //Adds a ticket
            tR.UpdateTicket(t);
        }
        /// <summary>
        /// Gets a list of TicketIDs from all Tickets
        /// </summary>
        /// <returns>A list of TicketIDs</returns>
        public List<int> GetTickets()
        {
            List<int> ticksIDs = new List<int>();
            ticksList = tR.GetTickets();
            foreach (var t in ticksList)
            {
                ticksIDs.Add(t.TickID);
            }
            //Returns a list of Ticket IDs
            return ticksIDs;
        }
        /// <summary>
        /// Gets a single ticket
        /// </summary>
        /// <param name="tI">TicketID</param>
        /// <returns>Returns a single ticket</returns>
        public Tuple<int, string, string, int, bool, string> GetTicket(int tID)
        {
            Ticket t1 = new Ticket();
            foreach (Ticket tItems in ticksList)
            {
                if (tItems.TickID == tID)
                {
                    t1 = tItems;
                }
            }
            t1 = tR.GetTicket(t1);
            //Returns a single ticket
            return new Tuple<int, string, string, int, bool, string>(t1.TickID, t1.ProblemTitle, t1.ProblemDescription, t1.Severity, t1.Completed, t1.FixDescription);
        }
        #endregion

        #region[CustTick Methods]
        /// <summary>
        /// Gathers a list of CustTicks
        /// </summary>
        private void ListCustTicks()
        {
            ctsList = ctR.ListCustTicks();
        }
        /// <summary>
        /// Add a CustTick to the database
        /// </summary>
        /// <param name="cID">Customer ID</param>
        /// <param name="tID">Ticket ID</param>
        public void AddCustTick(int cID, int tID)
        {
            cT.CustID = cID;
            cT.TickID = tID;
            //Adds a CustTick
            ctR.InsertCustTick(cT);
        }
        /// <summary>
        /// Searches for a list of tickets by customer
        /// </summary>
        /// <param name="cI">Customer ID</param>
        /// <returns></returns>
        public List<int> SearchCustTicks(int cI)
        {
            ListCustTicks();
            List<int> custTickList = new List<int>();
            CustTick c1 = new CustTick();
            foreach (CustTick custT in ctsList)
            {
                if (custT.CustID == cI)
                {
                    custTickList.Add(custT.TickID);
                }
            }
            //Returns the list of Tickets
            return custTickList;
        }
        /// <summary>
        /// Search for the customer of the ticket
        /// </summary>
        /// <param name="tI">Ticket ID</param>
        /// <returns></returns>
        public int SearchForCust(int tI)
        {
            int custID = 0;
            ListCustTicks();
            CustTick c1 = new CustTick();
            foreach (CustTick custT in ctsList)
            {
                if (custT.TickID == tI)
                {
                    custID = custT.CustID;
                }
            }
            //Returns the list of Tickets
            return custID;
        }
        #endregion

        #region [EmpTick Methods]
        private void ListEmpTicks()
        {
            etsList = etR.ListEmpTicks();
        }
        /// <summary>
        /// Adds an EmpTick to the database
        /// </summary>
        /// <param name="eID">Employee ID</param>
        /// <param name="tID">Ticket ID</param>
        public void AddEmpTick(int eID, int tID)
        {
            eT.EmpID = eID;
            eT.TickID = tID;
            //Adds an EmpTick
            etR.InsertEmpTick(eT);
        }
        /// <summary>
        /// Searchs for a list of tickets by employee
        /// </summary>
        /// <param name="empID">Employee ID</param>
        /// <returns></returns>
        public List<int> SearchEmpTicks(int empID)
        {
            ListEmpTicks();
            List<int> empTickList = new List<int>();
            EmpTick e1 = new EmpTick();
            foreach (EmpTick empT in etsList)
            {
                if (empT.EmpID == empID)
                {
                    empTickList.Add(empT.EmpID);
                }
            }
            //Returns the list of Tickets
            return empTickList;
        }
        public int SearchForEmp(int tickID)
        {
            int employeeID = 0;
            ListEmpTicks();            
            EmpTick e1 = new EmpTick();
            foreach (EmpTick empT in etsList)
            {
                if (empT.TickID == tickID)
                {
                    employeeID = empT.EmpID;
                }
            }
            //Returns the list of Tickets
            return employeeID;
        }
        #endregion
    }
}
