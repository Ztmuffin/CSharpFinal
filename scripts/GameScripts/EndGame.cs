using System;

public class EndGame{
    private string gameStatus = "Start";
    private GameStatesBase.GameStatuses toEnum;
    
    private void Continue (){
        
       switch (toEnum)
       {
            case GameStatesBase.GameStatuses.End:
                Console.WriteLine("Game OVER!");
                Environment.Exit(0);
                break;

            case GameStatesBase.GameStatuses.Died:
                Console.WriteLine("You've Failed in your mission!");
                Console.WriteLine("Game OVER!");
                GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.End;
                Continue();
                break;
            
            case GameStatesBase.GameStatuses.Start:
                Console.WriteLine("Please type your name:");
                name = Console.ReadLine();
                Console.WriteLine("Your Player name is " + name);

                Console.WriteLine("Do you wish to Accept the challenge?   "+ " Type Play, or help for help" );
                gameStatus = Console.ReadLine();
                if (Enum.TryParse(gameStatus, out toEnum)) 
                    Continue();
                break;
             case GameStatesBase.GameStatuses.Help:
                     Console.WriteLine("WTF do you need help for?");
                     Continue();
                break;
            case GameStatesBase.GameStatuses.Fight:
                while (true)
                {
                    Cave.Enter();
                    Random randomNum = new Random();
                    Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
                    GameTimer();
                    Play();
                }
                break;
            default:
                Console.WriteLine("I'm sorry i don't understand what that means." );
                Play();
                break;
       }
        
    }
   public string name;

}