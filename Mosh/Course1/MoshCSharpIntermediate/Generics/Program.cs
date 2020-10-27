namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();

            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();

            dictionary.Add("Dark Matter", new Book());

            var number = new Nullable<int>();
            System.Console.WriteLine("Has value? " + number.HasValue);

            System.Console.WriteLine("Value: " + number.GetValueOrDefault());

        }
    }

}
