using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lab7
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IFunctionCalculate" в коде и файле конфигурации.
    [ServiceContract]
    public interface IFunctionCalculate
    {
        [OperationContract]
        double Number8(double x, double y);

        [OperationContract]
        double Number20(double x, double y);

        [OperationContract]
        double Number22(double x, double y);
    }
}
