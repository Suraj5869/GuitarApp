using GuitarApp.Controller;
using GuitarApp.Models;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddGuitar("1", 1000, Builder.FENDER, "model1", Types.ACOUSTIC, Wood.ADIRONDACK, Wood.ADIRONDACK);
            inventory.AddGuitar("2", 20500, Builder.COLLINGS, "model2", Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("3", 20887, Builder.COLLINGS, "model2", Types.ELECTRIC, Wood.ALDER, Wood.ALDER);

            FindGuitarTester tester = new FindGuitarTester();
            List<Guitar> listOfGuitars = tester.FindGuitar();
            Console.WriteLine("----Similar Guitars with your given specifications----");
            foreach (Guitar a in listOfGuitars)
            {
                Console.WriteLine(a);
            }
        }
    }
}
