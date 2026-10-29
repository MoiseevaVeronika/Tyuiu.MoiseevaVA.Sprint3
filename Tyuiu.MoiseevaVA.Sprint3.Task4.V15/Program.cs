using Tyuiu.MoiseevaVA.Sprint3.Task4.V15.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(" Начало шага: " + startValue);
            Console.WriteLine(" Конец шага: " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение ряда=" + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
    
}
