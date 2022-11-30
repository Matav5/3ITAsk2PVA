namespace _3ITAsk2OpakOOP
{
    internal class Program
    {
        static List<Animal> animals = new List<Animal>();

        static void Main(string[] args)
        {
            Animal opice = new Animal(4, "Ahoj já jsem Tonda. *Goes apeshit*");
            animals.Add(opice);

            FajnyBober fajnyBober = new FajnyBober(6, "");
            animals.Add(fajnyBober);
            fajnyBober.Gryz();

            Animal zvire = fajnyBober;
            animals.Add(zvire);

            foreach (Animal animal in animals)
            {
                animal.VolitPrezidenta();
            }
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}