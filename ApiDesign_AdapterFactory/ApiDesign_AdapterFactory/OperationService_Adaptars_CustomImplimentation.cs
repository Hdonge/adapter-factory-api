using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesign_AdapterFactory
{
    class RelianceOperationAdaptar:OperationService
    {
        public override void MultiplyOperation()
        {
            Console.WriteLine("This is custom implimentation of multiply operation");
        }

        public override void DivideOperation()
        {
            Console.WriteLine("This is custom implimentation of multiply operation");
        }
    }
}
