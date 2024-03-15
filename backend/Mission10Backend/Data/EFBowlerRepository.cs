using Microsoft.EntityFrameworkCore;

namespace Mission10Backend.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext temp) {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;

        public IEnumerable<Bowler> GetBowlersByTeams(params string[] teamNames)
        {
            return _context.Bowlers
                .Include(b => b.Team) // Ensure Team data is included
                .Where(b => teamNames.Contains(b.Team.TeamName)) // Filter by team names
                .ToList();
        }
    }
}
