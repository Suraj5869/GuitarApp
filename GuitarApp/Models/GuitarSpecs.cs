using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class GuitarSpecs
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Types Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }

        public Builder GetBuilder()
        {
            return Builder;
        }

        public string GetModel()
        {
            return Model;
        }

        public Types GetType()
        {
            return Type;
        }

        public Wood GetBackWood()
        {
            return BackWood;
        }

        public Wood GetTopWood()
        {
            return TopWood;
        }
    }
}
