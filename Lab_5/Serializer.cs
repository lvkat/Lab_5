using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_5.Utensils;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Lab_5
{
    class Serializer
    {

        public void Serialize(string fn, List<Utensil> list)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Utensil>), new List<Type> { typeof(Cup), typeof(Pan), typeof(Steamer), typeof(Tureen) });
            using (FileStream fs = new FileStream(fn, FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, list);
            }
        }

        public List<Utensil> Deserialize(string fn)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Utensil>), new List<Type> { typeof(Cup), typeof(Pan), typeof(Steamer), typeof(Tureen) });

            using (FileStream fs = new FileStream(fn, FileMode.Open))
            {
                return (List<Utensil>)formatter.ReadObject(fs);
            }
        }
    }
}
