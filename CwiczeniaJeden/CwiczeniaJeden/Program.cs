// See https://aka.ms/new-console-template for more information

class Program
{

    static int Method(int[]  array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        
        sum = sum / array.Length;
        
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Yuppie, absolutely new modification!");
        
        Console.WriteLine(Method([2,4,6,8,10,11,15]));
    }
   

}