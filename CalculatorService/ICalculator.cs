using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Result Add(Arguments arg);
    }
}
