Feature: UsingCalculatorISS
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
In order to calculate the Basic Musa model's failures/intensities As a Software Quality Metric enthusiast
I want to use my calculator to do this

Link to a feature: [Calculator]($projectname$/Features/UsingCalculatorISS.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@BasicReliability
Scenario: Calculating defect density
		  Given I have a calculator
 		  When I have entered 100 and 50 into the calculator and press DefectDensity 
		  Then the defect density result should be 2


@BasicReliability
Scenario: Calculating Shipped Source Instructions (ISS) for second release of a system
		  Given I have a calculator
		  When I have entered 50, 20, 0.2 and 0 into the calculator and press ISS 
		  Then the new ISS result should be 66