# EFCore Extensions
# overview

Library of extensions to add functionality to Microsoft's EF Core library.


#Problems solved

1. Turn null comparisons off or on for a specific query. This is a significant performance improvement for databases with tables containing nullable values that have lots of records with null values where a join or comparison creates a massive cross-join when comparing nullable values. For more information on nullable comparisons read this article [Null comparison problem](https://learn.microsoft.com/en-us/ef/core/querying/null-comparisons). 


#Using the library

### Installation

EF CoreExtensions  is available on [NuGet](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Cosmos
```

Use the `--version` option to specify a [preview version](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) to install.