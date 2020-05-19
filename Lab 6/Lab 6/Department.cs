using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    [Serializable]
    public class Department : Division
    {
        public Department(string name, Person chargePerson, Person generalStaff) : base(name, chargePerson, generalStaff)
        {
            this.name = name;
            this.chargePerson = chargePerson;
            this.generalStaff = generalStaff;
        }
    }
}
