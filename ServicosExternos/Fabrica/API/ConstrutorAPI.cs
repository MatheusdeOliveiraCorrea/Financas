using System;
using System.Collections.Generic;
using System.Text;

namespace ServicosExternos.Fabrica.API
{
    public class ConstrutorAPI
    {
        public IContratoAPI CriarAPI()
        {
            return new ServicosAPI();
        }
    }
}
