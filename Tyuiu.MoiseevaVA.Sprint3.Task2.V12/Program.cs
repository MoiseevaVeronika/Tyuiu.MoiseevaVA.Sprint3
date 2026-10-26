using Tyuiu.MoiseevaVA.Sprint3.Task2.V12.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 5;
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(" Х= " + value);
            Console.WriteLine(" Начало шага: " + startValue);
            Console.WriteLine(" Конец шага: " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение ряда=" + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
