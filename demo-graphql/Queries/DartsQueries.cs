using Microsoft.EntityFrameworkCore;
using shared.models;

namespace demo_graphql.Queries
{
    public class DartsQueries
    {

        public List<ApplicationUser> GetApplicationUsers([Service] DartDbContext context)
        {
            return context.ApplicationUsers
                .ToList();
        }
    }
}
