using SpecFlowProject1.Support;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext scenarioContext;//added
        private readonly Calculator calculator;//added
        private int result;//added

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)//added
        {
            this.scenarioContext = scenarioContext;//added
            this.calculator = new Calculator();//added
        }
        [Given("the first number is (.*)")]//we are taken 1stNum incalculator wt user have passed
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.Fnum = number;//added
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.Snum = number;//added
        }

        [When("the two numbers are added")]//when 2 num is added weHave tocall AddMethod
        public void WhenTheTwoNumbersAreAdded()
        {
            result = calculator.Add();//added//calling Add method
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);//added//here comparing result
        }
    }
}
