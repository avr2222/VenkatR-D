using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            AsposeBarcodeOperation asposeBarcode = new AsposeBarcodeOperation();
            asposeBarcode.GenerateBarCode("Helloworld");
            Console.WriteLine("Operation completed");
            Console.ReadLine();
        }
    }
}
