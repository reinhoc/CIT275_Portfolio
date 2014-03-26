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
    class EmpTickRepo
    {

        public List<EmpTick> GetEmpTicks()
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

        public EmpTick GetEmpTick(EmpTick empTTick)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select EmpID, TickID ");
            sb.Append("From EmpTick ");
            sb.Append("Where EmpID = '").Append(empTTick.EmpID).Append("'");
            sb.Append("and TickID= '").Append(empTTick.TickID).Append("';");

            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                EmpTick empTick = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    empTick = CreateEmpTick(corprdr);
                }

                corprdr.Close();

                return empTick;
            }
        }

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

        //public void UpdateCustomer(EmpTick emp)
        //{
        //    SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

        //    var sb = new StringBuilder();
        //    sb.Append("Update [EmpTick]");
        //    sb.Append(" Set ");
        //    sb.Append("[EmpID]='").Append(emp.EmpID).Append("',");
        //    sb.Append("[TickID]='").Append(emp.TickID).Append("'");
        //    sb.Append("Where [EmpID]='").Append(emp.EmpID).Append("'");
        //    sb.Append("and [TickID]=").Append(emp.TickID).Append("';");


        //    using (corpcn)
        //    {
        //        SqlCommand corpCmd = corpcn.CreateCommand();
        //        corpCmd.CommandType = CommandType.Text;
        //        corpCmd.CommandText = sb.ToString();
        //        corpcn.Open();
        //        corpCmd.ExecuteNonQuery();
        //    }
        //}


        private EmpTick CreateEmpTick(SqlDataReader dr)
        {
            var e = new EmpTick();
            e.EmpID = (int)dr["EmpID"];
            e.TickID = (int)dr["TickID"];
            return e;
        }
    }
}
