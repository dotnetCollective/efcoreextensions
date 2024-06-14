using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace EfCore.Extensions.Tests
{ 
public class SuppressConnectionInterceptor : DbConnectionInterceptor
{
    public override ValueTask<InterceptionResult> ConnectionOpeningAsync(DbConnection connection, ConnectionEventData eventData,
       InterceptionResult result,
       CancellationToken cancellationToken = new())
    {
        result = InterceptionResult.Suppress();
        return base.ConnectionOpeningAsync(connection, eventData, result, cancellationToken);
    }

    public override InterceptionResult ConnectionOpening(DbConnection connection, ConnectionEventData eventData, InterceptionResult result)
    {
        result = InterceptionResult.Suppress();
        return base.ConnectionOpening(connection, eventData, result);
    }
}

}
