using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_5.Utensils;
using IMainInterface;

namespace Lab_5
{
    abstract class BaseUtensilCreator
    {
        public abstract Utensil CreateUtensil(List<string> values);

        public virtual List<string> GetPropertyNames()
        {
            var propertyName = new List<string>();

            propertyName.Add("Цвет");
            propertyName.Add("Материал");
            propertyName.Add("Производитель");

            return propertyName;
        }

        public virtual void SetProperties(Utensil utensil, List<string> values)
        {
            utensil.Color = values[0];
            utensil.Material = values[1];
            utensil.Fabricator = values[2];
        }

        public virtual List<string> GetProperties(Utensil utensil)
        {
            var values = new List<string>();

            values.Add(utensil.Color);
            values.Add(utensil.Material);
            values.Add(utensil.Fabricator);

            return values;
        }
    }
}
