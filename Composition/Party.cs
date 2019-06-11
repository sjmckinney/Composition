using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChanceNET;

namespace Composition
{
    class Party
    {
        String PartyRef { get; set; } = GuidVersion.V5.ToString();
        public Person Person { get; set; }

        public Party()
        {
            this.Person = new Person();
        }

        public Party(Person person)
        {
            this.Person = person;
        }
    }
}
