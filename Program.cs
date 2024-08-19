var numbers = new List<int> { 5, 10, 15, 20, -30, -2 };

bool shallAddPositiveOnly = true;

int sum;
if (shallAddPositiveOnly)
{
    sum = new PositiveNumbersSumCalculator().Calculate(numbers);
}
else
{
    sum = new NumbersSumCalculator().Calculate(numbers);
}

Console.WriteLine("The sum is: " + sum);
Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> nums)
    {
        int sum = 0;

        foreach (var num in nums)
        {
            sum += num;
        }

        return sum;
    }
}

public class PositiveNumbersSumCalculator
{
    public int Calculate(List<int> nums)
    {
        int sum = 0;

        foreach (var num in nums)
        {
            if (num > 0)
            {
                sum += num;
            }
        }

        return sum;
    }
}