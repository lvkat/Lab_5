using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialiser
{
    public interface IPlugin
    {
        string GetExt();
        ISerialiser GetSerialiser();
    }
}
