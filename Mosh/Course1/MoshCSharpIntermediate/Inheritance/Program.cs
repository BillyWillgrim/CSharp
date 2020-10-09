namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            System.Console.WriteLine(text.Width);
            text.Copy();

        }
    }
}
