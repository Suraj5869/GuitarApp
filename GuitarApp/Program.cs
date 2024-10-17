using GuitarApp.Controller;
using GuitarApp.Exceptions;
using GuitarApp.Models;
using GuitarApp.Enums;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            //Adding guitar data into inventory
            inventory.AddGuitar("1", 10000, Builder.FENDER, "model1", Types.ACOUSTIC, 6, Wood.ADIRONDACK, Wood.ADIRONDACK);
            inventory.AddGuitar("2", 20500, Builder.COLLINGS, "model2", Types.ELECTRIC, 5,  Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("3", 20887, Builder.GIBSON, "model3", Types.ELECTRIC, 5, Wood.COCOBOLD, Wood.SITKA);
            inventory.AddGuitar("4", 14875, Builder.RYAN, "model1", Types.ELECTRIC, 8, Wood.BRAZILIAN_ROSEWOOD, Wood.ALDER);
            inventory.AddGuitar("5", 23541, Builder.COLLINGS, "model2", Types.ELECTRIC, 5, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("6", 21456, Builder.GIBSON, "model3", Types.ELECTRIC, 5, Wood.COCOBOLD, Wood.SITKA);
            inventory.AddGuitar("7", 10245, Builder.COLLINGS, "model2", Types.ELECTRIC, 5, Wood.ALDER, Wood.ALDER);

            //searching for the guitar based on serial number and return an exception if it is null
            try
            {
                Guitar guitarFind = inventory.GetGuitar("4");
                Console.WriteLine(guitarFind);
            }
            catch (NoGuitarException ne)
            {
                Console.WriteLine(ne.Message);
            }

            FindGuitarTester tester = new FindGuitarTester();

            //Find the list of guitars with the similar specifications that user want and based on the specifications it shows the list of guitars
            //that matches the similar speciications
            try
            {
                GuitarSpecs findGuitar = new GuitarSpecs(Builder.COLLINGS, "model2", Types.ELECTRIC, 5, Wood.ALDER, Wood.ALDER);
                List<Guitar> listOfGuitars = tester.FindGuitar(findGuitar);
                Console.WriteLine("----Similar Guitars with your given specifications----");
                foreach (Guitar a in listOfGuitars)
                {
                    Console.WriteLine(a);
                }
            }
            catch(NoGuitarException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }
    }
}
