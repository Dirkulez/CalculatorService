using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class Calculator : ICalculator
    {
        public Result Add(Arguments arg)
        {
            var result = new Result();
            result.Value = arg.Arg1 + arg.Arg2;
            return result;
        }
    }
}
