using EfCore.Extensions.Tests.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Extensions.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var services = new ServiceCollection();
            services.AddDbContext<TestDbContext>(
                    options =>
                        {
                            options.UseSqlServer(string.Empty, sqloptions => sqloptions.UseRelationalNulls(false));
                            options.AddInterceptors(new SuppressConnectionInterceptor());
                        }
                    );

            var builder = services.BuildServiceProvider();

            var context = builder.GetRequiredService<TestDbContext>();

            ////new SqlServerDbContextOptionsBuilder(optionsBuilder).UseRelationalNulls();
            var query1 = context.Entities.Where(e => e.Id == e.Int);
            var s = query1.ToQueryString();
            //var query2 = context.Entities.Where(e => e.Id == e.NullableInt);
            //var query3 = context.Entities.Where(e => e.Id != e.NullableInt);
            //var query4 = context.Entities.Where(e => e.String1 == e.String2);
            //var query5 = context.Entities.Where(e => e.String1 != e.String2);

            //var query = context.Entities.Where(e => e.String1.Substring(0, e.String2.Length) == null);

            //var query1 = context.Entities.Where(e => e.String1 != e.String2 || e.String1.Length == e.String2.Length);
            //var query2 = context.Entities.Where(
            //    e => e.String1 != null && e.String2 != null && (e.String1 != e.String2 || e.String1.Length == e.String2.Length));

        }

        //var x = @'"SELECT [e].[Id], [e].[Int], [e].[NullableInt], [e].[String1], [e].[String2]\r\nFROM [Entities] AS [e]\r\nWHERE [e].[Id] = [e].[Int]';
    }
}