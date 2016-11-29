using System;

public class GameStatesBase{
    public enum GameStatuses {Start, End, Fight, Run, Died}

    public static GameStatuses currentGamestatus = GameStatuses.Start;    
}