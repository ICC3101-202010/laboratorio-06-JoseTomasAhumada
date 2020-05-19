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
        public Block(string name, Person chargePerson, Person generalStaff) : base(name, chargePerson, generalStaff)
        {
            this.name = name;
            this.chargePerson = chargePerson;
            this.generalStaff = generalStaff;
        }
        //public void GeneralStaff()
        //{
        //    Console.WriteLine(generalStaff1.Name() + " " + generalStaff1.Lastname() + " " + generalStaff1.Rut() + " " + generalStaff1.Position());
        //    Console.WriteLine(generalStaff2.Name() + " " + generalStaff2.Lastname() + " " + generalStaff2.Rut() + " " + generalStaff2.Position());
        //}
    }
}
