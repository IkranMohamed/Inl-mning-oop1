namespace Inlämning_oop1

    {
      //ARV EXEMPEL

     // HUVUDKLASSEN
    public class Plant()
    {
        //ATTRIBUTER AV KLASSEN PLANT
        public string Name;

        public int Weight;

        //METODER

        public void Grow()
        {
            Console.WriteLine("This plant grows");
        }

        public void Food()
        {
            Console.WriteLine("This plant produce their own food");
        }
    }
      // SUBKLASSER SOM ÄRVER FRÅN PLANT
    public class Tree  : Plant 
    
    {
        // NYA ATTRIBUTER + ALLA ATTRIBUTER FRÅN PLANT
        public string branche;
      
        // NYA METODER + ALLA METODER FRÅN PLANT
        public new void Food()
        {
            Console.WriteLine("This plant does not produce their own food");
        }

    }

}


