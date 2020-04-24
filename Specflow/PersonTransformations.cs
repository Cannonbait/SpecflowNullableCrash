using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNullable
{
    [Binding]
    public class PersonTransformations
    {

        [StepArgumentTransformation]
        public IEnumerable<Person> TransformTableToTaskDto(Table table)
        {
            var headerName = "CauseOfDeath";
            if (table.Header.Contains(headerName))
            {
                //Find all rows where CauseOfDeath is the string "null" and replace with actual null
                table.Rows.Where(row => row[headerName] == "null").ToList()
                    .ForEach(row => row[headerName] = null);
            }

            return table.CreateSet<Person>();
        }
    }
}