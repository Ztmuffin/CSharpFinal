public class CaveHouse: LevelBase{
    public CaveHouse (){
        environment = new string [] {"Cold", "Wet", "Dark"};
        objects = new string [] {"Bats", "The Christmas Tree","lava"};
        StartMessage = "You have entered a cave to deliver a present to a cave dweller.";
        ChildNames = new string[]{"Hugo", "Kevin", "Katy", "Brandy", "Thaer", "Zoey" };
    }
}