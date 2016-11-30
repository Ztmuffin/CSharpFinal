using System;

public class Game {

    public static Action StartGame;
    public static bool canPlay = true;
      
    // This runs at start of game.
    public void Start (){
        NameFunction();
        name = Console.ReadLine();
        Console.WriteLine("Well" + name + ", You've been recruted to help Santa this year.");
        Console.WriteLine("You see, Santa broke one of his legs in a snowmobille accident, you know how much of a daredevil he is. He needs your help do deliver presents to the most difficult to reach houses.");
        Play();

    }
    private string gameStatus = "start";
    private GameStatesBase.GameSatuses toEnum;
    private void Continue (){
        
       switch (toEnum)
       {
            case GameStatesBase.GameStatuses.End:
                Console.WriteLine("Game OVER!");
                Environment.Exit(0);
                break;
            case GameStatesBase.GameStatuses.Died:
                Console.WriteLine("You've Failed in your mission!");
                GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.End;
                Continue();
                break;
            case GameStatesBase.GameStatuses.play:
                GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.Continue;
                gameStatus = Console.ReadLine();
                if (Enum.TryParse(gameStatus, out toEnum)) 
                    Continue();
                break;
            case GameStatesBase.GameStatuses.start:
                Console.WriteLine("Do you wish to Accept the challenge?   "+ " Type play. or help, for help" );
                gameStatus = Console.ReadLine();
                if (Enum.TryParse(gameStatus, out toEnum)) 
                    Continue();
                break;
             case GameStatesBase.GameStatuses.help:
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
                    Continue();
                }
                break;
            default:
                Console.WriteLine("I'm sorry i don't understand what that means." );
                Play();
                break;
       }
        
    }
     public Game () {
        Cave.StartMessage = "You have entered a cave to deliver a present to a cave dweller";
        Underwater.objects = new string []{"seaweed", "Coral", "fish", "shark"};
      }
    
     //Game Levels
    private LevelBase Cave = new CaveLevel();
    public static LevelBase Underwater = new LevelBase();

    // game powerups?
    
    // Game weapons?

    // game timer?
    public static void GameTimer () {
        System.Threading.Thread.Sleep(2000);
    }
    // name entry function
             public void NameFunction (){
        Console.WriteLine("What is your name?");
            if (line == String.Empty)
            {
                Console.WriteLine("Your entry was blank, please try again");
            } else {
                Start();
            }
        }
    public string name;

    private int score;
}

