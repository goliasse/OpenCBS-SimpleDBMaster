using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Events.Products;
using OpenCBS.Manager.Products;
namespace OpenCBS.Manager.Events
{
    public class FixedDepositEventManager : Manager
    {
        

		public FixedDepositEventManager(User pUser) : base(pUser)
		{
            
		}

        public FixedDepositEventManager(string db)
            : base(db)
		{
            
		}


        public int SaveFixedDepositEvent(FixedDepositEvent fixedDepositEvent)
        {

            const string q = @"INSERT INTO [FixedDepositEvents]
            ( 
            [contract_code],
            [event_code],
            [description],
            [creation_date],
            [user_name],
            [user_role],
            [deleted]
            )
            VALUES
            (
            @contractCode,
            @eventCode,
            @description,
            @creationDate,
            @user_name,
            @user_role,
            @deleted
            )
                SELECT SCOPE_IDENTITY()";


            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {

                SetEvent(c, fixedDepositEvent);

                fixedDepositEvent.Id = Convert.ToInt32(c.ExecuteScalar());
            }
            return fixedDepositEvent.Id;
        }


        private static void SetEvent(OpenCbsCommand c, FixedDepositEvent fixedDepositEvent)
        {

            c.AddParam("@contractCode", fixedDepositEvent.ContractCode);
            c.AddParam("@eventCode", fixedDepositEvent.EventCode);
            c.AddParam("@description", fixedDepositEvent.Description);
            c.AddParam("@creationDate", DateTime.Today.ToShortDateString());
            c.AddParam("@user_name", fixedDepositEvent.UserName);
            c.AddParam("@user_role", fixedDepositEvent.UserRole.RoleName);
            c.AddParam("@deleted", fixedDepositEvent.Deleted);
        }


        public List<FixedDepositEvent> FetchEvents(string contractCode)
        {
            List<FixedDepositEvent> listEvents = new List<FixedDepositEvent>();
            const string q =
                @"SELECT 
                    id,
contract_code,
event_code,
description,
creation_date
            FROM dbo.FixedDepositEvents where contract_code = @contractCode";
            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@contractCode", contractCode);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r.Empty) return listEvents;

                    while (r.Read())
                    {
                        FixedDepositEvent b = new FixedDepositEvent
                        {
                            Id = r.GetInt("id")
                            ,
                            ContractCode = r.GetString("contract_code")
                            ,
                            EventCode = r.GetString("event_code")
                            ,
                            Description = r.GetString("description")
                            ,
                            CreationDate = r.GetDateTime("creation_date")

                        };
                        listEvents.Add(b);
                    }
                }
            }
            return listEvents;
        }
        
    }
}
