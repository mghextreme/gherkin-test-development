Feature: Simple calculator

Scenario: Sum and Multiply
  Given First number is 3
  And Second number is 6
  When They are summed
  And They are multiplied
  Then Sum should be 9
  And Multiplication should be 18

Scenario: Sum and Multiply Other
  Given First number is -7
  And Second number is -5
  When They are summed
  And They are multiplied
  Then Sum should be -12
  And Multiplication should be 35