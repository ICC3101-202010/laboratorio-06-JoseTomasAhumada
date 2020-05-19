using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    [Serializable]
    public class Division
    {
        protected string name;
        protected Person chargePerson;
        public Division(string name, Person chargePerson)
        {
            this.name = name;
            this.chargePerson = chargePerson;
        }
        public string Name()
        {
            return name;
        }
        public void ChargePerson()
        {
            Console.WriteLine(chargePerson.Name() + " " + chargePerson.Lastname() + " " + chargePerson.Rut() + " " + chargePerson.Position());
        }
    }
    
}
