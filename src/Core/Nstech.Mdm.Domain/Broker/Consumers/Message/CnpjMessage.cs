using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nstech.Mdm.Domain.Broker.Consumers.Message
{
    public class CnpjMessage
    {
        public string Cnpj { get; set; }

        public void CleanMask() => Cnpj = Regex.Replace(Cnpj, @"\D", "");
    }
}
