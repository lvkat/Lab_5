using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialiser;

namespace XMLSerialiser
{
    public class XMLSerialiserPlugin : IPlugin
    {
        private XMLSerialiser serialiser = new XMLSerialiser();
        private string ext = "xml";

        public string GetExt()
        {
            return ext;
        }

        public ISerialiser GetSerialiser()
        {
            return serialiser;
        }
    }
}
