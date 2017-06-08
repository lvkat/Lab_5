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
    class Cup : Utensil
    {
        [DataMember]
        public int HaftCount { get; set; }
    }
}
