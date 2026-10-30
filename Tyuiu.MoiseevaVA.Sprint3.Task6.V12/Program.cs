using Tyuiu.MoiseevaVA.Sprint3.Task6.V12.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            int startValue = 9;
            int stopValue = 18;

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(" Начало отрезка: " + startValue);
            Console.WriteLine(" Конец отрезка: " + stopValue);
         
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма делителей=" + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
