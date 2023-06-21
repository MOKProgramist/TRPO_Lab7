using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lab7
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Calculator : ICapculator
    {
        public double Add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine($"Получено Add: ({n1},{n2}) ");
            Console.WriteLine($"Возвращено ({result}) ");
            return result;
        }


        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine($"Получено Subtract: ({n1},{n2}) ");
            Console.WriteLine($"Возвращено ({result}) ");
            return result;
        }
    }
}
