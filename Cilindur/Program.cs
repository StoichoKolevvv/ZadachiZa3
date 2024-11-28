namespace Cilindur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine($"S = {CilindurData.Area(r, h)}, V = {CilindurData.Volume(r, h)}");






        }
    }
}
