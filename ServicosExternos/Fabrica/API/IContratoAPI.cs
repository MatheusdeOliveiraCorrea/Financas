using Nucleo.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicosExternos.Fabrica.API
{
    public interface IContratoAPI
    {
        FundosInvestimentoImobiliarioFII BuscarFII(string codigoFII);
    }
}
