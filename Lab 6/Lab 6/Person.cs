using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    [Serializable]
    public class Person
    {
        private string name;
        private string lastname;
        private string rut;
        private string position;
        public string Name()
        {
            return name;
        }
        public string Lastname()
        {
            return lastname;
        }
        public string Rut()
        {
            return rut;
        }
        public string Position()
        {
            return position;
        }
        public Person(string name, string lastname, string rut, string position)
        {
            this.name = name;
            this.lastname = lastname;
            this.rut = rut;
            this.position = position;
        }
    }
}
