using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    [Serializable]
    public class Block : Division
    {
        private Person generalStaff1;
        private Person generalStaff2;
        public Block(string name, Person chargePerson, Person generalStaff1, Person generalStaff2) : base(name, chargePerson)
        {
            this.name = name;
            this.chargePerson = chargePerson;
            this.generalStaff1 = generalStaff1;
            this.generalStaff2 = generalStaff2;
        }
        public void GeneralStaff()
        {
            Console.WriteLine(generalStaff1.Name() + " " + generalStaff1.Lastname() + " " + generalStaff1.Rut() + " " + generalStaff1.Position());
            Console.WriteLine(generalStaff2.Name() + " " + generalStaff2.Lastname() + " " + generalStaff2.Rut() + " " + generalStaff2.Position());
        }
    }
}
