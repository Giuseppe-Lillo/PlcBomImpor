using Sap.Plc.AddIn.AddInView;
using System;
using System.AddIn;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcBomImport
{

    [AddIn("PlcBomImportAddInn",
         Description = "A demo add-in to Import BOM from WindChill",
         Publisher = "Espedia", Version = "1.0.0.0")]
    [QualificationData(AddInConstants.AddInGuid,
        "8E3C5F97-49A5-427C-910C-CCA5ABF4B80E")]

public class PlcBomImportAddInn : AddInBase
    {
        public override bool Setup()
        {
            return true;
        }
    }
}
