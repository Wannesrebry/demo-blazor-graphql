using Microsoft.EntityFrameworkCore;
using shared.models;

namespace demo_graphql.Queries
{
    public class DartsQueries
    {
       
        public static readonly DartDbContext _context = new();

        
        public List<ApplicationUser> GetApplicationUsers()
        {
            return _context.ApplicationUsers
                .ToList();
        }


    }
}
