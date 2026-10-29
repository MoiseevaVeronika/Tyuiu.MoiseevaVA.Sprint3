using Tyuiu.MoiseevaVA.Sprint3.Task3.V13.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            string value = "?sd!! 5gh. s!";
            int wait = 5;
            Console.WriteLine(" Исходная строка " + value);
            Console.WriteLine(" Исходная цифра: " + wait);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Полученное число " + ds.ConvertStringToInt(value));
            Console.ReadKey();
        }
    }
}
