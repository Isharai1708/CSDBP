# BloodPressureManagement.feature

Feature: Blood Pressure Management
  In order to manage my health
  As a patient
  I want to track my blood pressure readings and be alerted to any concerns

  Scenario: Entering a normal blood pressure reading
    Given I have accessed my blood pressure management page
    When I enter a systolic reading of 120 mmHg
    And I enter a diastolic reading of 80 mmHg
    And I submit the reading
    Then the reading should be saved with a status "Normal"
    And I should see a message "Your blood pressure is within the normal range."

  Scenario: High systolic blood pressure alert
    Given I have accessed my blood pressure management page
    When I enter a systolic reading of 140 mmHg
    And I enter a diastolic reading of 80 mmHg
    And I submit the reading
    Then the reading should be flagged as "High"
    And I should see an alert "High systolic pressure. Consult your doctor."

  Scenario: High diastolic blood pressure alert
    Given I have accessed my blood pressure management page
    When I enter a systolic reading of 120 mmHg
    And I enter a diastolic reading of 90 mmHg
    And I submit the reading
    Then the reading should be flagged as "High"
    And I should see an alert "High diastolic pressure. Consult your doctor."

  Scenario: Alert for low blood pressure
    Given I have accessed my blood pressure management page
    When I enter a systolic reading of 90 mmHg
    And I enter a diastolic reading of 60 mmHg
    And I submit the reading
    Then the reading should be flagged as "Low"
    And I should see an alert "Low blood pressure detected. If you feel unwell, consult your doctor."

  Scenario: Invalid blood pressure reading entry
    Given I have accessed my blood pressure management page
    When I enter a systolic reading of 80 mmHg
    And I enter a diastolic reading of 90 mmHg
    And I attempt to submit the reading
    Then the reading should not be saved
    And I should see an error "Invalid reading: Diastolic cannot be higher than systolic."
