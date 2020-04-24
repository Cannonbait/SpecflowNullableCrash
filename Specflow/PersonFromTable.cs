using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNullable
{
    public class PersonsFromTable
    {
        public IEnumerable<string> Headers { get; set; }
        public IEnumerable<Person> Persons { get; set; }
    }
}
