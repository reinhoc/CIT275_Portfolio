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
    /// The CRUD operations for an EmpTick
    /// </summary>
    public class EmpTickRepo
    {
        /// <summary>
        /// Gets the list of EmpTicks
        /// </summary>
        /// <returns>Returns a list of EmpTicks</returns>
        public List<EmpTick> ListEmpTicks()
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select EmpID, TickID ");
            sb.Append("From EmpTick");

            using (corpcn)
            {
                List<EmpTick> empTicks = new List<EmpTick>();
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    EmpTick empTick = CreateEmpTick(corprdr);
                    empTicks.Add(empTick);
                }

                corprdr.Close();
                return empTicks;
            }
        }
        /// <summary>
        /// Search for tickets by employee
        /// </summary>
        /// <param name="empT">An EmpTick parameter</param>
        /// <returns></returns>
        public List<EmpTick> SearchEmpTicks(EmpTick empT)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select EmpID, TickID ");
            sb.Append("From EmpTick ");
            sb.Append("Where EmpID ='").Append(empT.EmpID).Append("';");

            using (corpcn)
            {
                List<EmpTick> empTicks = new List<EmpTick>();
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    EmpTick empTick = CreateEmpTick(corprdr);
                    empTicks.Add(empTick);
                }

                corprdr.Close();
                return empTicks;
            }
        }
        /// <summary>
        /// Add a EmpTick
        /// </summary>
        /// <param name="emp">An EmpTick parameter</param>
        public void InsertEmpTick(EmpTick emp)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Insert Into [EmpTick]");
            sb.Append(" ([EmpID], [TickID])");
            sb.Append(" Values (");
            sb.Append("'").Append(emp.EmpID).Append("',");
            sb.Append("'").Append(emp.TickID).Append("');");

            using (corpcn)
            {
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
            }
        }
        private EmpTick CreateEmpTick(SqlDataReader dr)
        {
            var e = new EmpTick();
            e.EmpID = (int)dr["EmpID"];
            e.TickID = (int)dr["TickID"];
            return e;
        }
    }
}
