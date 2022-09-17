Feature: UsingCalculatorAvailability
		 In order to calculate MTBF and Availability
		 As someone who struggles with math
    	 I want to be able to use my calculator to do this

Link to a feature: [Calculator]($projectname$/Features/UsingCalculatorAvailability.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


@Availability
Scenario: Calculating MTBF
		  Given I have a calculator
 		  When I have entered 5 and 6 into the calculator and press MTBF 
		  Then the availability result should be 11


@Availability
Scenario: Calculating Availability
		  Given I have a calculator
		  When I have entered 5 and 5 into the calculator and press Availability 
		  Then the availability result should be 0.5

@Availability
Scenario: Calculating Availability with MTTR zero
		  Given I have a calculator
		  When I have entered 5 and 0 into the calculator and press Availability 
		  Then the availability result should be 1


@Availability
Scenario: Calculating Availability with MTTF zero
		  Given I have a calculator
		  When I have entered 0 and 5 into the calculator and press Availability 
		  Then the availability result should be 0