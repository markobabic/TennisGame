using System.Collections.Generic;

namespace TennisGame.Services.Model
{
    public class MatchResult
    {
        public bool IsFinished { get; set; }
        public List<SetResult> Sets { get; set; }
    }
}
