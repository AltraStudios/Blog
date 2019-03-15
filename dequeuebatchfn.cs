/// <summary>
/// Executes 'DequeueBatch' which is a stored procedure used to get a number of items indicated by
/// <paramref name="batchsize"/> that are at status <paramref name="oldStatus"/> and automically updates the 
/// returned result set's status column, indicated by <paramref name="statusColumnName"/> with the new status,
/// indicated by <paramref name="newStatus"/>
/// </summary>
/// <param name="tablename">The name of the table to pull from.</param>
/// <param name="batchsize">How many items do you want.</param>
/// <param name="statusColumnName">The name of the column representing status</param>
/// <param name="newStatus">The new status vlaue to be set to <paramref name="statusColumnName"/></param>
/// <param name="oldStatus">The old status value that the returned data should be matched against. This is read from the column <paramref name="statusColumnName"/></param>
/// <param name="StartDateColumnName">The name StartDate column of the table to pull from.</param>
/// <param name="whereCondition">where condition.</param>
/// <returns>A <see cref="List{T}"/> that includes the request batch of data.</returns>
public virtual  List<T> DequeBatch<T>(string tablename, int batchsize, string statusColumnName, int newStatus, int oldStatus, string StartDateColumn, string whereCondition = "", DbContext ctx = null)
{
    if (ctx == null) ctx = context;
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
