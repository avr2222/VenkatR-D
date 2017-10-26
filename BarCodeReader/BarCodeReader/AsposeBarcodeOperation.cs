using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.BarCode;
using System.IO;
using System.Drawing;

namespace BarCodeReader
{
    public class AsposeBarcodeOperation
    {

        public void ReadBarCode()
        {
          
        }

        public void GenerateBarCode(string barCodeText)
        {
            //text needed on bar code 
            BarCodeBuilder codeBuilder = new BarCodeBuilder(barCodeText);
            
            //backcolor of the barcode 
            //codeBuilder.BackColor = System.Drawing.Color.Blue;
            codeBuilder.BorderColor = Color.Red;
            codeBuilder.Save(Path.Combine(Directory.GetCurrentDirectory(), Guid.NewGuid() + ".bmp"));
        }
    }
}
