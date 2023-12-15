namespace BPCode;

using Xunit;
using BPCode;

public class BloodPressureTests
{
    [Fact]
    public void BloodPressureCategory_ShouldBeLow_WhenPressureIsBelowNormal()
    {
        var bloodPressure = new BloodPressure { Systolic = 85, Diastolic = 55 };
        Assert.Equal(BPCategory.Low, bloodPressure.Category);
    }

    [Fact]
    public void BloodPressureCategory_ShouldBeIdeal_WhenPressureIsNormal()
    {
        var bloodPressure = new BloodPressure { Systolic = 115, Diastolic = 75 };
        Assert.Equal(BPCategory.Ideal, bloodPressure.Category);
    }

    [Fact]
    public void BloodPressureCategory_ShouldBePreHigh_WhenPressureIsElevated()
    {
        var bloodPressure = new BloodPressure { Systolic = 125, Diastolic = 85 };
        Assert.Equal(BPCategory.PreHigh, bloodPressure.Category);
    }

    [Fact]
    public void BloodPressureCategory_ShouldBeHigh_WhenPressureIsHigh()
    {
        var bloodPressure = new BloodPressure { Systolic = 145, Diastolic = 95 };
        Assert.Equal(BPCategory.High, bloodPressure.Category);
    }

    // Boundary cases
    [Fact]
    public void BloodPressureCategory_ShouldBeIdeal_WhenPressureIsOnUpperBoundaryOfIdeal()
    {
        var bloodPressure = new BloodPressure { Systolic = 119, Diastolic = 79 };
        Assert.Equal(BPCategory.Ideal, bloodPressure.Category);
    }

    [Fact]
    public void BloodPressureCategory_ShouldBePreHigh_WhenPressureIsOnLowerBoundaryOfPreHigh()
    {
        var bloodPressure = new BloodPressure { Systolic = 120, Diastolic = 80 };
        Assert.Equal(BPCategory.PreHigh, bloodPressure.Category);
    }

    [Fact]
    public void BloodPressureCategory_ShouldBeHigh_WhenSystolicIsOnLowerBoundaryOfHigh()
    {
        var bloodPressure = new BloodPressure { Systolic = 140, Diastolic = 89 };
        Assert.Equal(BPCategory.High, bloodPressure.Category);
    }

    [Fact]
    public void BloodPressureCategory_ShouldBeHigh_WhenDiastolicIsOnLowerBoundaryOfHigh()
    {
        var bloodPressure = new BloodPressure { Systolic = 139, Diastolic = 90 };
        Assert.Equal(BPCategory.High, bloodPressure.Category);
    }
}
