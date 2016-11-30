using System;


public class EndGame{
    int lives;

    void Awake(){
        lives = 5;
    }

    public void looseLife(){
        if (lives != 0){
            lives--;
        Console.WriteLine ("you have " + lives + " lives left.");
        }
        else {
            GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.End;
        }
    }
}