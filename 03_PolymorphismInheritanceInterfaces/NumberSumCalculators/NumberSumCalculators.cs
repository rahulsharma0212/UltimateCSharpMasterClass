namespace Polymorphism.NumberSumCalculators;
public class NumberSumCalculators
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            if (ShallBeAdded(num))
            {
                sum += num;
            }
        }
        return sum;
    }

    public virtual bool ShallBeAdded(int num) {
        return true;
    }
}
