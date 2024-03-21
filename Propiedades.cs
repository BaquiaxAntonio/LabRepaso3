using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso3
{
    internal class Propiedades
    {
        string noCasa;
        string dpiDueño;
        int cuotaMatenimiento;

        public string NoCasa { get => noCasa; set => noCasa = value; }
        public string DpiDueño { get => dpiDueño; set => dpiDueño = value; }
        public int CuotaMatenimiento { get => cuotaMatenimiento; set => cuotaMatenimiento = value; }
    }
}
