﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Events.Products;
using OpenCBS.Manager.Products;

namespace OpenCBS.Manager.Events
{
    public class CurrentAccountEventManager : Manager
    {
        
        User _pUser;
        public CurrentAccountEventManager(User pUser)
            : base(pUser)
        {
            _pUser = pUser;
           
        }

        public CurrentAccountEventManager(string db)
            : base(db)
        {
           
        }



        public int SaveCurrentAccountEvent(CurrentAccountEvent currentAccountEvent)
        {

            const string q = @"INSERT INTO [CurrentAccountEvents]
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

                SetEvent(c, currentAccountEvent);

                currentAccountEvent.Id = Convert.ToInt32(c.ExecuteScalar());
            }
            return currentAccountEvent.Id;
        }


        private void SetEvent(OpenCbsCommand c, CurrentAccountEvent currentAccountEvent)
        {

            c.AddParam("@contractCode", currentAccountEvent.ContractCode);
            c.AddParam("@eventCode", currentAccountEvent.EventCode);
            c.AddParam("@description", currentAccountEvent.Description);
            c.AddParam("@creationDate", DateTime.Today.ToShortDateString());
            c.AddParam("@user_name", _pUser.Id);
            c.AddParam("@user_role", _pUser.UserRole.RoleName);
            c.AddParam("@deleted", "0");
        }


        public List<CurrentAccountEvent> FetchEvents(string contractCode)
        {
            List<CurrentAccountEvent> listEvents = new List<CurrentAccountEvent>();
            const string q =
                @"SELECT 
                    id,
contract_code,
event_code,
description,
creation_date
            FROM dbo.CurrentAccountEvents where contract_code = @contractCode";
            using (SqlConnection conn = GetConnection())
            using (OpenCbsCommand c = new OpenCbsCommand(q, conn))
            {
                c.AddParam("@contractCode", contractCode);
                using (OpenCbsReader r = c.ExecuteReader())
                {
                    if (r.Empty) return listEvents;

                    while (r.Read())
                    {
                        CurrentAccountEvent b = new CurrentAccountEvent
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
