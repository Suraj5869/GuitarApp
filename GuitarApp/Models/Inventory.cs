using GuitarApp.Exceptions;
using GuitarApp.Enums;
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
        
        //Add the new data of guitar in the guitar inventory
         public void AddGuitar(String serialno, double price, Builder builder, string model, Types type, int numString, Wood backwood, Wood topwood)
        {
            GuitarSpecs specs =new GuitarSpecs(builder, model, type, numString, backwood, topwood);
            Guitar guitar = new Guitar(serialno, price, specs);
            guitars.Add(guitar);
        }

        //Method used to get the guitar information based on the serial number entered by user
        //and throws an exception if the guitar does not found
        public Guitar GetGuitar(String serialno)
        {
            Guitar guitar = guitars.Where(g => g.SerialNumber == serialno).FirstOrDefault();
            if (guitar != null)
            {
                return guitar;
            }
            throw new NoGuitarException("No Guitar with same serial number found!!\n");
        }

        //Method used to get the list of guitars based on specifications enterd by user
        //based on the similar specifications it gives the list of guitars 
        public static List<Guitar> SearchGuitar(GuitarSpecs searchGuitar)
        {
            List<Guitar> similarGuitaras = new List<Guitar>();
            
            foreach (Guitar g in guitars)
            {
                if (g.GetSpecs().Matches(searchGuitar))//This matches the user enterd specifications with the specifications of guitar present in inventory 
                {
                    similarGuitaras.Add(g);
                }
            }
            return similarGuitaras;
        }

    }
}
