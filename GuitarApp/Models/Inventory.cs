using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Inventory
    {
        static List<Guitar> guitars = new List<Guitar>();
        

         public void AddGuitar(String serialno, double price, Builder builder, string model, Types type, Wood backwood, Wood topwood)
        {
            Guitar guitar = new Guitar(serialno, price, builder, model, type, backwood, topwood);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(String serialno)
        {
            Guitar guitar = guitars.Where(g => g.SerialNumber == serialno).FirstOrDefault();
            if (guitar != null)
            {
                return guitar;
            }
            return null;
        }

        public static List<Guitar> SearchGuitar(GuitarSpecs searchGuitar)
        {
            List<Guitar> similarGuitaras = new List<Guitar>();
            
            foreach (Guitar g in guitars)
            {
                GuitarSpecs specs = g.getSpecs();
                if ((searchGuitar.GetBuilder() == specs.Builder) && (searchGuitar.GetModel() == specs.Model)
                    && (searchGuitar.GetType() == specs.Type) && (searchGuitar.GetBackWood() == specs.BackWood)
                    && (searchGuitar.GetTopWood() == specs.TopWood))
                {
                    similarGuitaras.Add(g);
                }
                
                
            }
            return similarGuitaras;
        }

    }
}
