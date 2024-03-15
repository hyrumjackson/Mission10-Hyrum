namespace Mission10Backend.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Bowler> GetBowlersByTeams(params string[] teamNames);
    }
}
