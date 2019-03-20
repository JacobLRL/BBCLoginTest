Feature: BBC Login
    In order to access my account
    As a user
    I want to see my member page

@mytag
Scenario: Failed Login
    Given I am on the login page
    When I enter incorrect credentials
    Then I should see the appropriate error