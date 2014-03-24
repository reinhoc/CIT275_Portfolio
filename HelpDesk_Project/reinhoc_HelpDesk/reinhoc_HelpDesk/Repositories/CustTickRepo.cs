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
    class CustTickRepo
    {
        public List<CustTick> GetCustTicks()
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select CustID, TickID, FixDescription ");
            sb.Append("From CustTick");

            using (corpcn)
            {
                List<CustTick> custTicks = new List<CustTick>();
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    CustTick custTick = CreateCustTick(corprdr);
                    custTicks.Add(custTick);
                }

                corprdr.Close();
                return custTicks;
            }
        }

        public CustTick GetCustTick(int CustID)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select CustID, TickID, FixDescription ");
            sb.Append("From CustTick");
            sb.Append("Where EmpID = " + CustID);

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
                }

                corprdr.Close();

                return custTick;
            }
        }

        public CustTick InsertCustomer(CustTick cust)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Insert Into [CustTick]");
            sb.Append(" ([CustID], [TickID], [FixDescription])");
            sb.Append(" Values (");
            sb.Append("'").Append(cust.CustID).Append("',");
            sb.Append("'").Append(cust.TickID).Append("',");
            sb.Append("'").Append(cust.FixDescription).Append("',");

            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                CustTick custT = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    custT = CreateCustTick(corprdr);
                }

                corprdr.Close();

                return custT;
            }
        }

        public CustTick UpdateCustomer(CustTick cust)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Update [CustTick]");
            sb.Append(" Set ");
            sb.Append("[CustID]='").Append(cust.CustID).Append("',");
            sb.Append("[TickID]='").Append(cust.TickID).Append("',");
            sb.Append("[FixDescription]='").Append(cust.FixDescription).Append("',");
            sb.Append("Where [EmpID]=").Append(cust.CustID);


            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                CustTick custT = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    custT = CreateCustTick(corprdr);
                }

                corprdr.Close();

                return custT;
            }
        }


        private CustTick CreateCustTick(SqlDataReader dr)
        {
            var c = new CustTick();
            c.CustID = (int)dr["CustID"];
            c.TickID = (int)dr["TickID"];
            c.FixDescription = dr["FixDescription"].ToString();
            return c;
        }
    }
}
