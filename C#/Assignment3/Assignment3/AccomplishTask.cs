namespace Assignment3;

public class AccomplishTask
{
    public int[] GenerateNumbers()
    {
        int[] numbers = new int[10];
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randNumber = rand.Next(0, 100);
            numbers[i] = randNumber;
        }
        return numbers;

    }


    
    public void Reverse(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length - 1;
        int temp;

        // reverse the sub-array [left, right]
        while (left < right)
        {
            temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
            left += 1;
            right -= 1;
        }
    }
    public void PrintNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}