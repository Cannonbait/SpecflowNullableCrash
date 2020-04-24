using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNullable
{
    public class Person
    {
        public string Name { get; set; }

        public CauseOfDeath? CauseOfDeath { get; set; }
    }
}
