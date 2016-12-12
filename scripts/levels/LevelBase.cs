 using System;

public class LevelBase {
   
    public string StartMessage;
    public bool entranceOpen = true;

    public string[] environment;

    public string[] objects;

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void HouseEncounter (int i, string traveled){
        switch (i){
            case 0:
                Console.WriteLine("While sneaking in to deliver presents, you run into " + objects[i]);
            break;
            case 1:
                Console.WriteLine("You've Come across " + objects[i]);
                if (objects[i] == "The Christmas Tree"){ 
                    Game.GameTimer();
                    Console.WriteLine("You've sucessfully found the Christmas Tree! You drop off your presents and head back to your sleigh.");
                }
            break;
       }
        if (i < objects.Length){
            Console.WriteLine("You've fallen into " + objects[i]);
            if(objects[i] == "lava"){
                myLostLife.LooseLifes();
            }
        }
        else{
            Console.WriteLine("Your path is clear! GO DELIVER YOUR PRESENTS.");
        }
        
    }
    public LooseLife myLostLife = new LooseLife();

}