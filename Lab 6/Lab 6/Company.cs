using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    [Serializable]
    public class Company
    {
        private string name;
        private string rut;
        private List<Division> l_division;
        public Company(string name, string rut)
        {
            this.name = name;
            this.rut = rut;
        }
        public string Name()
        {
            return name;
        }
        public string Rut()
        {
            return rut;
        }
    }
}
