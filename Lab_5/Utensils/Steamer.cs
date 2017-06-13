using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Lab_5.Utensils
{
    [DataContract]
    public class Steamer : Pan
    {
        [DataMember]
        public int Capasity { get; set; }
        [DataMember]
        public int ContainersCout { get; set; }
    }
}
