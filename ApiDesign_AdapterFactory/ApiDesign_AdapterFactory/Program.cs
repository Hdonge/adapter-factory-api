using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesign_AdapterFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *First Client is Bajaj Insurance. They want all operation which are provided in Opeartion Service API
             */

            IBajajOperationService _bajaOps = new OperationService();
            _bajaOps.AddOperation();
            _bajaOps.SubtractOperation();
            _bajaOps.MultiplyOperation();
            _bajaOps.DivideOperation();


            IKotakOperationService _kotakOps = new OperationService();
            _kotakOps.AddOperation();
            _kotakOps.SubtractOperation();


            IRelianceOperationService _relianceOps = new RelianceOperationAdaptar();
            _relianceOps.AddOperation();
            _relianceOps.SubtractOperation();
            _relianceOps.MultiplyOperation();
            _relianceOps.DivideOperation();

            Console.Read();
        }
    }
}
