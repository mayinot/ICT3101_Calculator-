Feature: UsingCalculatorBasicReliability
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
In order to calculate the Basic Musa model's failures/intensities As a Software Quality Metric enthusiast
I want to use my calculator to do this

Link to a feature: [Calculator]($projectname$/Features/UsingCalculatorBasicReliability.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@BasicReliability
Scenario: Calculating current failure intensity
		  Given I have a calculator
 		  When I have entered 33, 150 and 450 into the calculator and press FailureIntensity 
		  Then the current failure intensity result should be 22


@BasicReliability
Scenario: Calculating average number of expected failures
		  Given I have a calculator
		  When I have entered 33, 5 and 450 into the calculator and press AvgFailures 
		  Then the average number of expected failures result should be 138.13