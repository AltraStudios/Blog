using Hangfire;
using Hangfire.SqlServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireWithDequeueBatch
{
    class Dequeue
    {
        public void Init()
        {
            var sqlServerStorageOptions = new Hangfire.SqlServer.SqlServerStorageOptions { SchemaName = "QueuingBackgroundJobs" };
            //GlobalConfiguration.Configuration
            //    .UseSqlServerStorage("testEntities", sqlServerStorageOptions);
            JobStorage.Current = new SqlServerStorage("testEntities", sqlServerStorageOptions);
            RecurringJob.AddOrUpdate("Call API",
                    () => CallAPI(),
                    Cron.Minutely,
                    queue: "callapiqueue");
        }

        public void CallAPI()
        {
            var calls = DequeBatch<QueuingTable>("QueuingTable", 10, "Status", 2, 1, "APICallStartDate");
            /*
             * API Calls Logic
             */
        }

        public List<T> DequeBatch<T>(string tablename, int batchsize, string statusColumnName, int newStatus, int oldStatus, string StartDateColumn, string whereCondition = "", testEntities ctx = null)
        {
            var parTablename = new SqlParameter("@Tablename", tablename);
            var parColumnname = new SqlParameter("@Columnname", statusColumnName);
            var parStartDateColumnName = new SqlParameter("@StartDateColumnName", StartDateColumn);
            var parBatchSize = new SqlParameter("@BatchSize", batchsize);
            var parNewStatus = new SqlParameter("@NewStatus", newStatus);
            var parOldStatus = new SqlParameter("@OldStatus", oldStatus);
            var parwhere = new SqlParameter("@where", whereCondition);
            var query = ctx.Database.SqlQuery<T>("EXEC [DequeueBatch] @Tablename,@Columnname,@StartDateColumnName,@where ,@BatchSize,@NewStatus,@OldStatus", parTablename, parColumnname, parStartDateColumnName, parwhere, parBatchSize, parNewStatus, parOldStatus);
            return query.ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dequeue dequeue = new Dequeue();
            dequeue.Init();

            Console.WriteLine();
        }
    }
}
