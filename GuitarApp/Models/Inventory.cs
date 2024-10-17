using GuitarApp.Exceptions;
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
        

         public void AddGuitar(String serialno, double price, Builder builder, string model, Types type, int numString, Wood backwood, Wood topwood)
        {
            GuitarSpecs specs =new GuitarSpecs(builder, model, type, numString, backwood, topwood);
            Guitar guitar = new Guitar(serialno, price, specs);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(String serialno)
        {
            Guitar guitar = guitars.Where(g => g.SerialNumber == serialno).FirstOrDefault();
            if (guitar != null)
            {
                return guitar;
            }
            throw new NoGuitarException("No Guitar with same serial number found!!\n");
        }

        public static List<Guitar> SearchGuitar(GuitarSpecs searchGuitar)
        {
            List<Guitar> similarGuitaras = new List<Guitar>();
            
            foreach (Guitar g in guitars)
            {
                if (g.GetSpecs().Matches(searchGuitar))
                {
                    similarGuitaras.Add(g);
                }
                
                
                
            }
            return similarGuitaras;
        }

    }
}
