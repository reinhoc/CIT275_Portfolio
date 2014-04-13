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
    /// The CRUD operations for a CustTick
    /// </summary>
    public class CustTickRepo
    {
        /// <summary>
        /// Search for tickets by customer.
        /// </summary>
        /// <param name="custT">A CustTick parameter</param>
        /// <returns></returns>
        public List<CustTick> SearchCustTicks(CustTick custT)
        {
            List<CustTick> searchTicks = new List<CustTick>();
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select CustID, TickID ");
            sb.Append("From CustTick ");
            sb.Append("Where CustID ='").Append(custT.CustID).Append("';");

            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                CustTick custTick = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    custTick = CreateCustTick(corprdr);
                    searchTicks.Add(custTick);
                }

                corprdr.Close();

                return searchTicks;
            }
        }
        /// <summary>
        /// Adds a CustTick
        /// </summary>
        /// <param name="cust">A CustTick parameter</param>
        public void InsertCustTick(CustTick cust)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Insert Into [CustTick]");
            sb.Append(" ([CustID], [TickID])");
            sb.Append(" Values (");
            sb.Append("'").Append(cust.CustID).Append("',");
            sb.Append("'").Append(cust.TickID).Append("');");

            using (corpcn)
            {
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
            }
        }
        private CustTick CreateCustTick(SqlDataReader dr)
        {
            var c = new CustTick();
            c.CustID = (int)dr["CustID"];
            c.TickID = (int)dr["TickID"];
            return c;
        }
    }
}
