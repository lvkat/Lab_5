using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialiser;
using IMainInterface;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialiser
{
    public class XMLSerialiser : ISerialiser
    {
        public List<Utensil> Deserialize(string fn, Type[] types)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Utensil>), types);
            using (FileStream fs = new FileStream(fn, FileMode.Open))
            {
                return (List<Utensil>)serialiser.Deserialize(fs);
            }
        }

        public void Serialize(string fn, List<Utensil> list, Type[] types)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Utensil>), types);
            using (FileStream fs = new FileStream(fn, FileMode.OpenOrCreate))
            {
                serialiser.Serialize(fs, list);
            }
        }
    }
}
