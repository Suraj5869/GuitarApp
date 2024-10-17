using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Guitar
    {

        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public GuitarSpecs Specs {  get; set; }
       

        public Guitar(string serialno, double price, GuitarSpecs spec)
        {
            SerialNumber = serialno;
            Price = price;
            Specs = spec;
        }

        public string GetSerialNumber()
        {
            return SerialNumber;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

      
        public GuitarSpecs GetSpecs()
        {
           
            return Specs;
        }

    public override string ToString()
        {
            return $"Guitar Specifications\n" +
                $"Serial no: {SerialNumber}\n" +
                $"Price: {Price}\n" +
                $"Builder: {Specs.Builder}\n" +
                $"Model: {Specs.Model}\n" +
                $"Type: {Specs.Type}\n" +
                $"NumStrings: {Specs.GetNumStrings()}\n" +
                $"Backwood: {Specs.BackWood}\n" +
                $"Topwood: {Specs.TopWood}\n";
        }

    }
}
