using GuitarApp.Exceptions;
using GuitarApp.Models;
using GuitarApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Controller
{
    internal class FindGuitarTester
    {

        public List<Guitar> FindGuitar(GuitarSpecs findGuitar) {
            //Get the list of similar guitars and send it to the main function
            List<Guitar> SimilarGuitars = Inventory.SearchGuitar(findGuitar);
            if (SimilarGuitars.Count > 0)
            {
                return SimilarGuitars;
            }
            throw new NoGuitarException("No guitar found with similar specification!!!\n");
        }
    }
}
