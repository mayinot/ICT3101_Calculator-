Feature: UsingCalculatorFactorial
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for factorial of **one** number

Link to a feature: [Calculator]($projectname$/Features/UsingCalculatorFactorial.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


@Addition
Scenario: Factorial of a number
		  Given I have a calculator
          When I have entered 3 into the calculator and press factorial
          Then the factorial result should be 6

@Addition
Scenario: Factorial of zero
		  Given I have a calculator
          When I have entered 0 into the calculator and press factorial
          Then the factorial result should be 1
