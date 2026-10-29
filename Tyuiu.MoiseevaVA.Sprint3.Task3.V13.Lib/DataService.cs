using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoiseevaVA.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach (char chr in value) //перебираем каждыйф символ в строке
            {
                if (char.IsDigit(chr)) //если символ==цифра

                {
                    res += chr;
                }
            }
            return int.Parse(res); //преобразовывае накопленную строку из цифр в число int
        }

    }
}
