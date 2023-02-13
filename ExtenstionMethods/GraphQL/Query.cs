using GraphQL.Data;
using GraphQL.Models;

namespace POC.GraphQL.GraphQL
{
    public class Query
    {
        public IQueryable<Platform>? GetPlatforms([Service] AppDbContext context)
        {
            return context.Platforms;
        }

    }
}