namespace Task_3;

public class ParameterDemo
{
    // 1. Ref parameter
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    // 2. Out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Shreya Khanal";
    }

    // 3. Params parameter
    public int SumAll(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        return sum;
    }
}