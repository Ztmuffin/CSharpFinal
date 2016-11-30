 using System;

public class LevelBase {
   
    public string StartMessage;
    public bool entranceOpen = true;

    public string[] environment;

    public string[] objects;

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void HouseEncounter (int i){
        switch (i){
            case 0:
                Console.WriteLine("While on the sleigh you've come face to face with " + objects[i]);
            break;
            case 1:
                Console.WriteLine("You've walked into " + objects[i]);
                LooseLife();
            break;

            case 2:
                Console.WriteLine("You've walked into " + objects[i]);
                if (objects[i] == "Shark"){
                    
                }
            break;

            case 3:
                Console.WriteLine("You've walked into " + objects[i]);
                Game.GameTimer();
                Random randomNum = new Random();
                Game.Underwater.HouseEncounter(randomNum.Next(0, Game.Underwater.objects.Length));
            break;
        }

        if (i < objects.Length){
            Console.WriteLine("You've walked into " + objects[i]);
            if(objects[i] == "lava"){
                Game.canPlay = false;
            }
        }
        else{
            Console.WriteLine("Your path is clear! GO DELIVER YOUR PRESENTS.");
        }
        
    }

public EndGame LooseLife = new EndGame();
}