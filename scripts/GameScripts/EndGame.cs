using System;


public class EndGame{
    int lifes;

    void Awake(){
        lifes = 5;
    }

    public void looseLife(){
        if (lifes != 0){
            lifes--;
        Console.WriteLine ("you have " + lifes + " lives left.");
        }
        else {
            GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.End;
        }
    }
}