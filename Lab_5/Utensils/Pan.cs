﻿using System;
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
    public class Pan : Utensil
    {
        [DataMember]
        public int Diameter { get; set; }
        [DataMember]
        public string CoverType { get; set; }
    }
}
