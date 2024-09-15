namespace Inlämning_oop1.inlämningoop2._2
{
   public class Salary
    {
        //This is a private attribute which we protect from the rest off the app and users
        //We access this only using public methods or public attributes
        private string name;

        //Konstruktör = Den säger när vi ett objekt av klassen Salary, gör så att jag kan sätta värde på attributerna direkt i skapandet av objektet,att vi måste specificera attributen
        
        public Salary (string name)
        {
            Name = name;
        }
        //Now we gonna make a public method to access private attributes
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
