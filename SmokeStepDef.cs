using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowParallelDemo
{
    [Binding]
    public sealed class SmokeStepDef
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public SmokeStepDef(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            Console.WriteLine("Test started");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Test finshed");
            Assert.IsTrue(true);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic
            Console.WriteLine("Test started");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Test finshed");
            Assert.IsTrue(true);
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            Console.WriteLine("Test started");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Test finshed");
            Assert.IsTrue(true);
        }
    }
}
