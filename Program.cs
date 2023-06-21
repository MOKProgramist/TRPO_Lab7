using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем объект serviceHost класса ServiceHost для типа Calculator.
            ServiceHost serviceHost = new ServiceHost(typeof(Calculator));
            // Вызываем метод Open() для прослушивания (listeners) запросов от клиентов
            // поступающих по заданному адресу.
            serviceHost.Open();
            // создаем объект serviceHost класса ServiceHost для типа Calculator.
            ServiceHost serviceHostFunctionCalculate = new ServiceHost(typeof(FunctionCalculate));
            // Вызываем метод Open() для прослушивания (listeners) запросов от клиентов
            // поступающих по заданному адресу.
            serviceHostFunctionCalculate.Open();
            // после этого, данный сервис становится доступным для клиентов.
            // Выводим сообщения на экран
            Console.WriteLine("Сервис готов к работе");
            Console.WriteLine("Для завершения работы сервиса нажмите ENTER ");
            Console.ReadLine();
        }
    }
}
