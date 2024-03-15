using System;
using System.Collections.Generic;
using Mission10Backend.Data;

namespace Mission10Backend.Models;

public partial class BowlerScore
{
    public int MatchId { get; set; }

    public short GameNumber { get; set; }

    public int BowlerId { get; set; }

    public short? RawScore { get; set; }

    public short? HandiCapScore { get; set; }

    public bool WonGame { get; set; }

    public virtual Bowler Bowler { get; set; } = null!;
}
