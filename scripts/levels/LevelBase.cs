 using System;

public class LevelBase {
   
    public string StartMessage;
    public bool entranceOpen = true;

    public string[] environment;

    public string[] objects;
    public string[] ChildNames;

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void HouseEncounter (int i, string traveled){
        switch (i){
            case 0:
                Console.WriteLine("While sneaking in to deliver presents, you run into " + objects[i]);
               if (objects[i] == "The Christmas Tree") 
                    {Game.GameTimer();
                    Console.WriteLine("You've sucessfully found the Christmas Tree! You drop off your presents and head back to the sleigh.");}
                else if (objects[i] == "lava" || objects[i] == "Icicles" )
                    {Console.WriteLine("You've sliped and fallen onto " + objects[i]);
                        myLostLife.LooseLifes();
                    }
                // trying to use switch statement for both but having a hard time getting it to run.
            break;
            case 1:
               Console.WriteLine("While sneaking in to deliver presents, you run into " + objects[i]);
                if (objects[i] == "The Christmas Tree") 
                    {Game.GameTimer();
                    Console.WriteLine("You've sucessfully found the Christmas Tree! You drop off your presents and head back to the sleigh.");}
                else if (objects[i] == "lava" || objects[i] == "Icicles" )
                    {Console.WriteLine("You've sliped and fallen onto " + objects[i]);
                        myLostLife.LooseLifes();
                    }
            break;
        default:
            Console.WriteLine("Your path is clear! GO DELIVER YOUR PRESENTS.");
        break;
        }
        
    }
    public void Environment(int i){
        Console.WriteLine("This house is " + environment[i] + ".");
    }
    public void KidName (int i){
        Console.WriteLine("You are visiting " + ChildNames[i] + " on the nice list.");
    }
   public static Game myLostLife = new Game();

}