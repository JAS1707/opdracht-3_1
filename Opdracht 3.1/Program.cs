Pikachu pikachu = new Pikachu();
Charmander charmander = new Charmander();
charmander.Geluid();
charmander.VuurAanval(pikachu);
pikachu.Geluid();
Console.WriteLine($"Pikachu heeft nog {pikachu.levens} levens over.");

Console.WriteLine("no code?");

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
        public void VuurAanval(Pokemon target)
        {
            Console.WriteLine($"{naam} spuugt vuur met {aanvalsPunten} aanvals punten!");
            target.levens -= aanvalsPunten;
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