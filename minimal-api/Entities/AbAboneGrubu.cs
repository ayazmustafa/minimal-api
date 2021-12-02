using System;
using System.Collections.Generic;

#nullable disable

namespace minimal_api.Entities
{
    public partial class AbAboneGrubu
    {
        public int IdAboneGrubu { get; set; }
        public string AboneGrubuAdi { get; set; }
        public bool KismiOdemeYapabilir { get; set; }
    }
}
