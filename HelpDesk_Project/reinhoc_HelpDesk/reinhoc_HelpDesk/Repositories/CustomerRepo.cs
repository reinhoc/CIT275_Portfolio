using System;
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
    /// The CRUD operations for a Customer
    /// </summary>
    public class CustomerRepo
    {
        /// <summary>
        /// Get a list of all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select CustID, CustName, CustAddress, CustState, CustZip ");
            sb.Append("From Customer");

            using (corpcn)
            {
                List<Customer> customers = new List<Customer>();
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();
                
                while (corprdr.Read())
                {
                    Customer cust = CreateCustomer(corprdr);
                    customers.Add(cust);
                }

                corprdr.Close();
                return customers;
            }
        }

        /// <summary>
        /// Get a single customer
        /// </summary>
        /// <param name="cust">Customer parameter</param>
        /// <returns></returns>
        public Customer GetCustomer(Customer cust)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select CustID, CustName, CustAddress, CustState, CustZip ");
            sb.Append("From Customer Where CustID = '").Append(cust.CustID).Append("'");
            sb.Append(";");

            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                Customer customer = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    customer = CreateCustomer(corprdr);
                }

                corprdr.Close();

                return customer;
            }
        }

        /// <summary>
        /// Add a customer
        /// </summary>
        /// <param name="cust">Customer Property</param>
        public void InsertCustomer(Customer cust)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Insert Into [Customer]");
            sb.Append(" ([CustName], [CustAddress], [CustState], [CustZip])");
            sb.Append(" Values (");
            sb.Append("'").Append(cust.CustName).Append("',");
            sb.Append("'").Append(cust.CustAddress).Append("',");
            sb.Append("'").Append(cust.CustState).Append("',");
            sb.Append("'").Append(cust.CustZip).Append("')");

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
        /// Update Customer
        /// </summary>
        /// <param name="cust">Customer Parameter</param>
        public void UpdateCustomer(Customer cust)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Update [Customer]");
            sb.Append(" Set ");
            sb.Append("[CustName]='").Append(cust.CustName).Append("',");
            sb.Append("[CustAddress]='").Append(cust.CustAddress).Append("',");
            sb.Append("[CustState]='").Append(cust.CustState).Append("',");
            sb.Append("[CustZip]='").Append(cust.CustZip).Append("'");
            sb.Append("Where [CustID]=").Append(cust.CustID);


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
        /// Creates an internal customer
        /// </summary>
        /// <param name="dr">SQL Data Reader</param>
        /// <returns></returns>
        private Customer CreateCustomer(SqlDataReader dr)
        {
            var c = new Customer();
            c.CustID = (int)dr["CustID"];
            c.CustName = dr["CustName"].ToString();
            c.CustAddress = dr["CustAddress"].ToString();
            c.CustState = dr["CustState"].ToString();
            c.CustZip = (int)dr["CustZip"];
            return c;
        }
    }
}
