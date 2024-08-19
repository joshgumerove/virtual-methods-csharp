var numbers = new List<int> { 5, 10, 15, 20 };
var calculator = new NumbersSumCalculator();

Console.WriteLine(calculator.Calculate(numbers));
Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> nums)
    {
        int sum = 0;

        foreach(var num in nums)
        {
            sum += num;
        }

        return sum;
    }
}
