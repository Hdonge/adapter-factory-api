using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesign_AdapterFactory
{
    public class OperationService:IOperationService
    {
        //Operation Service which providing services to Insurance companies.
        public virtual void AddOperation()
        {
            //Add Operation Logic goes here
            Console.WriteLine("This is base implimentation of Add Operation");
        }

        public virtual void SubtractOperation()
        {
            //Subtract Operation Logic goes here
            Console.WriteLine("This is base implimentation of Subtract Operation");
        }

        public virtual void MultiplyOperation()
        {
            //Multiply Operation Logic goes here
            Console.WriteLine("This is base implimentation of Multiply Operation");
        }

        public virtual void DivideOperation()
        {
            //Divide Operation Logic goes here
            Console.WriteLine("This is base implimentation of Divide Operation");
        }
    }
}
