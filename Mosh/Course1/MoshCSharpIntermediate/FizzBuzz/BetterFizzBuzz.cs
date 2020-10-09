namespace FizzBuzz
{
    public class BetterFizzBuzz
    {
        int currentNumber;
        public void FizzBuzz(int firstNumber, int secondNumber)
        {
            for (int i = 1; i <= 100 ; i++)
            {
                currentNumber = i;
                if (currentNumber % firstNumber == 0 && currentNumber % secondNumber == 0)
                {
                    System.Console.WriteLine("FIZZBUZZ");
                }
                else if (currentNumber % firstNumber == 0)
                {
                    System.Console.WriteLine("FIZZ");
                }
                else if (currentNumber % secondNumber == 0)
                {
                    System.Console.WriteLine("BUZZ");
                }
                else
                {
                    System.Console.WriteLine(currentNumber);
                }

            }
        }
    }
}
