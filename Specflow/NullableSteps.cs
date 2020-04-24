using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecflowNullable
{
    [Binding]
    public sealed class NullableSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public NullableSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I have a table with an enum that is null")]
        public void GivenIHaveATableWithAnEnumThatIsNull(IEnumerable<Person> persons)
        {
            Assert.That(false);
        }

        [Then(@"I want to be able to see some info")]
        public void ThenIWantToBeAbleToSeeSomeInfo()
        {
            Assert.That(false);
        }


    }

}
