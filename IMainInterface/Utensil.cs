using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace IMainInterface
{
    [DataContract]
    public class Utensil
    {
        [DataMember] 
        public string Color { get; set; }
        [DataMember]
        public string Material { get; set; }
        [DataMember]
        public string Fabricator { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
