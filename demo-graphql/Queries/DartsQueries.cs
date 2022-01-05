using Microsoft.EntityFrameworkCore;
using shared.models;

namespace demo_graphql.Queries
{
    public class DartsQueries
    {
        /*
        public static readonly DartDbContext _context = new DartDbContext();
        
        public List<ApplicationUser> GetApplicationUsers()
        {
            return _context.ApplicationUsers
                .Include(e => e.MatchesAsPlayer1)
                .Include(e => e.MatchesAsPlayer2)
                .ToList();
        }
        */

        public ApplicationUser GetApplicationUser()
        {
            return new ApplicationUser
            {
                Id = 1,
                Name = "Wannes Rebry",
                Email = "wannes.rebry@noest.it"
            };
        }

    }
}
