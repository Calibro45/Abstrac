namespace Abstrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rettangolo = new Rettangolo(5, 10);
            var perimetro = rettangolo.Perimetro();
            var area = rettangolo.Area();

            Console.WriteLine($"Perimetro: {perimetro}\nArea: {area}");

        }
    }
}
