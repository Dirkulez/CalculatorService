using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalculatorClient("basicHttp");
            var arguments = new Arguments {Arg1 = 100, Arg2 = 200};
            Console.WriteLine("Addiere " + arguments.Arg1 + " und " + arguments.Arg2 + ".");
            var result = client.Add(arguments);
            Console.WriteLine("Das Ergebnis ist: " + result.Value);
            Console.ReadLine();
        }
    }
}
