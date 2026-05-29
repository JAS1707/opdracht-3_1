Pikachu pikachu = new Pikachu();
Charmander charmander = new Charmander();
charmander.Geluid();
charmander.VuurAanval("Charmander", 25, pikachu);
Console.WriteLine("----------");
pikachu.Geluid();
pikachu.ElecAanval(charmander, 25);

//Console.WriteLine("no code?"); => "Bro code?"

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
        public void VuurAanval(string naamFire, int dmgFire, Pokemon target)
        {
            if (target.type == "Gras")
            {
                Console.WriteLine($"{naamFire} spuugt vuur naar {target}.");
                Console.WriteLine($"{target} is Gras type: Kritieke schade!");
                int critDmg = (dmgFire * 2);
                Console.WriteLine($"{target} ontvangt {dmgFire} schade!");
                target.levens -= critDmg;
                Console.WriteLine($"{target} heeft nog {target.levens} levens over.");
            }
            else
            {
                Console.WriteLine($"{naamFire} spuugt vuur naar {target}, met {dmgFire} schade!");
                target.levens -= dmgFire;
                Console.WriteLine($"{target} heeft nog {target.levens} levens over.");
            }
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
    public void ElecAanval(Pokemon vijand, int pikaDmg)
    {
        Console.WriteLine($"Pikachu valt {vijand} aan met bliksem, voor {pikaDmg} schade!");
        vijand.levens -= pikaDmg;
        Console.WriteLine($"{vijand} heeft nog {vijand.levens} levens over.");
    }
}