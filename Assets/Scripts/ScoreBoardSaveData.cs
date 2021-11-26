using System.Collections.Generic;
using System;

namespace jim.Scoreboards
{
    [Serializable]
    public class ScoreBoardSaveData
{
    public List<ScoreboardEntryData> highscores = new List<ScoreboardEntryData>();
}
}

