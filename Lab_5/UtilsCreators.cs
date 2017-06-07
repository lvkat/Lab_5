using Lab_5.Utensils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class CupCreator : BaseUtensilCreator
    {
        public override void SetProperties(Utensil utensil, List<string> values)
        {
            base.SetProperties(utensil as Cup, values);

            (utensil as Cup).HaftCount = int.Parse(values[3]);
            utensil.Name = "Кружка";
        }

        public override List<string> GetProperties(Utensil utensil)
        {
            var values = base.GetProperties(utensil);

            values.Add((utensil as Cup).HaftCount.ToString());

            return values;
        }

        public override Utensil CreateUtensil(List<string> values)
        {
            Cup cup = new Cup();
            // base.SetProperties(cup, values);
            SetProperties(cup, values);

            return cup;
        }

        public override List<string> GetPropertyNames()
        {

            var propertyName = base.GetPropertyNames();

            propertyName.Add("Объём");

            return propertyName;
        }
    }

    /*class PanCreator : BaseUtensilCreator
    {

    }

    class SteamerCreator : BaseUtensilCreator
    {

    }

    class CreateCup : BaseUtensilCreator
    {

    }*/
}
