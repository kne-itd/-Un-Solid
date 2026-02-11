using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Un_Solid
{
    internal interface IDatabaseSaver : IInvoiceSaver
    {
        public void CreateConnection();
    }
}
