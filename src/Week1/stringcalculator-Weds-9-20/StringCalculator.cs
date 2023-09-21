namespace StringCalculator;

public class StringCalculator
{
    public int Add(string numbers)
    {
        List<char> delimiters = new List<char> { ',', '\n' };
        if (numbers.Contains("//"))
        {
            delimiters.Add(numbers[2]);
            numbers = numbers.Remove(0, 4);
        }
        int sum = 0;
        if (numbers != "")
        {
            char[] delims = delimiters.ToArray();
            string[] nums = numbers.Split(delims);
            foreach (string num in nums)
            {
                sum += int.Parse(num);
            }
        }

        return sum;
    }
}