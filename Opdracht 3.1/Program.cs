
class Pokemon
{
    public string naam;
   public int levens  = 100;
   public int aanvalsPunten = 5;
   public string type;
   public void Geluid()
    {
        Console.WriteLine($"{naam} maakt geluid");
    } 
    class Charmander : Pokemon
    {
        public Charmander()
        {
            naam = "Charmander";
            type = "Vuur";
        }
    }
}