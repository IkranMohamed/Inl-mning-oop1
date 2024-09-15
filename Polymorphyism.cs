namespace Inlämning_oop1
{
    //Polymorphyism exempel 
    
    //Huvudklassen
    public class Fordon 
    {
        public string Namn;
       
        public string Modell;

        public virtual void StartaMotor()
        {
            Console.WriteLine("Fordon startar motorn");
        }
    }
    public class motorcykel: Fordon 
    {
        public override void StartaMotor()
        {
            Console.WriteLine("Motorcykel motor startar");
        }
    }
}



