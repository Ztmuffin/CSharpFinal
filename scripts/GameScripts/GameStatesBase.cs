using System;

public class GameStatesBase{
    public enum GameStatuses {start, End, Fight, play, Continue, Run, Died, help}

    public static GameStatuses currentGamestatus = GameStatuses.Start;    
}