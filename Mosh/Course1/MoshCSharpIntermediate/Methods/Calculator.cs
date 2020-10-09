namespace Methods
{
    partial class Program
    {
        public class Calculator
        {
            // the params keyword allows us to use a varing number of parameters wach time we call the method
            public int Add(params int[] numbers)
            {
                var sum = 0;
                foreach (var number in numbers)
                {
                    sum += number;
                }
                return sum;
            }
        }
    }
}
