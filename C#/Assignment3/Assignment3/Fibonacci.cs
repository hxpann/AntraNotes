namespace Assignment3;

public class Fibonacci
{
    public static int MyFibo(int number)
    {
        if (number <= 2)
        {
            return number;
        }
        else
        {
            return MyFibo(number - 1) + MyFibo(number - 2);
        }
    }



    public static void Main(String[] arg)
    {
        for (int i = 1; i <= 10; i++)
        {
            int number = MyFibo(i);
            Console.WriteLine("{i}", number);
        }
    }
}