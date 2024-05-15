Feature: Sign up

Scenario Outline: Sign up with different data
    Given I am on Home page
    When I proceed to Sign up page
    And Sign up with "<name>" and "<password>" and "<gender>"
    Then Web View page is opened
    Examples:
    | name  | password |  gender |
    | Tolia | P        | Male |
    | Olena |p1        | Female|
    | Olena |p1234Q    | Female|
    | Test user |p1    | Female|