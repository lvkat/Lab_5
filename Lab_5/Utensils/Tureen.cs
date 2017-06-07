using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Utensils
{
    class Tureen : Utensil
    {
        public bool IsWithLadle { get; set; }
        public string Shape { get; set; }       //combobox (круглая/фигурная и т.п.)
    }
}
