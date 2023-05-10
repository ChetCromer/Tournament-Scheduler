public class TournamentConfig
{
    public enum TournamentStyleEnum
    {
        SingleElimination,
        DoubleElimination
    }

    public TournamentStyleEnum TournamentStyle { get; set; }
    public int TeamCount { get; set; }
}