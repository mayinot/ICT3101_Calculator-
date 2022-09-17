Feature: UsingCalculatorLogarithmicReliability
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
In order to calculate the Logarithmic Musa model's failures/intensities As a Software Quality Metric enthusiast
I want to use my calculator to do this

Link to a feature: [Calculator]($projectname$/Features/UsingCalculatorLogarithmicReliability.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@LogarithmicReliability
Scenario: Calculating current failure intensity
		  Given I have a calculator
 		  When I have entered 10, 0.02 and 50 into the calculator and press FailureIntensity 
		  Then the current failure intensity result should be 3.68


@LogarithmicReliability
Scenario: Calculating average number of expected failures
		  Given I have a calculator
		  When I have entered 10, 0.02 and 10 into the calculator and press AvgFailures 
		  Then the average number of expected failures result should be 54.93