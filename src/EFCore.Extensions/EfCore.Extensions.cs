using Microsoft.Extensions.Options;

namespace Microsoft.EntityFrameworkCore
{
    public static class EfCoreExtensions
    {


        public static void AddEfCoreExtensions(this DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.AddInterceptors(new TaggedQueryCommandInterceptor());
        }
    }
}
