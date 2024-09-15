namespace Inlämning_oop1.inlämningoop2._2
{
  //ABSTRAKTION
  // HUVUDKLASS ABSTRAKT 
  public abstract class Scooter
    {
        public abstract void Brake();
    }

    // SUBKLASS
    public class KickBike : Scooter
    {
        public override void Brake()
        {
            Console.WriteLine("KickBike brakes");
        }   
    }
    
}




