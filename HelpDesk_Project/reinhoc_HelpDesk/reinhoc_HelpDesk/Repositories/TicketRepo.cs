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
    /// The CRUD operations for a Ticket
    /// </summary>
    public class TicketRepo
    {
        public List<Ticket> GetTickets()
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select TickID, ProblemTitle, ProblemDescription, Severity, Completed, FixDescription ");
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

        public Ticket GetTicket(Ticket ticket)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Select TickID, ProblemTitle, ProblemDescription, Severity, Completed, FixDescription ");
            sb.Append("From Ticket ");
            sb.Append("Where TickID = '").Append(ticket.TickID).Append("';");

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

        public void InsertTicket(Ticket tick)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Insert Into [Ticket]");
            sb.Append(" ([ProblemTitle], [ProblemDescription], [Severity], [Completed], [FixDescription])");
            sb.Append(" Values (");
            sb.Append("'").Append(tick.ProblemTitle).Append("',");
            sb.Append("'").Append(tick.ProblemDescription).Append("',");
            sb.Append("'").Append(tick.Severity).Append("',");
            sb.Append("'").Append(tick.Completed).Append("',");
            sb.Append("'").Append(tick.FixDescription).Append("');");

            using (corpcn)
            {
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
            }
        }

        public void UpdateTicket(Ticket tick)
        {
            SqlConnection corpcn = new SqlConnection(Settings.Default.cnHelpDesk);

            var sb = new StringBuilder();
            sb.Append("Update [Ticket]");
            sb.Append(" Set ");
            sb.Append("[ProblemTitle]='").Append(tick.ProblemTitle).Append("',");
            sb.Append("[ProblemDescription]='").Append(tick.ProblemDescription).Append("',");
            sb.Append("[Severity]=").Append(tick.Severity).Append(",");
            sb.Append("[Completed]='").Append(tick.Completed).Append("',");
            sb.Append("[FixDescription]='").Append(tick.FixDescription).Append("'");
            sb.Append("Where [TickID]=").Append(tick.TickID);


            using (corpcn)
            {
                SqlCommand corpCmd = corpcn.CreateCommand();
                corpCmd.CommandType = CommandType.Text;
                corpCmd.CommandText = sb.ToString();
                corpcn.Open();
                corpCmd.ExecuteNonQuery();
            }
        }

        private Ticket CreateTicket(SqlDataReader dr)
        {
            var t = new Ticket();
            t.TickID = (int)dr["TickID"];
            t.ProblemTitle = dr["ProblemTitle"].ToString();
            t.ProblemDescription = dr["ProblemDescription"].ToString();
            t.Severity = (int)dr["Severity"];
            t.Completed = (bool)dr["Completed"];
            t.FixDescription = dr["FixDescription"].ToString();
            return t;
        }
    }
}
