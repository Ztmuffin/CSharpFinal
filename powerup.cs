using System;

public class PowerUp {
    public int power = 10;
    public float duration = 5;
    public void RunPowerUp(){

        Console.WriteLine("Using PowerUp");
    }

        public void RechargePowerUp(int _power){
            power += _power;
            Console.WriteLine("Recharged PowerUp to " + power);
        }
}