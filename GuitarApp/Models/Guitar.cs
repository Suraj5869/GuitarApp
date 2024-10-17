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
        //public Builder Builder { get; set; }
        //public string Model { get; set; }
        //public Types Type { get; set; }
        //public Wood BackWood { get; set; }
        //public Wood TopWood { get; set; }

        public Guitar(string serialno, double price, Builder builder, string model, Types type, Wood backwood, Wood topwood)
        {
            SerialNumber = serialno;
            Price = price;
            Specs = new GuitarSpecs(builder, model, type, backwood, topwood);
            //Builder = builder;
            //Model = model;
            //Type = type;
            //BackWood = backwood;
            //TopWood = topwood;
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

        //public Builder GetBuilder()
        //{
        //    return Builder;
        //}

        //public string GetModel()
        //{
        //    return Model;
        //}

        //public Types GetType()
        //{
        //    return Type;
        //}

        //public Wood GetBackWood()
        //{
        //    return BackWood;
        //}

        //public Wood GetTopWood()
        //{
        //    return TopWood;
        //}
        public GuitarSpecs getSpecs()
        {
            Specs.GetBuilder();
            Specs.GetModel();
            Specs.GetType();
            Specs.GetBackWood();
            Specs.GetTopWood();
            return Specs;
        }

    public override string ToString()
        {
            return $"Guitar Specifications\n" +
                $"Serial no: {SerialNumber}\n" +
                $"Price: {Price}\n" +
                $"Builder: {Specs.Builder}\n" +
                $"Model: {Specs.Model}\n" +
                $"Backwood: {Specs.BackWood}\n" +
                $"Topwood: {Specs.TopWood}\n";
        }

    }
}
