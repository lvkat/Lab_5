using IMainInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialiser
{
    public interface ISerialiser
    {
        void Serialize(string fn, List<Utensil> list, Type[] types);
        List<Utensil> Deserialize(string fn, Type[] types);
    }
}
