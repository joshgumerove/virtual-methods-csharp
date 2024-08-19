var numbers = new List<int> { 5, 10, 15, 20, -30, -2 };

bool shallAddPositiveOnly = true;

NumbersSumCalculator calculator =
    shallAddPositiveOnly ?
    new PositiveNumbersSumCalculator() :
    new NumbersSumCalculator();

var sum = calculator.Calculate(numbers);

Console.WriteLine("The sum is: " + sum);
Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> nums)
    {
        int sum = 0;

        foreach (var num in nums)
        {
            if (ShallBeAdded(num))
            {

                sum += num;
            }
        }

        return sum;
    }

    protected virtual bool ShallBeAdded(int num)
    {
        return true;
    }
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int num)
    {
        return num > 0;
    }
}