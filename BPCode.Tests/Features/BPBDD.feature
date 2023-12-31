Feature: Blood Pressure Management
  In order to manage my health
  As a patient
  I want to track my blood pressure readings and be alerted to any concerns

  Scenario: Entering a normal blood pressure reading
    Given the blood pressure management system is ready
    When I record a blood pressure reading of 120/80
    Then the system should save the reading with a status of "PreHigh"

  Scenario: High systolic blood pressure alert
    Given the blood pressure management system is ready
    When I record a blood pressure reading of 140/80
    Then the system should save the reading with a status of "High"
