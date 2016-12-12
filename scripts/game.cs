using System;

public class Game {
    
    public static Action StartGame;
    public static bool canPlay = true;
      
    // This is supposed to be called 1x
    public void Play (){
        NameFunction();
    }
     // This is supposed to run at start of game.
    public void Start (){
        Console.WriteLine("You see, Santa broke one of his legs in a snowmobille accident, you know how much of a daredevil he is. He needs your help do deliver presents to the most difficult to reach houses.");
        do{
             Console.WriteLine("who are you?   Please choose.");
             Console.WriteLine("Human");
             Console.WriteLine("Elf");
             Console.WriteLine("Yeti");
             Console.WriteLine("undefined");
             Who = Console.ReadLine ().ToUpper ();
             if (Who == "HUMAN" || Who == "ELF" || Who == "YETI" || Who == "UNDEFINED")
             {
                 correct = 1;
             } else{}
        } while (correct == 0);
            correct = 0;
            
            // player bonuses if they get any

               if (Who == "HUMAN")
        {
            PlayerSpeed = PlayerSpeed + 2;
            PlayerSkill = PlayerSkill + 2;
            PlayerMagic = PlayerMagic++;
        }
               if (Who == "ELF")
        {
            PlayerSpeed = PlayerSpeed++;
            PlayerSkill = PlayerSkill + 2;
            PlayerMagic = PlayerMagic + 2;
        }
               if (Who == "YETI")
        {
            PlayerSpeed = PlayerSpeed + 2;
            PlayerSkill = PlayerSkill++;
            PlayerMagic = PlayerMagic + 2;
        }
               if (Who == "UNDEFINED")
        {
            PlayerSpeed = 0;
            PlayerSkill = 0;
            PlayerMagic = 0;
        }
    
   

        Continue();

    }
    private string gameStatus = "start";
    public GameStatesBase.GameStatuses toEnum;
    private void Continue (){
        Console.Clear();
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
                GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.Fight; 
                    Continue();
                break;
             case GameStatesBase.GameStatuses.help:
                     Console.WriteLine("WTF do you need help for?");
                     GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.start;
                     Continue();
                break;
            case GameStatesBase.GameStatuses.Fight:
                while (true)
                {
                    Cave.Enter();
                    Random randomNum = new Random();
                    // This is supposed to name Cave as a new level, Then you try to do the level.
                    Cave.HouseEncounter(randomNum.Next(0, Cave.objects.Length));
                    GameTimer();
                    Continue();
                }
                break;
            default:
                Console.WriteLine("I'm sorry i don't understand what that means." );
                Continue();
                break;
       }
        
    }
     
    
     //Game Levels
    private LevelBase Cave = new CaveHouse();
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
            name = Console.ReadLine();
            if (name == String.Empty)
            {
                Console.WriteLine("Your entry was blank, please try again");
            } else {
                Console.WriteLine("hello "+ name + ".");
                Console.WriteLine("Well " + name + ", You've been recruted to help Santa this year.");
                Start();
            }
        }
      
    public string name;
  
    private int correct = 0;
    string Who;
    int PlayerMagic = 0;
    int PlayerSpeed = 0;
    int PlayerSkill = 0;

}

