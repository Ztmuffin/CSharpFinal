using System;
public class LooseLife{
   private int lives = 5;
     public void LooseLifes(){
        if (lives > 0){
            lives--;
        Console.WriteLine ("you have " + lives + " lives left.");
        }
        else {
            GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.End;
        }
    }

}