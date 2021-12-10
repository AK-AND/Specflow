Feature: Weather Controller
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Poc.Surface.IntegrationTest.WebApi.Test/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Get Weather Report
	Given DB has latest weather reports
	When I hit the get endpoint
	Then the rsponse should be return latest weather report