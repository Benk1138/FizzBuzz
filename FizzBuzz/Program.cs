namespace FizzBuzz;
class program
{
    static void main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"{i}: {FizzBuzz(i)}");
        }
    }
    public static string FizzBuzz(int num)
    {
        var answer = "";

        if (num % 3 == 0)
        {
            answer += "Fizz";
        }
        if (num % 5 == 0)
        {
            answer += "Buzz";
        }

        return answer;



    }
}





