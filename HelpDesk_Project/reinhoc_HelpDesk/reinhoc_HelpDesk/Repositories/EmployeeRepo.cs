﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using reinhoc_HelpDesk.Properties;
using reinhoc_HelpDesk.Business_Classes;

namespace reinhoc_HelpDesk.Repositories
{
    /// <summary>
    /// The CRUD operations for an Employee
    /// </summary>
    public class EmployeeRepo
    {
        /// <summary>
        /// Gets a list of all employees
        /// </summary>
        /// <returns>List of Employees</returns>
        public List<Employee> GetEmployees()
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select EmpID, EmpFName, EmpLName, EmpUName ");
            sb.Append("From Employee");

            using (corpcn)
            {
                List<Employee> employees = new List<Employee>();
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    Employee emp = CreateEmployee(corprdr);
                    employees.Add(emp);
                }

                corprdr.Close();
                return employees;
            }
        }

        /// <summary>
        /// Gets a single employee
        /// </summary>
        /// <param name="Emp">Employee parameter</param>
        /// <returns>Returns a single employee</returns>
        public Employee GetEmployee(Employee Emp)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select EmpID, EmpFName, EmpLName, EmpUName ");
            sb.Append("From Employee ");
            sb.Append("Where EmpID = '").Append(Emp.EmpID).Append("'");

            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                Employee employee = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    employee = CreateEmployee(corprdr);
                }

                corprdr.Close();

                return employee;
            }
        }
        /// <summary>
        /// Adds an employee
        /// </summary>
        /// <param name="emp">Employee parameter</param>
        public void InsertEmployee(Employee emp)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Insert Into [Employee]");
            sb.Append(" ([EmpFName], [EmpLName], [EmpUName])");
            sb.Append(" Values (");
            sb.Append("'").Append(emp.EmpFName).Append("',");
            sb.Append("'").Append(emp.EmpLName).Append("',");
            sb.Append("'").Append(emp.EmpUName).Append("')");

            using (corpcn)
            {
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Updates an existing employee
        /// </summary>
        /// <param name="emp">Employee parameter</param>
        public void UpdateEmployee(Employee emp)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Update [Employee]");
            sb.Append(" Set ");
            sb.Append("[EmpFName]='").Append(emp.EmpFName).Append("',");
            sb.Append("[EmpLName]='").Append(emp.EmpLName).Append("',");
            sb.Append("[EmpUName]='").Append(emp.EmpUName).Append("'");
            sb.Append("Where [EmpID]='").Append(emp.EmpID).Append("';");


            using (corpcn)
            {
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Creates an internal employee
        /// </summary>
        /// <param name="dr">SQL Data Reader</param>
        /// <returns>Employee</returns>
        private Employee CreateEmployee(SqlDataReader dr)
        {
            var e = new Employee();
            e.EmpID = (int)dr["EmpID"];
            e.EmpFName = dr["EmpFName"].ToString();
            e.EmpLName = dr["EmpLName"].ToString();
            e.EmpUName = dr["EmpUName"].ToString();
            return e;
        }
    }
}
