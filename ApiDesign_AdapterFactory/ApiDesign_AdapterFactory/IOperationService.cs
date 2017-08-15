using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesign_AdapterFactory
{
   public interface IOperationService:IBajajOperationService,IKotakOperationService,IRelianceOperationService
    {
        void AddOperation();
        void SubtractOperation();
        void MultiplyOperation();
        void DivideOperation();
    }

   public interface IBajajOperationService
   {
       void AddOperation();
       void SubtractOperation();
       void MultiplyOperation();
       void DivideOperation();
   }


   public interface IKotakOperationService
   {
       void AddOperation();
       void SubtractOperation();
       
   }

   public interface IRelianceOperationService
   {
       //Target Client Interfaces
       void AddOperation();
       void SubtractOperation();
       void MultiplyOperation();  // Required Different Logic
       void DivideOperation();   //Required different Logic
   }
}
