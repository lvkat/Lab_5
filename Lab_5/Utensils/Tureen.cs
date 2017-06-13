using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using IMainInterface;

namespace Lab_5.Utensils
{
    [DataContract]
    public class Tureen : Utensil
    {
        [DataMember]
        public int HaftCount { get; set; }
        [DataMember]
        public string Shape { get; set; }       
    }
}
