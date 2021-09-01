using ConfiguraImpressora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfiguraImpressora.Interface
{
    internal interface IEAPrinterManager
    {
        bool ConfiguraImpressora(PrinterModel impressora);
    }
}
