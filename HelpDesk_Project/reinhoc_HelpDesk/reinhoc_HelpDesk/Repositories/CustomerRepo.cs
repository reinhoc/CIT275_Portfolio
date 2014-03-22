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
    class CustomerRepo
    {

        public List<Customer> GetCustomers()
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select CustID, CustName, CustAddress, CustState, CustZip");
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

        public Customer GetCustomer(int CustID)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select CustID, CustName, CustAddress, CustState, CustZip");
            sb.Append("From Customer");
            sb.Append("Where CustID = " + CustID);

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


        private Customer CreateCustomer(SqlDataReader dr)
        {
            var c = new Customer();
            c.CustID = (int)dr["UserID"];
            c.CustName = dr["CustName"].ToString();
            c.CustAddress = dr["CustAddress"].ToString();
            c.CustState = dr["CustState"].ToString();
            c.CustZip = (int)dr["CustZip"];
            return c;
        }
    }
}
