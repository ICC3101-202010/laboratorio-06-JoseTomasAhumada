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
        private List<Division> divisions;
        public Company(string name, string rut, List<Division> divisions)
        {
            this.name = name;
            this.rut = rut;
            this.divisions = divisions;
        }
        public string Name()
        {
            return name;
        }
        public string Rut()
        {
            return rut;
        }
        public List<Division> Divisions()
        {
            return divisions;
        }
    }
}
