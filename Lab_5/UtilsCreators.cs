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
            SetProperties(cup, values);

            return cup;
        }

        public override List<string> GetPropertyNames()
        {

            var propertyName = base.GetPropertyNames();

            propertyName.Add("Количество ручек");

            return propertyName;
        }
    }

    class PanCreator : BaseUtensilCreator
    {
         public override void SetProperties(Utensil utensil, List<string> values)
        {
            base.SetProperties(utensil as Pan, values);

           
            (utensil as Pan).Diameter = Int32.Parse(values[3]);
            (utensil as Pan).CoverType = values[4];
           
             utensil.Name = "Сковорода";
        }

        public override List<string> GetProperties(Utensil utensil)
        {
            var values = base.GetProperties(utensil);
      
            values.Add((utensil as Pan).Diameter.ToString());
            values.Add((utensil as Pan).CoverType);

            return values;
        }

        public override Utensil CreateUtensil(List<string> values)
        {
            Pan pan = new Pan();
            SetProperties(pan, values);

            return pan;
        }

        public override List<string> GetPropertyNames()
        {
            var propertyName = base.GetPropertyNames();

            propertyName.Add("Диаметр");
            propertyName.Add("Тип покрытия");

            return propertyName;
        }

    }

    class SteamerCreator : PanCreator 
    {
     public override void SetProperties(Utensil utensil, List<string> values)
        {
            base.SetProperties(utensil as Steamer, values);

           
            (utensil as Steamer).Capasity = int.Parse( values[5]);
            (utensil as Steamer).ContainersCout = int.Parse(values[6]);
           
             utensil.Name = "Пароварка";
        }

        public override List<string> GetProperties(Utensil utensil)
        {
            var values = base.GetProperties(utensil);
      
            values.Add((utensil as Steamer).Capasity.ToString());
            values.Add((utensil as Steamer).ContainersCout.ToString());

            return values;
        }

        public override Utensil CreateUtensil(List<string> values)
        {
            Steamer steamer = new Steamer();
            SetProperties(steamer, values);

            return steamer;
        }

        public override List<string> GetPropertyNames()
        {
            var propertyName = base.GetPropertyNames();

            propertyName.Add("Мощность");
            propertyName.Add("Емкость для готовки");

            return propertyName;
        }

    }
   
    class TureenCreator : BaseUtensilCreator
    {
        public override void SetProperties(Utensil utensil, List<string> values)
        {
            base.SetProperties(utensil as Tureen, values);

            (utensil as Tureen).HaftCount = int.Parse(values[3]);
            (utensil as Tureen).Shape = values[4];

            utensil.Name = "Супница";
        }

        public override List<string> GetProperties(Utensil utensil)
        {
            var values = base.GetProperties(utensil);

            values.Add((utensil as Tureen).HaftCount.ToString());
            values.Add((utensil as Tureen).Shape);

            return values;
        }

        public override Utensil CreateUtensil(List<string> values)
        {
            Tureen tureen = new Tureen();
            SetProperties(tureen, values);

            return tureen;
        }

        public override List<string> GetPropertyNames()
        {
            var propertyName = base.GetPropertyNames();

            propertyName.Add("Количество ручек");
            propertyName.Add("Форма");

            return propertyName;
        }


    }
}
