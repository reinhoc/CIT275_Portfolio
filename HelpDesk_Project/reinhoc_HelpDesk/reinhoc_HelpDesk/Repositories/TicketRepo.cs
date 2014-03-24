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
    class TicketRepo
    {
        public List<Ticket> GetTicket()
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select TickID, ProblemTitle, ProblemDescription, Severity, Completed ");
            sb.Append("From Ticket");

            using (corpcn)
            {
                List<Ticket> tickets = new List<Ticket>();
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    Ticket tick = CreateTicket(corprdr);
                    tickets.Add(tick);
                }

                corprdr.Close();
                return tickets;
            }
        }

        public Ticket GetTicket(int TickID)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select TickID, ProblemTitle, ProblemDescription, Severity, Completed ");
            sb.Append("From Ticket");
            sb.Append("Where TickID = " + TickID);

            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                Ticket tick = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    tick = CreateTicket(corprdr);
                }

                corprdr.Close();

                return tick;
            }
        }

        public Ticket InsertCustomer(Ticket tick)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Insert Into [Ticket]");
            sb.Append(" ([ProblemTitle], [ProblemDescription], [Severity], [Completed])");
            sb.Append(" Values (");
            sb.Append("'").Append(tick.ProblemTitle).Append("',");
            sb.Append("'").Append(tick.ProblemDescription).Append("',");
            sb.Append("").Append(tick.Severity).Append(",");
            sb.Append("'").Append(tick.Completed).Append("')");

            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                Ticket ticks = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    ticks = CreateTicket(corprdr);
                }

                corprdr.Close();

                return ticks;
            }
        }

        public Ticket UpdateTicket(Ticket tick)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Update [Ticket]");
            sb.Append(" Set ");
            sb.Append("[ProblemTitle]='").Append(tick.ProblemTitle).Append("',");
            sb.Append("[ProblemDescription]='").Append(tick.ProblemDescription).Append("',");
            sb.Append("[Severity]=").Append(tick.Severity).Append(",");
            sb.Append("[Completed]='").Append(tick.Completed).Append("'");
            sb.Append("Where [TickID]=").Append(tick.TickID);


            using (corpcn)
            {
                //Needed this here to be able to use the variable towards the end. Some type of scope error.
                Ticket ticks = null;

                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
                SqlDataReader corprdr = corpCmd.ExecuteReader();

                while (corprdr.Read())
                {
                    ticks = CreateTicket(corprdr);
                }

                corprdr.Close();

                return ticks;
            }
        }


        private Ticket CreateTicket(SqlDataReader dr)
        {
            var t = new Ticket();
            t.TickID = (int)dr["TickID"];
            t.ProblemTitle = dr["ProblemTitle"].ToString();
            t.ProblemDescription = dr["ProblemDescription"].ToString();
            t.Severity = (int)dr["Severity"];
            t.Completed = (bool)dr["CustZip"];
            return t;
        }
    }
}
