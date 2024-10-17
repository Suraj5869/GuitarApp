using GuitarApp.Exceptions;
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

        public List<Guitar> FindGuitar() {
            GuitarSpecs findGuitar = new GuitarSpecs(Builder.COLLINGS, "model2", Types.ELECTRIC, 7, Wood.ALDER, Wood.ALDER);
            List<Guitar> SimilarGuitars = Inventory.SearchGuitar(findGuitar);
            if (SimilarGuitars.Count > 0)
            {
                return SimilarGuitars;
            }
            throw new NoGuitarException("No guitar found with similar specification!!!\n");
        }
    }
}
