using GuitarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Controller
{
    internal class FindGuitarTester
    {
        //Inventory inventory = new Inventory();

        public List<Guitar> FindGuitar() {
            Guitar findGuitar = new Guitar("", 0, Builder.COLLINGS, "model2", Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> SimilarGuitars = Inventory.SearchGuitar(findGuitar);
            if (SimilarGuitars.Count > 0)
            {
                return SimilarGuitars;
            }
            return null;//Exception throw
        }
    }
}
