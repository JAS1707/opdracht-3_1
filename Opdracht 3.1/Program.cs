class Pokemon
{
    string naam = "";
   int levens  = 100;
   int aanvalsPunten = 5;
   string type = "";

   public void Geluid()
    {
        Console.WriteLine($"{naam} maakt geluid");
    } 
}