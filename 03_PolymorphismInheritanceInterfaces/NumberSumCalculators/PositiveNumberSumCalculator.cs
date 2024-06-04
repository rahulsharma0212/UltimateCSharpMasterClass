namespace Polymorphism.NumberSumCalculators;

public class PositiveNumberSumCalculator : NumberSumCalculators {
    public override bool ShallBeAdded(int num)
    {
        return num > 0;
    }
}