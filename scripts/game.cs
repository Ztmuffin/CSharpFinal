using System;

public class Game {
    
    public static bool canPlay = true;
    
      
    // This is supposed to be called 1x
    public void Play (){
        NameFunction();
    }
     // This is supposed to run at start of game.
    public void Start (){
        Console.WriteLine("You see, Santa broke one of his legs in a snowmobille accident, you know how much of a daredevil he is. He needs your help do deliver presents to the most difficult to reach houses.");
       //Character Creation tools i referenced from what i found online:
        GameTimer();
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
            	do {
				Console.WriteLine ("Please choose a gender as below:");
				Console.WriteLine ("Male / Female");
				Player_Gender = Console.ReadLine ().ToUpper ();
				if (Player_Gender == "MALE" || Player_Gender == "FEMALE") 
				{
					correct = 1;
				}
				else {}
			} while(correct == 0);
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
    private string gameStatus = "Start";
    public GameStatesBase.GameStatuses toEnum;
    private void Continue (){
           switch (toEnum)
       {
            case GameStatesBase.GameStatuses.End:
                gameStatus = "End";
                if (Enum.TryParse(gameStatus, out toEnum))
                Console.WriteLine("Game OVER!");
                canPlay = false;
                Environment.Exit(0);
                break;
            case GameStatesBase.GameStatuses.Died:
                Console.WriteLine("You've Failed in your mission!");
                GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.End;
                GameTimerShort();
                gameStatus = "End";
                if (Enum.TryParse(gameStatus, out toEnum))
                Continue();
                break;
                //If play, change to continue then run again.
            case GameStatesBase.GameStatuses.play:
                GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.Fight;
                gameStatus = "Fight"; 
                if (Enum.TryParse(gameStatus, out toEnum))
                 Continue();
                break;
            case GameStatesBase.GameStatuses.Start:
                Console.WriteLine("Do you wish to Accept the challenge?   "+ " Type play. or help, for help" );
                gameStatus = Console.ReadLine();
                if (Enum.TryParse(gameStatus, out toEnum))
                    GameTimerShort();
                    Continue();
                break;
             case GameStatesBase.GameStatuses.help:
                     Console.WriteLine("WTF do you need help for?");
                     GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.Start;
                     GameTimer();
                     gameStatus = "Start";
                     if (Enum.TryParse(gameStatus, out toEnum))
                     Continue();
                break;
            case GameStatesBase.GameStatuses.Fight:
                gameStatus = "Fight"; 
                while (Game.canPlay)
                {
                     // This is supposed to name Cave as a new level, Then you try to do the level.
                    Cave.Enter();
                    Random randomNum = new Random();
                    Cave.KidName(randomNum.Next(0, Cave.ChildNames.Length));
                    Cave.HouseEncounter(randomNum.Next(0, Cave.objects.Length), "came across");
                    GameTimer();
                    //this is supposed to switch it up, by trying something else instead.
                   // MountainLevel();
                    Mountain.Enter();
                    Mountain.KidName(randomNum.Next(0, Mountain.ChildNames.Length));
                    Mountain.HouseEncounter(randomNum.Next(0, Mountain.objects.Length),"Entering the home you came across ");
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
     // supposed to subtract life when something bad happens.
     int lives = 5;
     public void LooseLifes(){
        if (lives > 0){
            lives--;
        Console.WriteLine ("you have " + lives + " lives left.");
        }
        else {
            GameStatesBase.currentGamestatus = GameStatesBase.GameStatuses.End;
            canPlay = false;
        }
    }
     //Game Levels
    private LevelBase Cave = new CaveHouse();
    public static LevelBase Mountain = new MountainHouse();
     /*   public void MountainLevel(){
            Mountain.Enter();
            Random randomNum = new Random();
            Mountain.HouseEncounter(randomNum.Next(0, Mountain.objects.Length),"Entering the home you came across");
            GameTimer();
            Continue();
    }*/

    // game powerups?
    
    // Game weapons?

    // game timer?
    public static void GameTimer () {
        System.Threading.Thread.Sleep(4000);
    }
    public static void GameTimerShort (){
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
                GameTimerShort();
                Console.WriteLine("Well " + name + ", You've been recruted to help Santa this year.");
                Start();
            }
        }
      
    public string name;
    string Player_Gender;
  
    private int correct = 0;
    string Who;
    int PlayerMagic = 0;
    int PlayerSpeed = 0;
    int PlayerSkill = 0;

}

