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
        private int numStrings;

        public GuitarSpecs(Builder builder, string model, Types type, int numStrings, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            this.numStrings = numStrings;
            BackWood = backWood;
            TopWood = topWood;
        }
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

        public int GetNumStrings()
        {
            return numStrings;
        }

        internal bool Matches(GuitarSpecs searchGuitar)
        {
            if((searchGuitar.GetBuilder() == Builder) && (searchGuitar.GetModel() == Model)
                    && (searchGuitar.GetType() == Type) && (searchGuitar.GetNumStrings() == numStrings) 
                    && (searchGuitar.GetBackWood() == BackWood) && (searchGuitar.GetTopWood() == TopWood))
            {
                return true;
            }
            return false;
        }
    }
}
