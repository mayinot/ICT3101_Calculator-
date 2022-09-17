using System;
using ICT3101_Calculator_Lab2;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace SpecFlowCalculatorTests.Steps
{

    [Binding]
    public sealed class UsingCalculatorDivisionStep
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorDivisionStep(Calculator calc)
        {
            this._calculator = calc;
        }


        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
    }

    [Binding]
    public sealed class UsingCalculatorAdditionStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;

        private Calculator _calculator;
        public UsingCalculatorAdditionStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }


        // Scenario: Add zeros for special cases
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }

    [Binding]
    public sealed class UsingCalculatorDivisionStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;

        private Calculator _calculator;
        public UsingCalculatorDivisionStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }


        // Scenario: Dividing two numbers
        [When(@"I have entered 1 and 2 into the calculator and press divide")]
        public void WhenIHaveEnteredOneAndTwoIntoTheCalculator()
        {
            _result = _calculator.Divide(1, 2);
        }
        [Then(@"the division result should be 0.5")]
        public void ThenTheResultShouldBeHalfOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(0.5));
        }


        // Scenario: Dividing zero by a number
        [When(@"I have entered 0 and 15 into the calculator and press divide")]
        public void WhenIHaveEnteredZeroAndFifteenIntoTheCalculator()
        {
            _result = _calculator.Divide(0, 15);
        }
        [Then(@"the division result should be 0")]
        public void ThenTheResultShouldBeZeroOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(0));
        }


        // Scenario: Dividing by zeros
        [When(@"I have entered 15 and 0 into the calculator and press divide")]
        public void WhenIHaveEnteredFifteenAndZeroIntoTheCalculator()
        {
            _result = _calculator.Divide(15, 0);
        }
        [Then(@"the division result should be positive_infinity")]
        public void ThenTheResultShouldBePositiveInfinityOnTheScreen()
        {
            Assert.That(true, Is.EqualTo(double.IsPositiveInfinity(_result)));

        }

        // Scenario: Dividing by zero by zero 
        [When(@"I have entered 0 and 0 into the calculator and press divide")]
        public void WhenIHaveEnteredZerorAndZeroIntoTheCalculator()
        {
            _result = _calculator.Divide(0, 0);
        }
        [Then(@"the division result should be 1")]
        public void ThenTheResultShouldBeOneOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(1));

        }
    }


    [Binding]
    public sealed class UsingCalculatorFactorialStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;

        private Calculator _calculator;
        public UsingCalculatorFactorialStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }


        // Scenario: Factorial of a number
        [When(@"I have entered 3 into the calculator and press factorial")]
        public void WhenIHaveEnteredThreeIntoTheCalculator()
        {
            _result = _calculator.Factorial(3);
        }
        [Then(@"the factorial result should be 6")]
        public void ThenTheResultShouldBePositiveInfinityOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(6));

        }

        // Scenario: Factorial of zero
        [When(@"I have entered 0 into the calculator and press factorial")]
        public void WhenIHaveEnteredZeroIntoTheCalculator()
        {
            _result = _calculator.Factorial(0);
        }
        [Then(@"the factorial result should be 1")]
        public void ThenTheResultShouldBeOneOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(1));

        }

    }

    [Binding]
    public sealed class UsingCalculatorAvailabilityStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;

        private Calculator _calculator;
        public UsingCalculatorAvailabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }


        // Scenario: Calculating MTBF
        [When(@"I have entered 5 and 6 into the calculator and press MTBF")]
        public void WhenIHaveEnteredFiveAndSixIntoTheCalculator()
        {
            _result = _calculator.MeanTimeBeforeFailure(5,6);
        }
        [Then(@"the availability result should be 11")]
        public void ThenTheResultShouldBeElevenOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(11));

        }

        // Scenario: Calculating Availability
        [When(@"I have entered 5 and 5 into the calculator and press Availability")]
        public void WhenIHaveEnteredFiveandFiveIntoTheCalculator()
        {
            _result = _calculator.Availability(5,5);
        }
        [Then(@"the availability result should be 0.5")]
        public void ThenTheResultShouldBeHalfOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(0.5));

        }

        // Scenario: Calculating Availability with MTTR zero
        [When(@"I have entered 5 and 0 into the calculator and press Availability")]
        public void WhenIHaveEnteredFiveAndZeroIntoTheCalculator()
        {
            _result = _calculator.Availability(5,0);
        }
        [Then(@"the availability result should be 1")]
        public void ThenTheResultShouldBeOneOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(1));

        }

        // Scenario: Calculating Availability with MTTF zero
        [When(@"I have entered 0 and 5 into the calculator and press Availability")]
        public void WhenIHaveEnteredZeroIntoTheCalculator()
        {
            _result = _calculator.Availability(0, 5);
        }
        [Then(@"the availability result should be 0")]
        public void ThenTheResultShouldBeZeroOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(0));

        }

    }

    [Binding]
    public sealed class UsingCalculatorBasicReliabilityStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;

        private Calculator _calculator;
        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }


        // Scenario: Calculating current failure intensity
        [When(@"I have entered 33, 150 and 450 into the calculator and press FailureIntensity")]
        public void WhenIHaveEntered33and150and450IntoTheCalculator()
        {
            _result = _calculator.FailureIntensity(33, 150, 450);
        }
        [Then(@"the current failure intensity result should be 22")]
        public void ThenTheResultShouldBeTwentyTwoOnTheScreen()
        {
            Assert.That(Math.Round(_result, 0), Is.EqualTo(22));

        }

        // Scenario: Calculating average number of expected failures
        [When(@"I have entered 33, 5 and 450 into the calculator and press AvgFailures")]
        public void WhenIHaveEntered33and5and450IntoTheCalculator()
        {
            _result = _calculator.AverageFailureExpected(33, 5, 450);
        }
        [Then(@"the average number of expected failures result should be 138.13")]
        public void ThenTheResultShouldBeOneThreeEightOnTheScreen()
        {
            Assert.That(Math.Round(_result, 2), Is.EqualTo(138.13));
        }
    }

    [Binding]
    public sealed class UsingCalculatorLogarithmicReliabilityStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;

        private Calculator _calculator;
        public UsingCalculatorLogarithmicReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }


        // Scenario: Calculating current failure intensity
        [When(@"I have entered 10, 0.02 and 50 into the calculator and press FailureIntensity")]
        public void WhenIHaveEntered10and002and50IntoTheCalculator()
        {
            _result = _calculator.LogModelFailureIntensity(10, 0.02, 50);
        }
        [Then(@"the current failure intensity result should be 3.68")]
        public void ThenTheResultShouldBe3point68OnTheScreen()
        {
            Assert.That(Math.Round(_result, 2), Is.EqualTo(3.68));

        }

        // Scenario: Calculating average number of expected failures
        [When(@"I have entered 10, 0.02 and 10 into the calculator and press AvgFailures")]
        public void WhenIHaveEntered10and002and10IntoTheCalculator()
        {
            _result = _calculator.LogModelAverageFailureExpected(10, 0.02, 10);
        }
        [Then(@"the average number of expected failures result should be 54.93")]
        public void ThenTheResultShouldBe55point93tOnTheScreen()
        {
            Assert.That(Math.Round(_result, 2), Is.EqualTo(54.93));
        }
    }


    [Binding]
    public sealed class UsingCalculatorISSStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;

        private Calculator _calculator;
        public UsingCalculatorISSStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }


        // Scenario: Calculating defect density
        [When(@"I have entered 100 and 50 into the calculator and press DefectDensity")]
        public void WhenIHaveEntered100and50IntoTheCalculator()
        {
            _result = _calculator.DefectDensity(100, 50);
        }
        [Then(@"the defect density result should be 2")]
        public void ThenTheResultShouldBeTwoOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(2));
        }

        // Scenario: Calculating Shipped Source Instructions (ISS) for second release of a system
        [When(@"I have entered 50, 20, 0.2 and 0 into the calculator and press ISS")]
        public void WhenIHaveEntered50and20and0point2and0IntoTheCalculator()
        {
            _result = _calculator.NewISS(50, 20, 0.2, 0);
        }
        [Then(@"the new ISS result should be 66")]
        public void ThenTheResultShouldBeSixtySixOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(66));
        }
    }
}
