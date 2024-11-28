namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi 3 cifreno chislo: ");
            int number = int.Parse(Console.ReadLine());

            int stotici = number / 100;
            int desetici = (number / 10) - (stotici * 10);
            int edinici = number - ((stotici * 100) + (desetici * 10));

            Console.WriteLine($"stotici = {stotici}, Desetici = {desetici}, Edinici = {edinici}");








        }
    }
}
