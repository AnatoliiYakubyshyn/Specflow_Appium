Feature: addition

Scenario Outline: non-negative whole number additon
    When I add <number1> and <number2>
    Then I get <number3>
    Examples:
        | number1 | number2 | number3 |
        | 1       | 3       | 4       |
        | 2       | 22      | 24      |
        | 1000    | 505     | 1505    |