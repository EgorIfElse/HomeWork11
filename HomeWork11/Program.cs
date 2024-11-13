namespace HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double B = Convert.ToDouble(Console.ReadLine());
           double K = Convert.ToDouble(Console.ReadLine());

            Line line = new Line(B, K);
            Console.WriteLine(line.Root());

        }
    }
}
