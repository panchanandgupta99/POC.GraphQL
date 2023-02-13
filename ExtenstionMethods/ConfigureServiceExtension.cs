
using GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using POC.GraphQL.GraphQL;

namespace GraphQL.ExtensionMethods
{
    public static class ConfigureServiceExtension
    {
        public static void ConnectToSQL(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(config.GetConnectionString("GraphQL")));
        }

        public static void ConnectGraphQLServer(this IServiceCollection services)
        {
            services.AddGraphQLServer().AddQueryType<Query>();
        }

        public static void ConfigureAppService(this IServiceCollection services)
        {
        }

    }
}