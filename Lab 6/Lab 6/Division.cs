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
        protected Person generalStaff;
        public Division(string name, Person chargePerson, Person generalStaff)
        {
            this.name = name;
            this.chargePerson = chargePerson;
            this.generalStaff = generalStaff;
        }
        public string Name()
        {
            return name;
        }
        public void ChargePerson()
        {
            Console.WriteLine(chargePerson.Name() + " " + chargePerson.Lastname() + " " + chargePerson.Rut() + " " + chargePerson.Position());
        }
        public void GeneralStaff()
        {
            Console.WriteLine(generalStaff.Name() + " " + generalStaff.Lastname() + " " + generalStaff.Rut() + " " + generalStaff.Position());
        }
    }
    
}
