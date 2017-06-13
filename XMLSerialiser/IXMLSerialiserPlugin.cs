using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialiser;

namespace XMLSerialiser
{
    public class IXMLSerialiserPlugin : IPlugin
    {
        private MyXMLSerialiser serialiser = new MyXMLSerialiser();
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
