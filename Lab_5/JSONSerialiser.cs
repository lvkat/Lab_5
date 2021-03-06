﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using IMainInterface;
using Serialiser;

namespace Lab_5
{
    class JSONSerializer : ISerialiser
    {
        public void Serialize(string fn, List<Utensil> list, Type[] types)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Utensil>), types);
            using (FileStream fs = new FileStream(fn, FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, list);
            }
        }

        public List<Utensil> Deserialize(string fn, Type[] types)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Utensil>), types);

            using (FileStream fs = new FileStream(fn, FileMode.Open))
            {
                return (List<Utensil>)formatter.ReadObject(fs);
            }
        }
    }
}
