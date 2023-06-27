using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lab7
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "FunctionCalculate" в коде и файле конфигурации.
    public class FunctionCalculate : IFunctionCalculate
    {

        public double Number8(double x, double y)
        {
           double result = (7 * x + 3 * y) * 4.5;
            Console.WriteLine($"Number20: ({x}, {y}) = result: {result}");
            return result;
        }

        public double Number20(double x, double y)
        {
            double result = (2 * (5 * x + 6 * y) / 5);
            Console.WriteLine($"Number8: ({x}, {y}) = result: {result}");
            return result;
        }
    }
}
