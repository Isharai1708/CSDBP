using TechTalk.SpecFlow;
using Xunit;
using BPCode;

[Binding]
public class BloodPressureSteps
{
    private BloodPressure _bloodPressure;

    [Given(@"the blood pressure management system is ready")]
    public void GivenTheBloodPressureManagementSystemIsReady()
    {
        _bloodPressure = new BloodPressure();
    }

    [When(@"I record a blood pressure reading of (\d+)/(\d+)")]
    public void WhenIRecordABloodPressureReadingOf(int systolic, int diastolic)
    {
        _bloodPressure.Systolic = systolic;
        _bloodPressure.Diastolic = diastolic;
    }

    [Then(@"the system should save the reading with a status of ""(.*)""")]
    public void ThenTheSystemShouldSaveTheReadingWithAStatusOf(string expectedStatus)
    {
        string actualStatus = _bloodPressure.Category.ToString();
        Assert.Equal(expectedStatus, actualStatus);
    }
}
