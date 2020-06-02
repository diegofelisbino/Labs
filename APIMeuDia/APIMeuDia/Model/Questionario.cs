using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace APIMeuDia.Model
{
    public class Questionario
    {        
        public bool MeSintoBem { get; set; }
        public bool Febre { get; set; }
        public double Temperatura { get; set; }
        public bool Corisa { get; set; }
        public bool DorGarganta { get; set; }
        public bool ConsultaMedica { get; set; }
        public string  Outros { get; set; }
    }
}
