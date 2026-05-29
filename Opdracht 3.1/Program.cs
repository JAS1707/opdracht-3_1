class Pokemon
{
    public string naam;
   public int levens  = 100;
   public int aanvalsPunten;
   public string type;
   public string geluid;
   public void Geluid()
    {
        Console.WriteLine($"{naam} maakt geluid: '{geluid}'");
    } 
}

class Charmander : Pokemon
    {
        public Charmander()
        {
            naam = "Charmander";
            aanvalsPunten = 20;
            type = "Vuur";
            geluid = "Charmander!";
        }
    }

class Pikachu : Pokemon
{
    public Pikachu()
    {
        naam = "Pikachu";
        aanvalsPunten = 20;
        type = "Elektriciteit";
        geluid = "Pika!";
    }
}